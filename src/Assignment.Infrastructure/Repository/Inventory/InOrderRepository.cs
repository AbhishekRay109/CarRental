using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Infrastructure.Repository.Inventory.InOrderRepository;

namespace Assignment.Infrastructure.Repository.Inventory
{
    public class InOrderRepository:IDBInOrderRepository
    {

        private readonly RaidenDBContext _dBContext;
        public InOrderRepository(RaidenDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<InOrderDetail> AddOrderAsync(InOrderDetail orderDetail)
        {
                _dBContext.InOrderDetails.Add(orderDetail);
                await _dBContext.SaveChangesAsync();
            return orderDetail;
            
        }
        public async Task<InOrderDetail> GetOrderDetailsByOrderIdAsync(int OrderDetailId)
        {
            return await _dBContext.InOrderDetails
                .Include(od => od.InInventoryProduct)
                .Include(od => od.InCategory)
                .Include(od => od.InProvider)
                .FirstOrDefaultAsync(od => od.OrderDetailId == OrderDetailId);
        }
        public async Task DeleteOrderDetailAsync(InOrderDetail orderDetail)
        {
            _dBContext.InOrderDetails.Remove(orderDetail);
            await _dBContext.SaveChangesAsync();
        }
        public async Task<InOrderDetail> UpdateOrderDetailAsync(InOrderDetail orderDetail)
        {
            _dBContext.InOrderDetails.Update(orderDetail);
            await _dBContext.SaveChangesAsync();
            return orderDetail;
        }


    }
}
