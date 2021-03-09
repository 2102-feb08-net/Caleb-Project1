using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestEats.DataAccess;
using BestEats.Logic;
using System.ComponentModel.DataAnnotations;



namespace BestEats.Web.Controllers
{


    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly BaseRepo _orderRepo;


        public OrderController(BaseRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }


        [HttpPost("api/order/new")]
        public void AddNewOrder(BestEats.Logic.Order order)
        {                             
           _orderRepo.AddOrder(order);
        }

        [HttpGet("api/profile/new/{customerId}")]
        public List<BestEats.DataAccess.Order> showAllCustomerOrders(int customerId)
        {
            return _orderRepo.GetOrdersByCustID(customerId);
        }

        /*
        [HttpPost("api/register/new")]
        public async Task RegisterCustomer([Required] BestEats.Logic.Customer cust)
            => await _customerRepo.RegisterCustomerAsync(cust);
        

        public string GetItemNameByProductID(int productID)
        {

            var itemName = _context.Products
                .Where(n => n.ProductId == productID)
                .AsEnumerable()
                .First().ProductName;


            return itemName;
        }
        */

    }
}
