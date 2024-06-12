using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.RecipeModels
{
    public class UpdateRecipeRQ
    {
        public int ChefId { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

    }
}
