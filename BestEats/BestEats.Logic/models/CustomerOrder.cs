using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestEats.Logic
{
    public class CustomerOrder
    {
        public string ItemName { get; set; }
        public int ItemAmount { get; set; }
        public int StoreId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        
    }
}
