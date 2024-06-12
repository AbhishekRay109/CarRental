using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Models.Recipe;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.RecipeInterfaces
{
    public interface IDBChefRepository : IDBGenericRepository<RecipeChefs>
    {
        Task<RecipeChefs> GetChefsByName(int chefId);
        Task<RecipeChefs> UpdateChef(RecipeChefs recipeChefs);

        Task<bool> DeleteChefs(int chefId);
        Task<bool> CheckChefById(int chefId);
        bool CheckIfEmailExists(string email);
        bool CheckPassword(string password);
        bool IsNameUnique(string name);
        bool IsEmailUnique(string email);


    }
}
