using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Inventory
{
    public class InOrderRS
    {
        public int InProductID {  get; set; }
        public int OrderDetailId { get; set; }
        public int OrderQuantity { get; set; }

        public DateTime ExpectedDate { get; set; }

        public float Amount { get; set; }

        public virtual int ProviderId { get; set; }       

        public virtual int CategoryId { get; set; }
    }
}
