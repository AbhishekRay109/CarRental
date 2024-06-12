using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Assignment.Infrastructure.Migrations;
using Assignment.Service.Model;
using Assignment.Service.Model.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.Inventory
{
    public class InventoryService
    {

        private readonly IDBInventoryRepository _inventoryRepository;
        private readonly InProductService _inProductService;

        public InventoryService(IDBInventoryRepository inventoryRepository, InProductService inprodService)
        {
            _inventoryRepository = inventoryRepository;
            _inProductService = inprodService;
        }
        public async Task<InventoryRS> AddInventoryAsync(string productCode, InventoryRQ inventoryRequest)
        {
            if (!IsAlphanumeric(productCode))
            {
                throw new ArgumentException("Product code must be alphanumeric.");
            }
            if (inventoryRequest.QuantityAvailable < 0)
            {
                throw new ArgumentException("Quantity Available must be a non-negative value.");
            }
            var products = await _inProductService.GetProductsByCodeAsync(productCode);
            var productinfo = await _inProductService.GetProductsByCodeAsync(productCode);
            var inventoryDetails = await _inventoryRepository.GetInventoryDetailsAsync(productinfo.InProductID);
            InInventory rs = new InInventory();
            rs.QuantityAvailable = inventoryRequest.QuantityAvailable;
            rs.MinStockLevel = inventoryRequest.MinStockLevel;
            rs.MaxStockLevel = inventoryRequest.MaxStockLevel;
            rs.Amount = inventoryRequest.amount;
            rs.InProductID = products.InProductID;
            rs.ProviderId = inventoryRequest.ProviderId;
            rs.WareHouseId = inventoryRequest.WareHouseId;
            await _inventoryRepository.AddInventoryAsync(rs);

            var inventoryRS = new InventoryRS
            {
                QuantityAvailable = inventoryDetails.QuantityAvailable,
                MinStockLevel = inventoryDetails.MinStockLevel,
                MaxStockLevel = inventoryDetails.MaxStockLevel,
                Amount = inventoryDetails.Amount,
                InProductId = productinfo.InProductID,
                ProviderId = inventoryRequest.ProviderId,
                WareHouseId = inventoryRequest.WareHouseId,
            };
            return inventoryRS;

        }
        private bool IsAlphanumeric(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetterOrDigit);
        }
        public async Task<InventoryRS> GetInventoryDetailsAsync(string productCode)
        {
            var productinfo = await _inProductService.GetProductsByCodeAsync(productCode);

            var inventoryDetails = await _inventoryRepository.GetInventoryDetailsAsync(productinfo.InProductID);

            if (inventoryDetails == null)
            {
                return null;
            }
            var inventoryRS = new InventoryRS
            {
                QuantityAvailable = inventoryDetails.QuantityAvailable,
                MinStockLevel = inventoryDetails.MinStockLevel,
                MaxStockLevel = inventoryDetails.MaxStockLevel,
                Amount = inventoryDetails.Amount,
                InProductId = productinfo.InProductID,
                ProviderId = inventoryDetails.ProviderId,
                WareHouseId = inventoryDetails.WareHouseId,
            };

            return inventoryRS;
        }
        public async Task UpdateInventoryAsync(string productCode, InventoryRQ updatedInventory)
        {
            var productinfo = await _inProductService.GetProductsByCodeAsync(productCode);
            var existingInventoryDetail = await _inventoryRepository.GetInventoryDetailsAsync(productinfo.InProductID);

            existingInventoryDetail.QuantityAvailable = updatedInventory.QuantityAvailable;
            existingInventoryDetail.MinStockLevel = updatedInventory.MinStockLevel;
            existingInventoryDetail.MaxStockLevel = updatedInventory.MaxStockLevel;
            existingInventoryDetail.Amount = updatedInventory.amount;
            existingInventoryDetail.ProviderId = updatedInventory.ProviderId;
            existingInventoryDetail.WareHouseId = updatedInventory.WareHouseId;

            await _inventoryRepository.UpdateInventoryAsync(productinfo.InProductID, existingInventoryDetail);
        }
        public async Task DeleteInventoryAsync(string productCode)
        {
            var productinfo = await _inProductService.GetProductsByCodeAsync(productCode);
            await _inventoryRepository.DeleteInventoryAsync(productinfo.InProductID);
        }
        public async Task UpdateQuantityAvailableAsync(string productCode, int Quantity, float Amount)
        {
            await _inventoryRepository.UpdateQuantityAvailableAsync(productCode, Quantity, Amount);
        }
        public async Task UpdateOrdQuantityAvailableAsync(string productCode, int orderedQuantity)
        {
            await _inventoryRepository.UpdateOrdQuantityAvailableAsync(productCode, orderedQuantity);
        }
        public async Task<bool> ProductExistsAsync(string productCode)
        {
            return await _inventoryRepository.ProductExistsAsync(productCode);
        }
        public async Task<byte[]> ExportAllInventoryToExcelAsync()
        {
            var inventory = await _inventoryRepository.GetAllInventoryAsync();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("AllInventory");

                // Set row height
                worksheet.Row(1).Height = 20;

                // Set column widths
                worksheet.Column(1).Width = 12; // Adjust the width as needed for each column
                worksheet.Column(2).Width = 15;
                worksheet.Column(3).Width = 15;
                worksheet.Column(4).Width = 15;
                worksheet.Column(5).Width = 15;
                worksheet.Column(6).Width = 15;
                worksheet.Column(7).Width = 15;
                worksheet.Column(8).Width = 15;

                // Add headers with bold formatting
                worksheet.Cells["A1:H1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Value = "InventoryId";
                worksheet.Cells["B1"].Value = "QuantityAvailable";
                worksheet.Cells["C1"].Value = "MinStockLevel";
                worksheet.Cells["D1"].Value = "MaxStockLevel";
                worksheet.Cells["E1"].Value = "Amount";
                worksheet.Cells["F1"].Value = "InProductID";
                worksheet.Cells["G1"].Value = "ProviderId";
                worksheet.Cells["H1"].Value = "WarehouseId";

                // Add data
                for (int i = 0; i < inventory.Count; i++)
                {
                    worksheet.Cells[$"A{i + 2}"].Value = inventory[i].InventoryId;
                    worksheet.Cells[$"B{i + 2}"].Value = inventory[i].QuantityAvailable;
                    worksheet.Cells[$"C{i + 2}"].Value = inventory[i].MinStockLevel;
                    worksheet.Cells[$"D{i + 2}"].Value = inventory[i].MaxStockLevel;
                    worksheet.Cells[$"E{i + 2}"].Value = inventory[i].Amount;
                    worksheet.Cells[$"F{i + 2}"].Value = inventory[i].InProductID;
                    worksheet.Cells[$"G{i + 2}"].Value = inventory[i].ProviderId;
                    worksheet.Cells[$"H{i + 2}"].Value = inventory[i].WareHouseId;
                }

                return package.GetAsByteArray();
            }
        }



    }

}
