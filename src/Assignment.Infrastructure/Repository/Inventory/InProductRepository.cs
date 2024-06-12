using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.Inventory
{
    public class InProductRepository :IDBInProductRepository
    {
        private readonly RaidenDBContext _dBContext;
        public InProductRepository(RaidenDBContext dBContext)
        {
          _dBContext = dBContext;
        }

        public async Task AddProductAsync(InInventoryProduct productRequest)
        {
            var productEntity = new InInventoryProduct
            {
                // Map properties from productRequest to productEntity
                ProductCode = productRequest.ProductCode,
                ProductName = productRequest.ProductName,
                Quantity = productRequest.Quantity,
                Amount = productRequest.Amount, 
                Description = productRequest.Description,
                ProductCategory = productRequest.ProductCategory,
                CategoryId = productRequest.CategoryId,
                WarehouseId = productRequest.WarehouseId,
                
                // Set other properties
            };

            _dBContext.InInventoryProducts.Add(productEntity);

            await _dBContext.SaveChangesAsync();
        }
        public async Task<InInventoryProduct> GetProductsByCodeAsync(string productCode)
        {
            return await _dBContext.InInventoryProducts
                .FirstOrDefaultAsync(p => p.ProductCode == productCode);
        }
       
        public async Task UpdateProductAsync(InInventoryProduct product)
        {
            _dBContext.InInventoryProducts.Update(product);
            await _dBContext.SaveChangesAsync();
        }
        public async Task DeleteProductAsync(InInventoryProduct product)
        {
            
            _dBContext.InInventoryProducts.Remove(product);
            await _dBContext.SaveChangesAsync();
        }
    }

}
