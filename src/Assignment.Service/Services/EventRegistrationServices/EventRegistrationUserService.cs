using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Assignment.Service.Model;
using Assignment.Service.Model.EventRegistration;
using Jose;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Assignment.Service.Services.EventRegistrationServices
{
    public class EventRegistrationUserService
    {
        private readonly IDBEventRegistrationUserRepository _eventRegistrationUserRepo;
        public EventRegistrationUserService(IDBEventRegistrationUserRepository eventRegistrationUserRepo)
        {
            _eventRegistrationUserRepo = eventRegistrationUserRepo;
        }

        public async Task<EventRegistrationUsers> SignUpAsync(EventRegistrationSignupRQ eventRegistrationSignupRQ)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(eventRegistrationSignupRQ.Email);
            if (userInfo != null)
            {
                throw new ArgumentException("Something went wrong");
            }
            if(!IsPasswordValid(eventRegistrationSignupRQ.Password))
            {
                throw new ArgumentException("Password does not meet the criteria");
            }
            if(!IsValidEmail(eventRegistrationSignupRQ.Email))
            {
                throw new ArgumentException("Invalid email format");
            }
            if(!IsValidPhoneNumber(eventRegistrationSignupRQ.Phone))
            {
                throw new ArgumentException("Invalid phone number format");
            }
            var newotp = OtpGenrator();
            EventRegistrationUsers modelRQ = new EventRegistrationUsers()
            {
                Email = eventRegistrationSignupRQ.Email,
                IsEmailVerified = false,
                IsOrganizer = eventRegistrationSignupRQ.IsOrganizer,
                FirstName = eventRegistrationSignupRQ.FirstName,
                LastName = eventRegistrationSignupRQ.LastName,
                Phone = eventRegistrationSignupRQ.Phone,
                otp = newotp,
                Password = eventRegistrationSignupRQ.Password
            };
            var rs = await _eventRegistrationUserRepo.SignUpAsync(modelRQ);
            await SendEmail(rs.Email, "Your otp for email validation is : " + newotp, "Otp for Email validation");
            rs.otp = "Sent Successfully";
            return rs;
        }
        public async Task<string> AuthenticationAsync(AuthRQ authRQ)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(authRQ.Email);
            if (userInfo == null || userInfo.Password != authRQ.Password)
            {
                throw new ArgumentException("Invalid Username or Password");
            }
            if (!userInfo.IsEmailVerified)
            {
                throw new ArgumentException("Email not verified");
            }
            var accessToken = await GenerateJwtToken(userInfo.Email);
            return accessToken;
        }
        public async Task<string> ResendOtpAsync(string email)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(email);
            if (userInfo == null)
            {
                throw new ArgumentException("Invalid User email");
            }
            if (userInfo.IsEmailVerified)
            {
                throw new ArgumentException("Email is verified");
            }
            var newotp = OtpGenrator();
            userInfo.otp = newotp;
            await _eventRegistrationUserRepo.UpdateUserAsync(userInfo);
            await SendEmail(email, "Your otp for email validation is : " + newotp, "Otp for Email validation");
            return "new otp sent successfully";
        }
        public async Task<bool> OtpValidationAsync(EventRegistrationOtpModel otpmodel, string email)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(email);
            if (userInfo == null || !userInfo.otp.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid UserId");
            }
            else if (userInfo.otp != otpmodel.otp)
            {
                throw new ArgumentException("Invalid Otp");
            }
            else
            {
                userInfo.IsEmailVerified = true;
                var rs = await _eventRegistrationUserRepo.UpdateUserAsync(userInfo);
                return rs.IsEmailVerified;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                var domainParts = emailAddress.Host.Split('.');
                if (domainParts.Length >= 2 && domainParts.Length <= 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public async Task<string> GenerateJwtToken(string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("Secret")));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                 new Claim(JwtRegisteredClaimNames.Sub, Environment.GetEnvironmentVariable("Subject")),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString())
            };
            var NullList = new List<Claim>();
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(email);
            if (userInfo.IsOrganizer)
            {
                claims.Add(new Claim("permissions", "event" + "::" + "create"));
                claims.Add(new Claim("permissions", "event" + "::" + "edit"));
                claims.Add(new Claim("permissions", "event" + "::" + "delete"));
                claims.Add(new Claim("permissions", "event" + "::" + "view"));
            }
            else
            {
                claims.Add(new Claim("permissions", "event" + "::" + "view"));
            }
            claims.Add(new Claim("email", email));
            var token = new JwtSecurityToken(
                Environment.GetEnvironmentVariable("ValidIssuer"),
                Environment.GetEnvironmentVariable("ValidIssuer"),
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );
            var encryptedJwt = EncryptJwt(token);
            return encryptedJwt;
        }
        public string EncryptJwt(JwtSecurityToken token)
        {
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            var payloadJson = JsonConvert.SerializeObject(tokenString);
            var certificatePath = Environment.GetEnvironmentVariable("CertificatePath");

            X509Certificate2 certWithPublicKey = new X509Certificate2(certificatePath);
            RSA rsaPublicKey = certWithPublicKey.GetRSAPublicKey();

            string encryptedJwt = JWT.Encode(payloadJson, rsaPublicKey, JweAlgorithm.RSA_OAEP, JweEncryption.A256GCM);

            return encryptedJwt;
        }

        public string OtpGenrator()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public async Task SendEmail(string toAddr, string mailbody, string subject)
        {
            MailMessage message = new MailMessage(Environment.GetEnvironmentVariable("PAVAN_EMAIL"), toAddr);
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(Environment.GetEnvironmentVariable("PAVAN_EMAIL"), Environment.GetEnvironmentVariable("PAVAN_EMAIL_PASS"));
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            client.Send(message);
        }
        private bool IsPasswordValid(string password)
        {
            if (password.Length < 4 || password.Length > 12)
            {
                return false;
            }
            if (!password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }

            return true;
        }
    }
}