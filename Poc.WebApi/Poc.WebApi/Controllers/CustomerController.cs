using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Poc.WebApi.Models;

namespace Poc.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        public Customer Post(CustomerSearch model)
        {
            var cust = new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = "Adam",
                LastName = "Smith"
            };
            return cust;
        }
    }
}
