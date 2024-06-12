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
    public class InventoryRepository:IDBInventoryRepository
    {
        private readonly RaidenDBContext _dBContext;

        public InventoryRepository(RaidenDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task AddInventoryAsync(InInventory inventoryRequest)
        {
            // Map properties from inventoryRequest to create an AbInventory entity
            var inventoryEntity = new InInventory
            {
                QuantityAvailable = inventoryRequest.QuantityAvailable,
                MinStockLevel = inventoryRequest.MinStockLevel,
                MaxStockLevel = inventoryRequest.MaxStockLevel,
                Amount = inventoryRequest.Amount,
                InProductID = inventoryRequest.InProductID,
                ProviderId = inventoryRequest.ProviderId,
                WareHouseId = inventoryRequest.WareHouseId
                // Map other properties
            };

            await _dBContext.InInventory.AddAsync(inventoryEntity);
            await _dBContext.SaveChangesAsync();
        }
        public async Task<InInventory> GetInventoryDetailsAsync(int inProductId)
        {
            return await _dBContext.InInventory
                .Where(i => i.InProductID == inProductId)
                .Select(i => new InInventory
                {                   
                    QuantityAvailable = i.QuantityAvailable,
                    MinStockLevel = i.MinStockLevel,
                    MaxStockLevel = i.MaxStockLevel,
                    Amount = i.Amount,
                    InProductID = i.InProductID,
                    ProviderId = i.ProviderId,
                    WareHouseId = i.WareHouseId                   

                    
                })
                .FirstOrDefaultAsync();
        }
        public async Task UpdateInventoryAsync(int inProductId, InInventory updatedInventory)
        {
            var existingInventoryDetail = await _dBContext.InInventory
                .FirstOrDefaultAsync(i => i.InProductID == inProductId);

            if (existingInventoryDetail == null)
            {
                // Handle the case where the inventory with the given inProductId is not found
                return;
            }

            // Update properties based on the updatedInventory
            existingInventoryDetail.QuantityAvailable = updatedInventory.QuantityAvailable;
            existingInventoryDetail.MinStockLevel = updatedInventory.MinStockLevel;
            existingInventoryDetail.MaxStockLevel = updatedInventory.MaxStockLevel;
            existingInventoryDetail.Amount = updatedInventory.Amount;
            existingInventoryDetail.InProductID = updatedInventory.InProductID;
            existingInventoryDetail.ProviderId = updatedInventory.ProviderId;
            existingInventoryDetail.WareHouseId = updatedInventory.WareHouseId;
            _dBContext.Update(existingInventoryDetail);
            await _dBContext.SaveChangesAsync();
        }
        public async Task DeleteInventoryAsync(int inProductId)
        {
            var inventoryToDelete = await _dBContext.InInventory
                .FirstOrDefaultAsync(i => i.InProductID == inProductId);

            if (inventoryToDelete != null)
            {
                _dBContext.InInventory.Remove(inventoryToDelete);
                await _dBContext.SaveChangesAsync();
            }
        }
        public async Task UpdateQuantityAvailableAsync(string productCode, int Quantity,float Amount)
        {
            var inventory = await _dBContext.InInventory
                .Include(i => i.InInventoryProduct)
                .FirstOrDefaultAsync(i => i.InInventoryProduct.ProductCode == productCode);

            if (inventory != null)
            {
                inventory.QuantityAvailable += Quantity;   
                inventory.Amount += Amount;
                _dBContext.Update(inventory);               
                await _dBContext.SaveChangesAsync();
            }
        }
        public async Task UpdateOrdQuantityAvailableAsync(string productCode, int orderedQuantity)
        {
            var inventory = await _dBContext.InInventory
                .Include(i => i.InInventoryProduct)
                .FirstOrDefaultAsync(i => i.InInventoryProduct.ProductCode == productCode);

            if (inventory != null)
            {
                
                if (inventory.QuantityAvailable < orderedQuantity)
                {
                    throw new InvalidOperationException("Insufficient quantity available.");
                }

              
                inventory.QuantityAvailable -= orderedQuantity;

                _dBContext.Update(inventory);

                
                await _dBContext.SaveChangesAsync();
            }
        }

        public async Task<bool> ProductExistsAsync(string productCode)
        {
            return await _dBContext.InInventory
                .AnyAsync(i => i.InInventoryProduct.ProductCode == productCode);
        }
        public async Task<List<InInventory>> GetAllInventoryAsync()
        {
            return await _dBContext.InInventory.ToListAsync();
        }

    }
}
