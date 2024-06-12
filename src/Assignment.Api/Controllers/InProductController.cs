using Assignment.Api.Models.Inventory;
using Assignment.Service.Model.Inventory;
using Assignment.Service.Services;
using Assignment.Service.Services.Inventory;
using iText.Forms.Fields.Merging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InProductController : BaseController
    {
        private readonly InProductService _inProductService;
        private readonly AuthService _authService;
        private readonly InventoryService _inventoryService;

        public InProductController(InProductService inProductService, AuthService authService, InventoryService inventoryService, Serilog.Core.Logger logger) : base(logger)
        {
            _inProductService = inProductService;
            _authService = authService;
            _inventoryService = inventoryService;
        }
      
        [HttpPost]
        [CustomAuthorize("org-permissions-all")]
        public async Task<InventoryProductRS> AddProduct([FromBody] InventoryProductRQ productRequest)
        {
            InventoryProductRS rs = null;
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string productCode = productRequest.ProductCode;
            bool productExists = await _inventoryService.ProductExistsAsync(productCode);
            if (productExists)
            {
                await _inventoryService.UpdateQuantityAvailableAsync(productCode, productRequest.Quantity, productRequest.Amount);
            }
            else
            {
                rs = await _inProductService.AddProductAsync(productRequest);
            }
            return rs;
        }
        [HttpGet("{productCode}")]
        [CustomAuthorize("org-permissions-all")]
        
        public async Task<IActionResult> GetProductsByCode(string productCode)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;

                var products = await _inProductService.GetProductsByCodeAsync(productCode);

                if (products != null)
                {
                    return Ok(products);
                }
                else
                {
                    return NotFound($"Products with code '{productCode}' not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("{productCode}")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<IActionResult> UpdateProduct(string productCode, [FromBody] InventoryProductUpdateRQ updatedProduct)
        {

            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                await _inProductService.UpdateProductAsync(productCode, updatedProduct);

                return Ok("Product updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{productCode}")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<IActionResult> DeleteProduct(string productCode)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;

                await _inProductService.DeleteProductAsync(productCode);

                return Ok("Product deleted successfully.");
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
