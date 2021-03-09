using System;
using Xunit;
using BestEats.Logic;
using BestEats.DataAccess;


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
            BestEats.Logic.Order ordertest = new BestEats.Logic.Order(OrderIdtest, CustomerIdTest, StoreIdTest, ProductIdTest, ItemNameTest, ProductQuantityTest, OrderPurchaseDateTest);
            

        }


    }
}
