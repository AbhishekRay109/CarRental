using Assignment.Service.Model.ExpenseModel;
using Assignment.Service.Services.ExpenseService;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Reflection.Emit;

namespace Assignment.Api.Controllers
{
    [Route("user")]
    [ApiController]
    public class ExpenseTrackerLedgerController : ControllerBase
    {
        private readonly ExpenseTrackerLedgerService ledgerService;
        public ExpenseTrackerLedgerController(ExpenseTrackerLedgerService service)
        {
            ledgerService = service;
        }

        [Authorize]
        [HttpGet("{userCode}/ledger")]
        public async Task<IActionResult> GetLedgerByUserCode(string userCode)
        {
            try
            {
                if (!CheckParams())
                {
                    return Unauthorized();
                }
                var response = await ledgerService.GetLedgerByUserCode(userCode);
                return Ok(ResponseHandler.HandleSuccess($"Successfully fetched budgetLedgers for {userCode}", response));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.HandleError<BudgetLedger>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpPost("{userCode}/ledger")]
        public async Task<IActionResult> AddLedgerByUserCode(string userCode, ExpenseTrackerAddLedgerRQ ledgerRQ)
        {
            try
            {
                if (!CheckParams())
                {
                    return Unauthorized();
                }
                var ledger = await ledgerService.AddLedgerByUserCode(userCode, ledgerRQ.Name,ledgerRQ.Amount,ledgerRQ.Type);
                return Ok(ResponseHandler.HandleSuccess("New Ledger added!", ledger));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<BudgetLedger>("Error while adding new ledger!", ex.Message));
            }
        }

        [Authorize]
        [HttpPut("{userCode}/ledger/{ledgerId}")]
        public async Task<IActionResult> UpdateLedger(string userCode, string name, decimal amount, int ledgerId)
        {
            try
            {
                if (!CheckParams())
                {
                    return Unauthorized();
                }
                var updatedLedger = await ledgerService.UpdateLedger(userCode, name, amount, ledgerId);
                return Ok(ResponseHandler.HandleSuccess("BudgetLedger updated successfully", updatedLedger));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<BudgetLedger>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpDelete("{userCode}/ledger/{ledgerId}")]
        public async Task<IActionResult> DeleteLedger(string userCode, int ledgerId)
        {
            try
            {
                if (!CheckParams())
                {
                    return Unauthorized();
                }
                await ledgerService.DeleteLedger(userCode, ledgerId);
                return Ok(ResponseHandler.HandleSuccess<BudgetLedger>("BudgetLedger deleted successfully!"));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<BudgetLedger>("BadRequest", ex.Message));
            }
        }

        [Authorize]
        [HttpGet("{userCode}/ledger/{ledgerId}/export")]
        public async Task<IActionResult> ExportPDFFile(string userCode, int ledgerId)
        {
            try
            {
                if (!CheckParams())
                {
                    return Unauthorized();
                }
                var response = await ledgerService.ExportFile(userCode, ledgerId);
                return File(response, "application/pdf", "ExpenseTrackerReport.pdf");
            }
            catch (Exception ex) {
                return Ok(ResponseHandler.HandleError<BudgetLedger>("Could not export file",ex.Message));
            }
        }

        private bool CheckParams()
        {
            try
            {
                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var userCode = Request.RouteValues["userCode"].ToString().ToUpper();
                var handler = new JwtSecurityTokenHandler();
                var tokens = handler.ReadJwtToken(JwtToken);
                var claims = tokens.Claims;
                var userCodeToken = (claims.FirstOrDefault(c => c.Type == "userCode")?.Value).ToUpper();
                if (userCodeToken.Equals(userCode))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
