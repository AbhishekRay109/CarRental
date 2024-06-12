using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.QuizGameServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class QuizCategoryController : ControllerBase
    {
        private readonly QuizCategoryService _categoryService;

        public QuizCategoryController(QuizCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// This API is used to create a new category.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        
        [HttpPost("/category")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] QuizCategoryRQ category)
        {
            try
            {
                var createdCategory = await _categoryService.CreateCategoryAsync(category);
                return Ok(ResponseHandler.HandleSuccess("Category added successfully",createdCategory));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizCategory>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to fetch all categories.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response> 
        
        [CustomAuthorize("quiz-admin")]
        [HttpGet("/categories")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            try
            {
                var categories = await _categoryService.GetAllCategoriesAsync();
                return Ok(ResponseHandler.HandleSuccess("Categories fetched successfully",categories));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizCategory>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to update a category.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response> 
        [HttpPut("/category/{categoryId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> UpdateCategoryAsync(int categoryId, [FromBody] QuizCategoryRQ category)
        {
            try
            {
                var updatedCategory = await _categoryService.UpdateCategoryAsync(categoryId, category);
                return Ok(ResponseHandler.HandleSuccess("Category updated successfully",updatedCategory));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizCategory>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to delete a category.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete("/category/{categoryId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> DeleteCategoryAsync(int categoryId)
        {
            try
            {
                var isDeleted = await _categoryService.DeleteCategoryAsync(categoryId);
                if (isDeleted)
                {
                    return Ok("Category deleted successfully.");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizCategory>("BadRequest", ex.Message));
            }
        }
    }
}