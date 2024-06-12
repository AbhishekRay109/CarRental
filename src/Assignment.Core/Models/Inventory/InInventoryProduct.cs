using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InInventoryProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InProductID { get; set; }

        [MaxLength(30)]
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        [MaxLength(30)]
        public string Description { get; set; }

        public int Quantity { get; set; }

        [MaxLength(20)]
        public string ProductCategory { get; set; }

        public float Amount { get; set; }
        [Display(Name ="Category")]
        public virtual  int CategoryId { get; set; }
        [Display(Name ="Warehouse")]
        public virtual int WarehouseId { get; set; }

        [ForeignKey("CategoryId")]
        public InCategory InCategory { get; set; }

        [ForeignKey("WarehouseId")]
        public InWarehouse InWarehouse { get; set; }
    }
}
