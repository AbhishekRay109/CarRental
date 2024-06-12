using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models.Recipe;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment.Infrastructure.Repository.RecipeRepository
{
    public class RecipeChefRepository : GenericRepository<RecipeChefs>, IDBChefRepository
    {
        private readonly RaidenDBContext _dbContext;
        public RecipeChefRepository(RaidenDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CheckChefById(int chefId)
        {
            var result = await _dbContext.RecipeChefs.FirstOrDefaultAsync(e => e.ChefId == chefId);
            if (result == null)
            {
                return false;
            }
            return true;
        }
        public async Task<RecipeChefs> GetChefsByName(int chefId)
        {
            var result = await _dbContext.RecipeChefs.FirstOrDefaultAsync(e => e.ChefId == chefId);
            return result;
        }
        //public async Task<RecipeChefs> AddChefs(string chefName)
        //{
        //    var newChef = new RecipeChefs
        //    {
        //        ChefName = chefName
        //    };
        //    await _dbContext.AddAsync(newChef);
        //    await _dbContext.SaveChangesAsync();
        //    return newChef;
        //}
        public async Task<RecipeChefs> UpdateChef(RecipeChefs recipeChefs)
        {
            _dbContext.Update(recipeChefs);
            await _dbContext.SaveChangesAsync();
            return recipeChefs;
        }

        public async Task<bool> DeleteChefs(int chefId)
        {
            var chefDetails = await _dbContext.RecipeChefs.FirstOrDefaultAsync(e => e.ChefId == chefId);
            if (chefDetails != null)
            {
                _dbContext.RecipeChefs.Remove(chefDetails);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public bool CheckIfEmailExists(string email)
        {
            return _dbContext.RecipeChefs.Any(chef => chef.EmailAddress == email);
        }

        public bool CheckPassword(string password)
        {
            return _dbContext.RecipeChefs.Any(chef => chef.Password == password);
        }

        public bool IsNameUnique(string name)
        {
            return !_dbContext.RecipeChefs.Any(c => c.ChefName == name);
        }
        public bool IsEmailUnique(string email)
        {
            return !_dbContext.RecipeChefs.Any(c => c.EmailAddress == email);
        }
    }
}
