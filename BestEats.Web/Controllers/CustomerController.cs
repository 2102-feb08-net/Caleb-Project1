using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestEats.DataAccess;
using BestEats.Logic;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        

        [HttpPost("api/customers/new")]
        public async Task RegisterCustomer([Required] BestEats.Logic.Customer cust) 
            => await _customerRepo.RegisterCustomerAsync(cust);
        
    } 
} 




        /*
        public void RegisterCustomer(BestEats.Customer DBcustomer)
        {
            Customer customer = new Customer
            {
                FullName = DBcustomer.FullName,
                CustPassword = DBcustomer.CustPassword
            };

            _context.Add(customer);
        }
        */
        // GET: api/<ValuesController>

        /*


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


        */



