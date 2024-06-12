using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Recipe
{
    public class RecipeChefs
    {
        [Key]
        public int ChefId { get; set; }
        public string ChefName { get; set; }
        public string EmailAddress { get; set; }
        public string Password {  get; set; }   
        public List<RecipeChefMapping> RecipeMappings { get; set; }
    }
}

