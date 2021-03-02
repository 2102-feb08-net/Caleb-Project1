﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BestEats.DataAccess
{
    public partial class Order
    {
        public Order()
        {
            Packages = new HashSet<Package>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int ProductQuantity { get; set; }
        public DateTimeOffset OrderPurchaseDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
    }
}
