using Assignment.Api.Models.Recipe;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.RecipeInterfaces
{
    public interface IDBRecipeRepository : IDBGenericRepository<Recipes>
    {
        Task<Recipes> GetRecipeByIdAsync(int recipeId);
        Task<List<Recipes>> GetAllRecipesByChefId(int chefId);
        List<Recipes> GetRecipesByCuisine(string cuisine);
        List<Recipes> GetRecipesByRecipeName(string recipeName);
    }
}
