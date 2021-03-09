using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
    public class CustomerController : ControllerBase
    {


        private readonly BaseRepo _customerRepo;


        public CustomerController(BaseRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }


        [HttpPost("api/register/new")]
        public async Task RegisterCustomer([Required] BestEats.Logic.Customer cust)
            => await _customerRepo.RegisterCustomerAsync(cust);


        [HttpGet("api/login/{fullName}/{custPassword}")]
        public bool LoginCustomer([Required] string fullName, string custPassword)
        {

            return _customerRepo.CheckCustomerPasswordExists(fullName, custPassword);

        }


        [HttpGet("api/customer/{fullName}")]
        public int getCustIDfromName([Required] string fullName)
        {

            return _customerRepo.GetCustomerIDByName(fullName);

        }

    }
}

        



