using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Recipe
{
    public class RecipeChefMapping
    {
        public int ChefId { get; set; }
        public int RecipeId { get; set; }

        public RecipeChefs Chef { get; set; }
        public Recipes Recipe { get; set; }
    }
}
