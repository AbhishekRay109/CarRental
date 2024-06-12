using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }

        public int QuantityAvailable { get; set; }

        public int MinStockLevel { get; set; }

        public int MaxStockLevel { get; set; }

        public float Amount { get; set; }

        [Display(Name ="InventoryProduct")]
        public virtual int InProductID { get; set; }

        [Display(Name ="Provider")]
        public virtual  int ProviderId { get; set; }

        [Display(Name ="Warehouse")]
            
        public  virtual int WareHouseId { get; set; }

        [ForeignKey("InProductID")]
        public InInventoryProduct InInventoryProduct { get; set; }

        [ForeignKey("ProviderId")]
        public InProvider InProvider { get; set; }

        [ForeignKey("WareHouseId")]
        public InWarehouse InWarehouse { get; set; }
    }
}
