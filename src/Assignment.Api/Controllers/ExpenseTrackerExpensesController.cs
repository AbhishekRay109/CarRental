using Assignment.Service.Model.ExpenseModel;
using Assignment.Service.Services.ExpenseService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using Quartz.Impl;
using Quartz;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("api/category/{categoryId}")]
    [ApiController]
    public class ExpenseTrackerExpensesController : BaseController
    {
        private readonly ExpenseTrackerExpensesService service;
        public ExpenseTrackerExpensesController(ExpenseTrackerExpensesService service,Serilog.Core.Logger logger) : base(logger)
        {
            this.service = service;
        }

        [Authorize]
        [HttpGet("expenses")]
        public async Task<IActionResult> GetAllExpenses(int categoryId) {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await service.GetAllExpenses(categoryId);
                return Ok(ResponseHandler.HandleSuccess("Expenses under this category fetched successfully", response));
            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Expense>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpGet("expenses/{expenseId}")]
        public async Task<IActionResult> GetExpenseById(int categoryId,int expenseId)
        {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await service.GetExpenseById(categoryId,expenseId);
                return Ok(ResponseHandler.HandleSuccess("Expense fetched successfully",response));
            }catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Expense>("BadRequest",ex.Message));
            }
        }

        [Authorize]
        [HttpPost("expense")]
        public async Task<IActionResult> AddExpense(int categoryId,[FromForm]ExpenseTrackerExpenseRQ expense) {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await service.AddExpense(categoryId, expense);
                return Ok(ResponseHandler.HandleSuccess("Expense Added successfully",response));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Expense>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpGet("expenses/{expenseId}/viewReceipt")]
        public async Task<IActionResult> ViewReceipt(int categoryId, int expenseId)
        {
            try {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await service.ViewReceipt(categoryId,expenseId);
                if (response == null) {
                    throw new ArgumentException("No receipt Found");
                }
                byte[] Picture = Convert.FromBase64String(response);
                return File(Picture, "image/png");
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Expense>("could not fetch receipt", ex.Message));
            }
        }

        [Authorize]
        [HttpPost("expense/{expenseId}/addReceipt")]
        public async Task<IActionResult> AddReceiptForExpense(int categoryId, int expenseId, IFormFile file)
        {
            try
            {
                if (!await CheckParams())
                {
                    return Unauthorized();
                }
                var response = await service.AddReceipt(categoryId, expenseId,file);
                return Ok(ResponseHandler.HandleSuccess("Added receipt successfully",response));
            }
            catch (Exception ex) {
                return Ok(ResponseHandler.HandleError<Expense>("BadRequest", ex.Message));
            }
        }

        private async Task<bool> CheckParams()
        {
            try {
                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var categoryId = Request.RouteValues["categoryId"].ToString();
                var handler = new JwtSecurityTokenHandler();
                var tokens = handler.ReadJwtToken(JwtToken);
                var claims = tokens.Claims;
                var userCode = claims.FirstOrDefault(c => c.Type == "userCode")?.Value;
                return await service.CheckUserAndCategory(userCode, Convert.ToInt32(categoryId));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
