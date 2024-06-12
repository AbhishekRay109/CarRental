using Assignment.Api.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.Inventory
{
    public interface IDBInOrderRepository
    {
        public Task<InOrderDetail> AddOrderAsync(InOrderDetail orderDetail);

        public Task<InOrderDetail> GetOrderDetailsByOrderIdAsync(int OrderDetailId);

       public  Task DeleteOrderDetailAsync(InOrderDetail orderDetail);

        public Task<InOrderDetail> UpdateOrderDetailAsync(InOrderDetail orderDetail);
    }
}
