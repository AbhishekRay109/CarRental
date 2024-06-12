using Assignment.Api.Interfaces.RecipeInterfaces;
using Assignment.Api.Models;
using Assignment.Api.Models.Recipe;
using Assignment.Service.Model.RecipeModels;
using Assignment.Service.Services.RecipeService;
using IdentityServer4.Events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : BaseController
    {
        private readonly Serilog.Core.Logger logger;
        private readonly ChefService _chefService;
        private readonly IDBRecipeRepository _dBRecipeRepository;
        private readonly RecipesService _recipesService;
        private readonly List<string> validCuisines = new List<string>
    {
        "American", "Italian", "Mexican", "Chinese", "Indian",
        "Japanese", "French", "Mediterranean", "Thai", "Greek",
        "Korean",  "Spanish", "Russian",
        "Vegetarian/Vegan"
    };

        public RecipeController(IDBRecipeRepository dBRecipeRepository ,ChefService chefService, RecipesService recipesService, Serilog.Core.Logger logger) : base(logger)
        {
            _chefService = chefService;
            _dBRecipeRepository = dBRecipeRepository;
            _recipesService = recipesService;
            this.logger = logger;
        }

        [CustomAuthorize("manage-recipe")]
        [HttpPost]
        public async Task<IActionResult> AddRecipeAsync(AddRecipesRQ addRecipesRQ)
        {
            try
            { 
            var chefExists = await _chefService.GetChefsAsync(addRecipesRQ.ChefId);

            if (chefExists == null)
            {
                return BadRequest("Chef does not exist.");
            }
            var addedRecipeResponse = await _recipesService.CreateRecipe(addRecipesRQ);
            return Ok(addedRecipeResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }

        [CustomAuthorize("view-recipe")]
        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync()
        {
            try
            { 
            var result = await _recipesService.GetAllRecipe();
            return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }
        [CustomAuthorize("view-recipe")]
        [HttpGet("{recipeId}")]
        public async Task<IActionResult> GetRecipesByIdAsync(int recipeId)
        {
            try
            { 
            var result = await _recipesService.GetRecipeById(recipeId);
            if(result == null)
            {
                 return BadRequest("Recipe Not Found");
            }
            return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }
        [CustomAuthorize("view-recipe")]
        [HttpGet("byChef/{chefId}")]
        public async Task<IActionResult> GetRecipesByChefIdAsync(int chefId)
        {
            try
            { 
            var chefExists = await _chefService.GetChefsAsync(chefId);

            if (chefExists == null)
            {
                return BadRequest("Chef does not exist.");
            }
            var result = await _recipesService.GetRecipesByChefId(chefId);
            return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }

        }
        [CustomAuthorize("view-recipe")]
        [HttpGet("RecipeName/{recipeName}")]
        public ActionResult<List<GetAllRS>> GetRecipesByRecipeName(string recipeName)
        {
            try
            { 
            var recipes = _recipesService.GetRecipesByRecipeName(recipeName);
            return Ok(recipes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }

        [CustomAuthorize("view-recipe")]
        [HttpGet("cuisine/{cuisine}")]
        public async Task<IActionResult> GetRecipesByCuisine(string cuisine)
        {
            try 
            { 
            if (!IsValidCuisine(cuisine))
            {
                return BadRequest("Invalid cuisine. Please provide a valid cuisine.");
            }
            var recipes = _recipesService.GetRecipesByCuisine(cuisine);
            return Ok(recipes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }

        [CustomAuthorize("manage-recipe")]
        [HttpPut("{recipeId}")]
        public async Task<IActionResult> UpdateRecipe(int recipeId,UpdateRecipeRQ requestModel)
        {
            try
            { 
            var isValidMapping = _recipesService.isValidMapping(requestModel.ChefId, recipeId);
            if (isValidMapping == false)
            {
                return BadRequest("U cannot modify this recipe");
            }
            var details = await _recipesService.GetRecipeById(recipeId);
            if(details == null)
            {
                return BadRequest("Recipe not found");
            }
            var result = await _recipesService.UpdateRecipe(recipeId, requestModel);
            return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }
        }

        [CustomAuthorize("manage-recipe")]
        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteRecipe(int recipeId)
        {
            try 
            { 
            var model = await _recipesService.GetRecipeById(recipeId);
            if (model == null)
            {
                return NotFound("Recipe Not Found");
            }
            var result = await  _recipesService.DeleteRecipe(recipeId);
            
            return Ok("Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", ErrorDetails = ex.Message });
            }

        }
        private bool IsValidCuisine(string cuisine)
        {
            return validCuisines.Contains(cuisine, StringComparer.OrdinalIgnoreCase);
        }
    }
}
