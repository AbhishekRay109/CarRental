using Assignment.Api.Models.Recipe;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.RecipeInterfaces
{
    public interface IDBRecipeMappingRepository : IDBGenericRepository<RecipeChefMapping>
    {
        bool IsValidMapping(int chefId, int recipeId);
        int GetChefId(int chefId);
    }
}
