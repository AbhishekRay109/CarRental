using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.RecipeModels
{
    public class GetAllRS
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Cuisine { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
