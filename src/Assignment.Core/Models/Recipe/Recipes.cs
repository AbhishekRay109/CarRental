using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Recipe
{
    public class Recipes
    {
        [Key]
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Cuisine { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public bool IsDeleted { get; set; }
        public List<RecipeChefMapping> ChefMappings { get; set; }
    }
}
