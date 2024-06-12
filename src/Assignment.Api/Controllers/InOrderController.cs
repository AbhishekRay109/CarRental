using Assignment.Service.Model.Inventory;
using Assignment.Service.Services;
using Assignment.Service.Services.Inventory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class InOrderController : BaseController
    {
        private readonly InOrderService _inOrderService;
        private readonly InventoryService _inventoryService;
        private readonly AuthService _authService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inOrderService"></param>
        /// <param name="inventoryService"></param>
        /// <param name="logger"></param>
        public InOrderController(InOrderService inOrderService,InventoryService inventoryService, AuthService authService, Serilog.Core.Logger logger) : base(logger)
        {
            _inOrderService = inOrderService;
            _inventoryService = inventoryService;
            _authService = authService;
        }
        /// <summary>
        ///  Order as per productCode
        /// </summary>
        /// <returns>
        /// 200 OK - Success.
        /// <response code="400">Bad Request - Invalid OrgCode.</response> 
        /// <response code="500"> Internal Server Error - An error occurred during data retrieval.</response>
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        /// </returns>
        [HttpPost("{productCode}")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<InOrderRS> AddOrder(string productCode, int OrderQuantity)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                bool productExists = await _inventoryService.ProductExistsAsync(productCode);

                if (!productExists)
                {
                    throw new KeyNotFoundException("productCode not found");
                }

                var rs = await _inOrderService.AddOrderAsync(productCode, OrderQuantity);

                await _inventoryService.UpdateOrdQuantityAvailableAsync(productCode, OrderQuantity);
                return rs;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Insufficient quantity available.");
            }            
        }
        /// <summary>
        ///  get order details by OrderDetailID
        /// </summary>
        /// <returns>
        /// 200 OK - Success.
        /// <response code="400">Bad Request - Invalid OrgCode.</response> 
        /// <response code="500"> Internal Server Error - An error occurred during data retrieval.</response>
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        /// </returns>
        [HttpGet("GetOrderDetailsByOrderId")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<IActionResult> GetOrderDetailsByOrderId(int OrderDetailId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                var orderDetails = await _inOrderService.GetOrderDetailsByOrderIdAsync(OrderDetailId);
                return Ok(orderDetails);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Details with OrderDetailId not found");
            }
        }
        /// <summary>
        ///  Delete Order by OrderDetailID
        /// </summary>
        /// <returns>
        /// 200 OK - Success.
        /// <response code="400">Bad Request - Invalid OrgCode.</response> 
        /// <response code="500"> Internal Server Error - An error occurred during data retrieval.</response>
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        /// </returns>
        [HttpDelete("{orderDetailId}")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<IActionResult> DeleteOrderDetail(int orderDetailId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                await _inOrderService.DeleteOrderDetailAsync(orderDetailId);
                return Ok("OrderDetail deleted successfully.");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Details with OrderDetailId not found");
            }
        }
        /// <summary>
        ///  Update Order with OrderDetailID
        /// </summary>
        /// <returns>
        /// 200 OK - Success.
        /// <response code="400">Bad Request - Invalid OrgCode.</response> 
        /// <response code="500"> Internal Server Error - An error occurred during data retrieval.</response>
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        /// </returns>
        [HttpPut("{orderDetailId}/{productCode}")]
        [CustomAuthorize("org-permissions-all")]
        public async Task<InOrderRS> UpdateOrderDetail(int orderDetailId, [FromBody] InOrderRQ updatedOrderDetail,string productCode)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                return await _inOrderService.UpdateOrderDetailAsync(orderDetailId, updatedOrderDetail,productCode);
            //    return Ok("Order detail updated successfully.");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Details with OrderDetailId not found");
            }
        }

    }
}
