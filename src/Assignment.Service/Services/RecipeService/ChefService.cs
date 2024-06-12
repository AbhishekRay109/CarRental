using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models.Recipe;
using Assignment.Service.Model;
using Assignment.Service.Model.RecipeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.RecipeService
{
    public class ChefService
    {
        private readonly IDBChefRepository _dBChefRepository;

        public ChefService(IDBChefRepository dBChefRepository) 
        {
            _dBChefRepository = dBChefRepository;
        }

        public async Task<List<AddChefRS>> GetAllChefsAsync()
        {
            var chefDetails = await _dBChefRepository.GetAllAsync();
            var addRecipeList = chefDetails.Select(chef => new AddChefRS
            {
                ChefId = chef.ChefId,
                ChefName = chef.ChefName,
                Email = chef.EmailAddress
            }).ToList();
            return addRecipeList;
        }
        public async Task<RecipeChefs> GetChefsAsync(int chefId)
        {
            var chefDetails = await _dBChefRepository.GetChefsByName(chefId);
            return chefDetails;
        }
        public async Task<RecipeChefs> AddChefs(AddChefRQ addChefRQ)
        {
            var model = new RecipeChefs
            {
                ChefName = addChefRQ.ChefName,
                EmailAddress = addChefRQ.EmailAddress,
                Password = addChefRQ.Password,
            };
            var addedResult = await _dBChefRepository.AddAsync(model);
            return addedResult;
        }

        public async Task<RecipeChefs> UpdateChef(int chefId,UpdateChefRQ updateChefRQ)
        {
            var model = new RecipeChefs
            {
                ChefId = chefId,
                ChefName = updateChefRQ.ChefName,
                EmailAddress = updateChefRQ.Email,
                Password = updateChefRQ.Password,
            };
            var result = await _dBChefRepository.UpdateChef(model);
            var  response= new RecipeChefs
            {
                ChefId = result.ChefId,
                ChefName = result.ChefName,
                EmailAddress = result.EmailAddress,
                Password = result.Password,
            };
            return response;
        }
        public async Task<bool> DeleteChef(int chefId)
        {
            bool result = await _dBChefRepository.DeleteChefs(chefId);
            return result;
        }
        public  bool CheckChefName(string chefName)
        {
            bool result =  _dBChefRepository.IsNameUnique(chefName);
            return result;
        }

        public  bool CheckEmail(string email)
        {
            bool result = _dBChefRepository.IsEmailUnique(email);
            return result;
        }
    }
}
