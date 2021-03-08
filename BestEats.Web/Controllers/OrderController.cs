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
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly BaseRepo _orderRepo;


        public OrderController(BaseRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }



        /*
        [HttpPost("api/register/new")]
        public async Task RegisterCustomer([Required] BestEats.Logic.Customer cust)
            => await _customerRepo.RegisterCustomerAsync(cust);
        */




    }
}
