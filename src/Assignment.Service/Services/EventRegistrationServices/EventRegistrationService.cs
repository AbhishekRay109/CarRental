using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Assignment.Service.Model.EventRegistration;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Newtonsoft.Json;
using QRCoder;
using ZXing;
using ZXing.Common;
using ZXing.Common.Detector;

namespace Assignment.Service.Services.EventRegistrationServices
{
    public class EventRegistrationService
    {
        private readonly IDBEventRegistrationEventRepository _eventRegistrationEventRepo;
        private readonly IDBEventRegistrationUserRepository _eventRegistrationUserRepo;
        private readonly IDBEventRegistrationRepository _eventRegistrationRepo;
        public EventRegistrationService(IDBEventRegistrationRepository eventRegistrationRepo, IDBEventRegistrationEventRepository eventRegistrationEventRepo, IDBEventRegistrationUserRepository eventRegistrationUserRepo)
        {
            _eventRegistrationEventRepo = eventRegistrationEventRepo;
            _eventRegistrationUserRepo = eventRegistrationUserRepo;
            _eventRegistrationRepo = eventRegistrationRepo;
        }
        public async Task<EventRegistrationRS> RegisterForEventAsync(EventRegistrationRQ modelRQ, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            if(userInfo.IsOrganizer)
            {
                throw new ArgumentException("Organizer cannot register for the event.");
            }
            var eventInfo = await _eventRegistrationEventRepo.GetEventAsync(modelRQ.EventCode);
            if (eventInfo == null || !eventInfo.IsActive)
            {
                throw new ArgumentException("Event does not exists");
            }
            EventRegistration rq = new EventRegistration()
            {
                EventID = eventInfo.EventID,
                RegistrationDate = DateTime.Now,
                UserID = userInfo.UserID,
                Status = "Registered Successfully"
            };

            var output = await _eventRegistrationRepo.RegisterForEventAsync(rq);
            var passModel = new EventRegistrationPass()
            {
                IsUsed = false,
                RegistrationID = output.RegistrationID
            };
            var passInfo = await _eventRegistrationRepo.CreatePassAsync(passModel);
            var rs = new EventRegistrationRS()
            {
                Email = userEmail,
                EventCode = eventInfo.EventCode,
                RegistrationDate = output.RegistrationDate,
                RegistrationID = output.RegistrationID,
                Status = output.Status,
                PassId = passInfo.PassID
            };
            var passContent = JsonConvert.SerializeObject(rs);
            var qrCodeImage = QrCodeGenarator(passContent);
            sendQrCodeViaEmail(userEmail, qrCodeImage, passContent);
            return rs;
        }
        public async Task<IEnumerable<EventRegistrationRS>> GetRegisteredEventAsync(string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            var rs = await _eventRegistrationRepo.GetRegisteredEventAsync(userInfo.UserID);
            if (rs == null)
            {
                throw new ArgumentException("Not registered for any events");
            }
            var result = new List<EventRegistrationRS>();

            foreach (var item in rs)
            {
                var passInfo = await _eventRegistrationRepo.GetRegisteredEventPassAsync(item.RegistrationID);
                var eventInfo = await _eventRegistrationRepo.GetEventInfoAsync(item.EventID);
                var temp = new EventRegistrationRS()
                {
                    RegistrationDate = item.RegistrationDate,
                    Email = userEmail,
                    EventCode = eventInfo.EventCode,
                    PassId = passInfo.PassID,
                    RegistrationID = item.RegistrationID,
                    Status = item.Status
                };
                result.Add(temp);
            }
            return result;
        }

