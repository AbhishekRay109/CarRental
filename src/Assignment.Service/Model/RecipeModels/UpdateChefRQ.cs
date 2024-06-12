﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.RecipeModels
{
    public class UpdateChefRQ
    {
        public string ChefName { get; set; }

        [EmailAddress]
        public string Email { get; set; } 
        public string Password {  get; set; }
    }
}
