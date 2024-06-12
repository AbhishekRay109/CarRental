using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models;
using Assignment.Api.Models.Inventory;
using Assignment.Infrastructure.Migrations;
using Assignment.Infrastructure.Repository.Inventory;
using Assignment.Service.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.Inventory
{
    public class InOrderService
    {
        private readonly IDBInOrderRepository _inorderRepository;
        private readonly IDBInProductRepository _inProductRepository;
        private readonly IDBInventoryRepository  _inventoryRepository;

        public InOrderService(IDBInOrderRepository inorderRepository, IDBInProductRepository inProductRepository, IDBInventoryRepository inventoryRepository)
        {
            _inorderRepository = inorderRepository;
            _inProductRepository = inProductRepository;
            _inventoryRepository = inventoryRepository;
        }

        public async Task<InOrderRS> AddOrderAsync(string productCode, int OrderQuantity)
        {            
            var product = await _inProductRepository.GetProductsByCodeAsync(productCode);
            var productinfo = await _inProductRepository.GetProductsByCodeAsync(productCode);
            var inventory = await _inventoryRepository.GetInventoryDetailsAsync(product.InProductID);

            if (product == null)        
            {
               
                throw new InvalidOperationException("Product not found.");
            }                
            DateTime expectedDate = DateTime.Now.AddDays(3);
            var orderDetail = new InOrderDetail
            {
                OrderQuantity = OrderQuantity,                        
                InProductID = product.InProductID,                
                ExpectedDate = expectedDate,                          
                Amount = productinfo.Amount,
                ProviderId = inventory.ProviderId,
                CategoryId = productinfo.CategoryId,
            };            
            var orderInfo = await _inorderRepository.AddOrderAsync(orderDetail);

            int totalAmount = OrderQuantity * (int)(float)inventory.Amount;
            var InOrderRS = new InOrderRS
            {
                InProductID = orderDetail.InProductID,
                OrderDetailId = orderInfo.OrderDetailId,
                OrderQuantity = orderDetail.OrderQuantity,
                ExpectedDate = expectedDate,
                Amount = totalAmount,
                ProviderId = orderInfo.ProviderId,
                CategoryId = orderInfo.CategoryId
            };
            return InOrderRS;
        }
        public async Task<InOrderRS> GetOrderDetailsByOrderIdAsync(int OrderDetailId)
        {

            var orderDetail = await _inorderRepository.GetOrderDetailsByOrderIdAsync(OrderDetailId);
            if (orderDetail == null)
            {
                throw new ($"OrderDetailId with ID {OrderDetailId} not found.");
            }

            var orderDetailsRS = new InOrderRS
            {
                // Map properties based on your requirements
                OrderDetailId = orderDetail.OrderDetailId,
                OrderQuantity = orderDetail.OrderQuantity,
                ExpectedDate = orderDetail.ExpectedDate,
                Amount = orderDetail.Amount,              
                ProviderId = orderDetail.ProviderId,
                InProductID = orderDetail.InProductID,
                CategoryId = orderDetail.CategoryId,
                // Map other properties
            };

            return orderDetailsRS;
        }
        public async Task DeleteOrderDetailAsync(int orderDetailId)
        {
            var existingOrderDetail = await _inorderRepository.GetOrderDetailsByOrderIdAsync(orderDetailId);

            if (existingOrderDetail != null)
            {
                await _inorderRepository.DeleteOrderDetailAsync(existingOrderDetail);
            }
        
        }
        public async Task<InOrderRS> UpdateOrderDetailAsync(int orderDetailId, InOrderRQ updatedOrderDetail,string productCode)
        {
            var existingOrderDetail = await _inorderRepository.GetOrderDetailsByOrderIdAsync(orderDetailId);

            if (existingOrderDetail == null)
            {
                throw new ArgumentException("Order detail does not exist.");
            }            
            existingOrderDetail.OrderQuantity = updatedOrderDetail.OrderQuantity;
            var product = await _inProductRepository.GetProductsByCodeAsync(productCode);
            var inventory = await _inventoryRepository.GetInventoryDetailsAsync(product.InProductID);

            int totalAmount = updatedOrderDetail.OrderQuantity * (int)(float)inventory.Amount;
            DateTime expectedDate = DateTime.Now.AddDays(3);
            var updatedOrderRS = new InOrderRS
            {
                InProductID = existingOrderDetail.InProductID,
                OrderDetailId = existingOrderDetail.OrderDetailId,
                OrderQuantity = existingOrderDetail.OrderQuantity,
                ExpectedDate = expectedDate,
                Amount = totalAmount,
                ProviderId = existingOrderDetail.ProviderId,
                CategoryId = existingOrderDetail.CategoryId
            };

            return updatedOrderRS;
        }

    }
}