        public async Task<byte[]> GetPassByEventRegisteredId(int eventRegistrationId, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            var rs = await _eventRegistrationRepo.GetRegisteredEventAsync(userInfo.UserID);
            if (rs == null)
            {
                throw new ArgumentException("Not registered for any events");
            }
            var passInfo = await _eventRegistrationRepo.GetRegisteredEventPassAsync(eventRegistrationId);
            var eventInfo = await _eventRegistrationRepo.GetEventInfoAsync(passInfo.EventRegistration.EventID);
            var eventrs = new EventRegistrationRS()
            {
                Email = userEmail,
                EventCode = eventInfo.EventCode,
                RegistrationDate = passInfo.EventRegistration.RegistrationDate,
                RegistrationID = eventRegistrationId,
                Status = passInfo.EventRegistration.Status,
                PassId = passInfo.PassID
            };
            var passContent = JsonConvert.SerializeObject(eventrs);
            var qrCodeImage = QrCodeGenarator(passContent);
            return qrCodeImage;
        }
        public async Task<EventRegistrationPass> ValidatePass(EventRgistrationPassQrRQ model, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            byte[] ImageBytes = null;
            if (model.Image != null)
            {
                using (var stream = model.Image.OpenReadStream())
                {
                    using (var memoryStream = new System.IO.MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        ImageBytes = memoryStream.ToArray();
                    }
                }
            }
            var qrContent = DecodeQRCode(ImageBytes);
            var qrModel = JsonConvert.DeserializeObject<EventRegistrationRS>(qrContent);
            var eventInfo = await _eventRegistrationEventRepo.GetEventAsync(qrModel.EventCode);
            var organizerInfo = await _eventRegistrationUserRepo.GetOrganizerByEmailAsync(userEmail);
            if (organizerInfo.OrganizerID != eventInfo.OrganizerID)
            {
                throw new UnauthorizedAccessException("You cannot validate pass for this event (Organizer mistmatch)");
            }
            var rs = await _eventRegistrationRepo.GetRegisteredEventAsync(userInfo.UserID);
            if (rs == null)
            {
                throw new ArgumentException("Not registered for any events");
            }
            var existingPassData = await _eventRegistrationRepo.GetRegisteredEventPassAsync(qrModel.RegistrationID);
            if (!existingPassData.IsUsed)
            {
                var passModel = new EventRegistrationPass()
                {
                    IsUsed = true,
                    PassID = qrModel.PassId,
                    RegistrationID = qrModel.RegistrationID,
                };
                var passRs = await _eventRegistrationRepo.UpdatePassAsync(passModel);
                return passModel;
            }
            else
            {
                throw new ArgumentException("Pass is already validated. Not allowed to validate again");
            }
        }
        public string DecodeQRCode(byte[] imageBytes)
        {
            try
            {
                // Convert byte[] to Bitmap
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    var bitmap = new Bitmap(stream);

                    // Use ZXing.Net to decode the QR code
                    var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                    var result = reader.Decode(bitmap);

                    if (result != null)
                    {
                        // Extracted QR code data
                        string decodedData = result.Text;
                        return decodedData;
                    }
                    else
                    {
                        // Handle case where QR code could not be decoded
                        Console.WriteLine("QR code decoding failed.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during decoding
                Console.WriteLine($"Error decoding QR code: {ex.Message}");
                return null;
            }
        }

        public byte[] QrCodeGenarator(string content)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCoder.PngByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        public void sendQrCodeViaEmail(string userEmail, byte[] qrCodeImage, string content)
        {
            var message = new MailMessage
            {
                From = new MailAddress(Environment.GetEnvironmentVariable("PAVAN_EMAIL")),
                Subject = "Event Registration QR Code",
                Body = "<h3>Thank you for registering! Attached is your QR code.</h3>" + content,
                IsBodyHtml = true
            };
            var stream = new MemoryStream(qrCodeImage);
            var attachment = new Attachment(stream, "QRCode.png", "image/png");
            message.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("PAVAN_EMAIL"), Environment.GetEnvironmentVariable("PAVAN_EMAIL_PASS"));
            client.EnableSsl = true;
            message.To.Add(userEmail);
            client.Send(message);
        }


    }
}