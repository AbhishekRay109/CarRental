﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Inventory
{
    public class InCategoryRS
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
