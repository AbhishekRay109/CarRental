using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Assignment.Infrastructure.Repository.Inventory;
using Assignment.Service.Model.Inventory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Service.Services.Inventory
{
    public class InProductService
    {
        private readonly IDBInProductRepository _inProductRepository;
        private readonly IDBInventoryRepository _inventoryRepository;

        public InProductService(IDBInProductRepository inProductRepository, IDBInventoryRepository inventoryRepository)
        {
            _inProductRepository = inProductRepository;
            _inventoryRepository = inventoryRepository;

        }
        public async Task<InventoryProductRS> AddProductAsync(InventoryProductRQ productRequest)
        {
            if (!IsAlphanumeric(productRequest.ProductCode) || !IsAlphanumeric(productRequest.ProductName))
            {
                throw new ArgumentException("Product code and product name must be alphanumeric.");
            }


            InInventoryProduct rs = new InInventoryProduct();
            rs.ProductCode = productRequest.ProductCode;
            rs.ProductName = productRequest.ProductName;
            rs.Amount = productRequest.Amount;
            rs.Description = productRequest.Description;
            rs.ProductCategory = productRequest.ProductCategory;
            rs.CategoryId = productRequest.CategoryId;
            rs.WarehouseId = productRequest.WarehouseId;
            rs.Quantity = productRequest.Quantity;
            await _inProductRepository.AddProductAsync(rs);
            var InventoryProductRS = new InventoryProductRS
            {
                ProductCode = productRequest.ProductCode,
                ProductName = productRequest.ProductName,
                Amount = productRequest.Amount,
                Description = productRequest.Description,
                ProductCategory = productRequest.ProductCategory,
                CategoryId = productRequest.CategoryId,
                WarehouseId = productRequest.WarehouseId,
                Quantity = productRequest.Quantity,
            };
            return InventoryProductRS;

        }
        private bool IsAlphanumeric(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetterOrDigit);
        }

        public async Task<InInventoryProduct> GetProductsByCodeAsync(string productCode)
        {
            return await _inProductRepository.GetProductsByCodeAsync(productCode);
        }
        public async Task UpdateProductAsync(string productCode, InventoryProductUpdateRQ updatedProduct)
        {
            var existingProduct = await _inProductRepository.GetProductsByCodeAsync(productCode);

            existingProduct.ProductName = updatedProduct.ProductName;
            existingProduct.Amount = updatedProduct.Amount;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.ProductCategory = updatedProduct.ProductCategory;
            existingProduct.CategoryId = updatedProduct.CategoryId;
            existingProduct.WarehouseId = updatedProduct.WarehouseId;
            existingProduct.Quantity = updatedProduct.Quantity;

            await _inProductRepository.UpdateProductAsync(existingProduct);
        }
        public async Task DeleteProductAsync(string productCode)
        {

            var existingProduct = await _inProductRepository.GetProductsByCodeAsync(productCode);

            if (existingProduct == null)
            {
                throw new ArgumentException($"Product with code {productCode} not found.");
            }

            await _inProductRepository.DeleteProductAsync(existingProduct);
        }



    }
}
