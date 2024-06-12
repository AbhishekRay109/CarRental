using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models.Recipe;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.RecipeRepository
{
    public class RecipeRepository : GenericRepository<Recipes>,IDBRecipeRepository
    {
        private readonly RaidenDBContext _dbContext;
        public RecipeRepository(RaidenDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Recipes> GetRecipeByIdAsync(int recipeId)
        {
            var Recipe = _dbContext.Recipes.FirstOrDefault(e => e.RecipeId == recipeId);
            return Recipe;

        }
        public async Task<List<Recipes>> GetAllRecipesByChefId(int chefId)
        {
            return _dbContext.RecipeChefMapping.Where(mapping => mapping.ChefId == chefId).Select(mapping => mapping.Recipe).ToList();
        }
        public List<Recipes> GetRecipesByCuisine(string cuisine)
        {
            return _dbContext.Recipes.Where(r => r.Cuisine == cuisine).ToList();
        }
        public List<Recipes> GetRecipesByRecipeName(string recipeName)
        {
            return _dbContext.Recipes
                .Where(r => r.RecipeName.Contains(recipeName))
                .ToList();
        }

    }
}
