using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Inventory
{
    public  class InventoryRS
    {    
        public int QuantityAvailable { get; set; }

        public int MinStockLevel { get; set; }

        public int MaxStockLevel { get; set;}

        public float Amount {  get; set; }

        public int InProductId { get; set; }

        public int ProviderId {  get; set; }

        public int WareHouseId { get; set; }
    }
}
