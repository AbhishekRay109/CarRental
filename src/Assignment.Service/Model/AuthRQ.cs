using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model
{
    public class AuthRQ : BaseRQ
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class RefreshRQ : BaseRQ
    {
        public string Email { get; set; }
        public string RefreshToken { get; set; }
    }
}
