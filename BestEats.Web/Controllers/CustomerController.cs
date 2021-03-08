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
        protected string currentCustomer;

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

            /*if (_customerRepo.CheckCustomerPasswordExists(fullName, custPassword))
            {
                currentCustomer = fullName;
                return true;
            }
            else
            {
                return false;
            }
            */

        }

        /*
        [HttpPost("login/${fullName}{custPassword}")]
        public void LoginCustomer()
        {
             _customerRepo.C
        }
        */
    }

}
/*
public bool checkCustomerPasswordExists(string userName, string passwordInput)
{
    bool exists = false;
    var inputCust = _context.Customers
        .Where(u => u.FullName == userName && u.CustPassword == passwordInput).ToList();


    foreach (var c in inputCust)
    {
        exists = true;
    }
    return exists;
}

public bool checkCustomerNameExists(string loginInput)
{
    bool exists = false;
    var inputCust = _context.Customers
        .Where(c => string.Equals(c.FullName, loginInput)).ToList();

    foreach(var c in inputCust)
    {
        exists = true;
    }
    return exists;
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



