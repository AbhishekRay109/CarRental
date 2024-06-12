using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [MaxLength(30)]
        public string LocationName { get; set; }

        [MaxLength(30)]
        public string LocationAddress { get; set; }
        [Display(Name ="Warehouse")]
        public virtual int WarehouseId { get; set; }

        [ForeignKey("WarehouseId")]
        public InWarehouse InWarehouse { get; set; }
    }
}
