using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Assignment.Service.Model.EventRegistration
{
    public class EventRgistrationPassQrRQ
    {
        public IFormFile Image {get;set;}
    }
}