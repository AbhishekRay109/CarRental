using Assignment.Api.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.Inventory
{
    public interface IDBInventoryRepository
    {
        public Task AddInventoryAsync(InInventory inventory);
       public  Task<InInventory> GetInventoryDetailsAsync(int inProductId);

        public Task UpdateInventoryAsync(int inProductId, InInventory updatedInventory);

        public Task DeleteInventoryAsync(int inProductId);

        public Task UpdateQuantityAvailableAsync(string productCode, int Quantity,float Amount);

        public Task<bool> ProductExistsAsync(string productCode);

        public Task UpdateOrdQuantityAvailableAsync(string productCode, int orderedQuantity);

        public Task<List<InInventory>> GetAllInventoryAsync();
    }
}
