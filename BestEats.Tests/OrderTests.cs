using System;
using Xunit;


namespace BestEats.Tests
{
    public class OrderTests
    {


        DateTimeOffset date1 = DateTimeOffset.UtcNow;
        [Theory]
        [InlineData(1, 2, 3, 2, "Apple", 5, "2018-12-30")]
        [InlineData(2, 3, 2, 3, "Orange", 10, "2020-10-5")]
        public void validateAddOrderInputsSucceed(int OrderIdtest, int CustomerIdTest, int StoreIdTest, int ProductIdTest, string ItemNameTest, int ProductQuantityTest, DateTimeOffset OrderPurchaseDateTest)
        {
            Order ordertest = new Order
            {
                OrderId = OrderIdtest,
                CustomerId = CustomerIdTest,
                StoreId = StoreIdTest,
                ProductId = ProductIdTest,
                ItemName = ItemNameTest,
                ProductQuantity = ProductQuantityTest,
                OrderPurchaseDate = OrderPurchaseDateTest,
            };
        }


    }
}
