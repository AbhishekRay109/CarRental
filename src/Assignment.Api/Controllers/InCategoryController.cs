using Assignment.Api.Models.Inventory;
using Assignment.Service.Model.Inventory;
using Assignment.Service.Services.Inventory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InCategoryController : ControllerBase
    {
        private readonly InCategoryService _categoryService;

        public InCategoryController(InCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<InCategory>> GetCategories()
        {
            return await _categoryService.GetCategoriesAsync();
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<InCategory>> GetCategoryById(int categoryId)
        {
            var category = await _categoryService.GetCategoryByIdAsync(categoryId);
            if (category == null)
            {
                return NotFound();
            }
            return category;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] InCategoryRQ categoryRequest)
        {
            try
            {
                await _categoryService.AddCategoryAsync(categoryRequest);
                return Ok("Category added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("{categoryId}")]
        public async Task<IActionResult> UpdateCategory(int categoryId, [FromBody] InCategoryRQ categoryRequest)
        {
            try
            {
                var existingCategory = await _categoryService.GetCategoryByIdAsync(categoryId);
                if (existingCategory == null)
                {
                    return NotFound($"Category with ID {categoryId} not found.");
                }

                await _categoryService.UpdateCategoryAsync(categoryId, categoryRequest);
                return Ok("Category updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }
        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            try
            {
                var existingCategory = await _categoryService.GetCategoryByIdAsync(categoryId);
                if (existingCategory == null)
                {
                    return NotFound($"Category with ID {categoryId} not found.");
                }

                await _categoryService.DeleteCategoryAsync(categoryId);
                return Ok("Category deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
