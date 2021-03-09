using System;
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

        /*
        public Order(int orderId, int customerId, int storeId, int productId, string itemName, int productQuantity, DateTimeOffset orderPurchaseDate)
        {
            OrderId = orderId;
            CustomerId = customerId;
            StoreId = storeId;
            ProductId = productId;
            ItemName = itemName;
            ProductQuantity = productQuantity;
            OrderPurchaseDate = orderPurchaseDate;
        }
        */

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
