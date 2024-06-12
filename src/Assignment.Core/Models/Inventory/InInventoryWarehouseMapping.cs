using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InInventoryWarehouseMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("InventoryId")]
        [Display(Name ="AbInventory")]
        public int InventoryId { get; set; }
        [ForeignKey("WareHouseId")]
        [Display(Name = "AbWarehouse")]
        public int WareHouseId { get; set; }

   
    public InInventory InInventory { get; set; }
    public InWarehouse InWarehouse { get; set; }
    }
}
