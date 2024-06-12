using Assignment.Service.Model.ExpenseModel;
using Assignment.Service.Services.ExpenseService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("ledger")]
    [ApiController]
    public class ExpenseTrackerCategoryController : BaseController
    {
        private readonly ExpenseTrackerCategoryService _service;
        public ExpenseTrackerCategoryController(ExpenseTrackerCategoryService service, Serilog.Core.Logger logger) : base(logger)
        {
            this._service = service;
        }

        [Authorize]
        [HttpGet("{ledgerId}/categories")]
        public async Task<IActionResult> GetCategoryByLedgerId(int ledgerId) {
            try {
                if (!await CheckParams()) {
                    return Unauthorized();
                }
                var response = await _service.GetCategoryByLedgerId(ledgerId);
                return Ok(ResponseHandler.HandleSuccess("Category fetched", response));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<List<Category>>("Error", ex.Message));
            }
        }


        [Authorize]
        [HttpGet("{ledgerId}/{categoryId}")]
        public async Task<IActionResult> GetCategoryByCategoryId(int ledgerId, int categoryId)
        {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await _service.GetCategoryByCategoryId(ledgerId, categoryId);
                return Ok(ResponseHandler.HandleSuccess("Category fetched successfully", response));
            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Category>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpPost("{ledgerId}/category")]
        public async Task<IActionResult> AddCategory(int ledgerId, ExpenseTrackerCategoryRQ category) {
            try
            {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await _service.AddCategory(ledgerId, category);
                return Ok(ResponseHandler.HandleSuccess("Category Added successfully",response));

            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Category>("BadRequest",ex.Message));
            }
        }

        [Authorize]
        [HttpPut("{ledgerId}/category/{categoryId}")]
        public async Task<IActionResult> UpdateCategory(int ledgerId, int categoryId, ExpenseTrackerCategoryRQ category) {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                await _service.UpdateCategory(ledgerId, categoryId,category);
                return Ok(ResponseHandler.HandleSuccess("Updated Successfully",true));
            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Category>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpDelete("{ledgerId}/category/{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int ledgerId, int categoryId) {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await _service.DeleteCategory(ledgerId,categoryId);
                return Ok(ResponseHandler.HandleSuccess("Category Deleted successfully",response));
            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Category>("BadRequest", ex.Message));
            }
        }

        private async Task<bool> CheckParams()
        {
            try {
                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var ledgerId = Request.RouteValues["ledgerId"].ToString();
                var handler = new JwtSecurityTokenHandler();
                var tokens = handler.ReadJwtToken(JwtToken);
                var claims = tokens.Claims;
                var userCode = claims.FirstOrDefault(c => c.Type == "userCode")?.Value;
                return await _service.CheckUserAndLedger(userCode, Convert.ToInt32(ledgerId));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
