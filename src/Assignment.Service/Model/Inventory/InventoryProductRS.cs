using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Inventory
{
    public class InventoryProductRS
    {
        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public float Amount { get; set; }

        public string Description { get; set; }

        public string ProductCategory { get; set; }

        public int CategoryId { get; set; }
        public int WarehouseId { get; set; }
    }
}