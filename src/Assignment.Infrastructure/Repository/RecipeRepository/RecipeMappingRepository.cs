using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.RecipeRepository
{
    public class RecipeMappingRepository : GenericRepository<RecipeChefMapping>, IDBRecipeMappingRepository
    {
        private readonly RaidenDBContext _dbContext;
        public RecipeMappingRepository(RaidenDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public bool IsValidMapping(int chefId, int recipeId)
        {
            return _dbContext.RecipeChefMapping
                .Any(mapping => mapping.ChefId == chefId && mapping.RecipeId == recipeId);
        }
        public int GetChefId(int recipeId)
        {
            int chefId = _dbContext.RecipeChefMapping.Where(mapping => mapping.RecipeId == recipeId).Select(mapping => mapping.ChefId).FirstOrDefault();
            return chefId;
        }

    }
}
