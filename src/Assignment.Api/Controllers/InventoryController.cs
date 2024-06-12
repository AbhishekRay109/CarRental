using Assignment.Service.Model.Inventory;
using Assignment.Service.Services.Inventory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Assignment.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventoryController : BaseController
    {

        private readonly InventoryService _inventoryService;

        public InventoryController(InventoryService inventoryService, Serilog.Core.Logger logger) : base(logger)
        {
            _inventoryService = inventoryService;
        }

        [HttpPost("{productCode}")]
       
        public async Task<InventoryRS> CreateInventory([FromRoute] string productCode, [FromBody] InventoryRQ inventoryRequest)
        {
            InventoryRS rs = null;
            try
                
            {
                rs = await _inventoryService.AddInventoryAsync(productCode, inventoryRequest);
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong");
            }
            return rs;
        }
        [HttpGet("{productCode}")]
        public async Task<IActionResult> GetInventoryDetails(string productCode)
        {
            try
            {
                var inventoryDetails = await _inventoryService.GetInventoryDetailsAsync(productCode);

                if (inventoryDetails == null)
                {
                    return NotFound($"Inventory details for InProductId {productCode} not found.");
                }

                return Ok(inventoryDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("{productCode}")]
        public async Task<IActionResult> UpdateInventory(string productCode, [FromBody] InventoryRQ updatedInventory)
        {

            try
            {
                await _inventoryService.UpdateInventoryAsync(productCode, updatedInventory);
                return Ok("Inventory updated successfully.");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{productCode}")]

        public async Task<IActionResult> DeleteInventory(string productCode)
        {
            await _inventoryService.DeleteInventoryAsync(productCode);
            return Ok("Inventory deleted successfully.");
        }
        [HttpGet("export")]
        public async Task<IActionResult> ExportAllInventoryToExcel()
        {
            try
            {
                var excelData = await _inventoryService.ExportAllInventoryToExcelAsync();

                return File(excelData, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AllInventory.xlsx");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }


}
