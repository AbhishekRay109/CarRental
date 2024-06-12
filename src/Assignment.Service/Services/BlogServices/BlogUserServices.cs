using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Interfaces;
using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Service.Model;
using Assignment.Service.Model.BlogEngine;
using Jose;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.ComponentModel.Design;

namespace Assignment.Service.Services.BlogServices
{
    public class BlogUserServices
    {
        private readonly IDBBlogUserRepository _blogUserRepository;


        public BlogUserServices(IDBBlogUserRepository blogUserRepository)
        {
            _blogUserRepository = blogUserRepository;

        }

        public async Task<bool> GetUsername(string username)
        {
            var usernameExists = await _blogUserRepository.GetUsernameByIdAsync(username);

            if (usernameExists != null)
            {
                return true;
            }

            return false;
        }

        public bool isUsernameValid(string username)
        {
            string pattern = "^[a-zA-Z0-9_ ]+$";
            return Regex.IsMatch(username, pattern, RegexOptions.None, TimeSpan.FromSeconds(100));
        }

        public bool isEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern, RegexOptions.None, TimeSpan.FromSeconds(100));
        }

        public async Task<bool> GetUserId(int userId)
        {
            var userIdExists = await _blogUserRepository.GetUserIdByIdAsync(userId);
            

            if (userIdExists != null)
            {
                return true;
            }

            return false;
        }

        public async Task<BlogUsers> GetUser(int userId)
        {
            var userExists = await _blogUserRepository.GetUserIdByIdAsync(userId);

            return userExists;
        }
        public async Task<BlogUsers> UpdateUserByIdAsync(int userId, int tokenUserId)
        {
            var deleteuser = await _blogUserRepository.GetUserByIdAsync(userId);

            if (deleteuser.UserId == tokenUserId && deleteuser.IsActive == true)
            {
                deleteuser.IsActive = false;

                var deleteduser = await _blogUserRepository.UpdateUserAsync(deleteuser);
                return deleteduser;
            }
            return null;

        }
        

        public async Task<BlogUserUpdateRS> UpdateAsync(int userId, BlogUserUpdateRQ request, int tokenUserId)
        {

            var existingUser = await _blogUserRepository.GetUserIdByIdAsync(userId);

            if (existingUser != null && existingUser.IsActive == true && existingUser.UserId == tokenUserId)
            {
                existingUser.Username = request.Username;
                existingUser.Password = request.Password;
                existingUser.Email = request.Email;
                existingUser.IsActive = request.IsAuthor;
                existingUser.SubscriptionType = request.SubscriptionType;


                await _blogUserRepository.UpdateAsync(existingUser);

                BlogUserUpdateRS rs = new BlogUserUpdateRS()
                {
                    Username = request.Username,

                    Email = request.Email,
                    IsActive = request.IsAuthor,
                    SubscriptionType = request.SubscriptionType,


                };
                return rs;
                
            }
            return null;

        }


        public async Task<BlogUsers> CreateUserAsync(string username, BlogUserRQ request)
        {

            var userEntity = new BlogUsers
            {
                Username = username,
                Password = request.Password,
                Email = request.Email,
                IsAuthor = request.IsAuthor,
                SubscriptionType = request.SubscriptionType,
                RegistrationDate = DateTime.Now,
                IsActive = true,


            };
            try
            {
                // Set NumberOfPostAvailable and NumberOfPostRemaining based on conditions
                if (request.SubscriptionType == "Trial")
                {
                    userEntity.NumberOfPostAvailable = 10;
                    userEntity.NumberOfPostRemaining = 10;
                }
                else if (request.SubscriptionType == "Premium")
                {
                    userEntity.NumberOfPostAvailable = 1000;
                    userEntity.NumberOfPostRemaining = 1000;
                }
                else
                {

                    throw new ArgumentException("SubscriptionType can either be Trial or Premium");
                }

                await _blogUserRepository.AddAsync(userEntity);
                return userEntity;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error creating user: {ex.Message}");
                return null;
                throw;
            }

        }
        public async Task<string> ValidateUserAsync(BlogLoginRequest request)
        {
            var user = await _blogUserRepository.GetUserByUsernameAsync(request.Username);
            if (user == null || user.Password != request.Password)
            {
                throw new ArgumentException("Invalid Username or Password");
            }
            var accessToken = await GenerateJwtToken(user.Username);
            return accessToken;
        }

        public async Task<string> GenerateJwtToken(string username)
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
            var user = await _blogUserRepository.GetUserByUsernameAsync(username);

            if (user.IsAuthor == true)
            {

                claims.Add(new Claim("permissions", "blogpost" + "::" + "create"));
                claims.Add(new Claim("permissions", "blogpost" + "::" + "edit"));
                claims.Add(new Claim("permissions", "blogpost" + "::" + "delete"));
                claims.Add(new Claim("permissions", "blogpost" + "::" + "view"));

                claims.Add(new Claim("permissions", "blogcomment" + "::" + "create"));
                claims.Add(new Claim("permissions", "blogcomment" + "::" + "edit"));
                claims.Add(new Claim("permissions", "blogcomment" + "::" + "delete"));
                claims.Add(new Claim("permissions", "blogcomment" + "::" + "view"));

                claims.Add(new Claim("permissions", "bloguser" + "::" + "create"));
                claims.Add(new Claim("permissions", "bloguser" + "::" + "edit"));
                claims.Add(new Claim("permissions", "bloguser" + "::" + "delete"));
                claims.Add(new Claim("permissions", "bloguser" + "::" + "view"));

                claims.Add(new Claim("permissions", "blogsubscription" + "::" + "view"));

            }
            else if (user.IsAuthor == false)
            {

                claims.Add(new Claim("permissions", "blogpost" + "::" + "view"));

                claims.Add(new Claim("permissions", "bloguser" + "::" + "create"));
                claims.Add(new Claim("permissions", "bloguser" + "::" + "view"));

                claims.Add(new Claim("permissions", "blogcomment" + "::" + "view"));

                claims.Add(new Claim("permissions", "blogsubscription" + "::" + "view"));

            }
            else
            {
                claims.Add(new Claim("permissions", "bloguser" + "::" + "create"));

                claims.Add(new Claim("permissions", "event" + "::" + "view"));
            }

            claims.Add(new Claim("username", username));
            claims.Add(new Claim("userId", user.UserId.ToString()));
            claims.Add(new Claim("SubscriptionType", user.SubscriptionType.ToString()));
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

    }
}
