using Assignment.Api.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.Inventory
{
    public interface IDBInProductRepository
    {
       public  Task AddProductAsync(InInventoryProduct product);
        public Task<InInventoryProduct> GetProductsByCodeAsync(string productCode);

        public Task UpdateProductAsync(InInventoryProduct product);

        public Task DeleteProductAsync(InInventoryProduct product);



    }
}