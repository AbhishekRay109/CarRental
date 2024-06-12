using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal;
using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models;
using Assignment.Api.Models.Recipe;
using Assignment.Infrastructure.Repository.RecipeRepository;
using Assignment.Service.Model.RecipeModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.RecipeService
{
    public class RecipesService
    {
        private readonly IDBRecipeRepository _dBRecipeRepository;
        private readonly IDBRecipeMappingRepository _dBRecipeMappingRepository;

        public RecipesService(IDBRecipeMappingRepository dBRecipeMappingRepository ,IDBRecipeRepository dBRecipeRepository) 
        {
            _dBRecipeRepository = dBRecipeRepository;
            _dBRecipeMappingRepository = dBRecipeMappingRepository;
        }


        public async Task<List<GetAllRS>> GetAllRecipe()
        {
            var result = await _dBRecipeRepository.GetAllAsync();
            var addRecipeList = result.Select(recipe => new GetAllRS
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Cuisine = recipe.Cuisine,
                Ingredients = recipe.Ingredients,
                Instructions = recipe.Steps
            }).ToList();

            return addRecipeList;

        }
        public List<GetAllRS> GetRecipesByCuisine(string cuisine)
        {
            var result = _dBRecipeRepository.GetRecipesByCuisine(cuisine);
            var getRecipeList = result.Select(recipe => new GetAllRS
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Cuisine = recipe.Cuisine,
                Ingredients = recipe.Ingredients,
                Instructions = recipe.Steps
            }).ToList();

            return getRecipeList;
        }
        public async Task<AddRecipeRS> GetRecipeById(int recipeId)
        {

            var result =  await _dBRecipeRepository.GetRecipeByIdAsync(recipeId);
            if(result== null)
            {
                return null;
            }
            var chefId =  _dBRecipeMappingRepository.GetChefId(recipeId);
            var model = new AddRecipeRS
            {
                RecipeId = recipeId,
                ChefId = chefId,
                RecipeName = result.RecipeName,
                Cuisine = result.Cuisine,
                Ingredients = result.Ingredients,
                Instructions = result.Steps
            };
            return model;
        }
        public List<GetAllRS> GetRecipesByRecipeName(string recipeName)
        {
            var result = _dBRecipeRepository.GetRecipesByRecipeName(recipeName);
            var getRecipeList = result.Select(recipe => new GetAllRS
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Cuisine = recipe.Cuisine,
                Ingredients = recipe.Ingredients,
                Instructions = recipe.Steps
            }).ToList();

            return getRecipeList;
        }
        public async Task<List<GetAllRS>> GetRecipesByChefId(int chefId)
        {
            var result = await _dBRecipeRepository.GetAllRecipesByChefId(chefId);
            var getRecipeList = result.Select(recipe => new GetAllRS
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Cuisine = recipe.Cuisine,
                Ingredients = recipe.Ingredients,
                Instructions = recipe.Steps
            }).ToList();
            return getRecipeList;

        }
        public async Task<AddRecipeRS> CreateRecipe(AddRecipesRQ requestModel)
        {
            var recipe = new Recipes
            {
                RecipeName = requestModel.RecipeName,
                Cuisine = requestModel.Cuisine,
                Ingredients = requestModel.Ingredients,
                Steps = requestModel.Instructions
            };

            var addedRecipe = await _dBRecipeRepository.AddAsync(recipe);

            var chefRecipeMapping = new RecipeChefMapping
            {
                ChefId = requestModel.ChefId,
                RecipeId = addedRecipe.RecipeId  
            };

            await _dBRecipeMappingRepository.AddAsync(chefRecipeMapping);

            var response = new AddRecipeRS
            {
                RecipeId = recipe.RecipeId,
                RecipeName = requestModel.RecipeName,
                Cuisine = requestModel.Cuisine,
                Ingredients = requestModel.Ingredients,
                Instructions = requestModel.Instructions,
                ChefId = requestModel.ChefId,
            };
            return response;
        }
        public  bool isValidMapping(int chefId,int recipeId)
        {
            bool isValidMapping =  _dBRecipeMappingRepository.IsValidMapping(chefId, recipeId);
            if (!isValidMapping)
            {
                return false; 
            }
            return true;
        }
        public async Task<UpdateRecipeRS> UpdateRecipe(int recipeId,UpdateRecipeRQ requestModel)
        {

            var existingRecipe = await _dBRecipeRepository.GetAsync(recipeId);

            if (existingRecipe != null)
            {
                existingRecipe.Ingredients = requestModel.Ingredients;
                existingRecipe.Steps = requestModel.Instructions;
                await _dBRecipeRepository.UpdateAsync(existingRecipe);
            }
            var result = new UpdateRecipeRS
            {
        
                RecipeId = recipeId,
                RecipeName = existingRecipe.RecipeName,
                Ingredients = existingRecipe.Ingredients,
                Instruction = existingRecipe.Steps,

            };
            return result;
        }

        public async Task<bool> DeleteRecipe(int recipeId)
        {
            await _dBRecipeRepository.DeleteAsync(recipeId);
            return true;

        }
        
    }
}
