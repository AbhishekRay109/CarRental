using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Models.Inventory
{
    public class InOrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }

        public int OrderQuantity { get; set; }

        public DateTime ExpectedDate { get; set; }

        public float Amount { get; set; }

        public virtual int OrderId { get; set; }

        public virtual int ProviderId { get; set; }
        public virtual  int InProductID { get; set; }

        public virtual int CategoryId { get; set; }
      

        [ForeignKey("InProductID")]
        [Display(Name ="InventoryProduct")]
        public InInventoryProduct InInventoryProduct { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name ="Category")]
        public InCategory InCategory { get; set; }

        [ForeignKey("ProviderId")]
        [Display(Name = "InProvider")]
        public InProvider InProvider { get; set; }
    }
}
