using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InUserInventoryMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual int UserId { get; set; }

        public virtual int InventoryId { get; set; }

        [ForeignKey("UserId")]
        [Display(Name="User")]
        public Users Users { get; set; }

        [ForeignKey("InventoryId")]
        [Display(Name ="Inventory")]
        public InInventory InInventory { get; set; }
    }
}
