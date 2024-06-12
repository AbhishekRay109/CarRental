using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.EventRegistration
{
    public class EventRegistrationOtpModel
    {
        public string Email { get; set; }
        [Required]
        [MaxLength(6)]
        public string otp { get; set; }
    }
}