using ProjectService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public List<customer> GetAll()
        {
            List<customer> customers = new CustomerDAO().SelectAll();
            return customers;
        }

        [HttpGet]
        [Route("api/customers/{ID}")]
        public customer GetDetails(int ID)
        {
            customer customer = new CustomerDAO().SelectByID(ID);
            return customer;
        }

        [HttpGet]
        [Route("api/customers/search/{keyword}")]
        public List<customer> Search(String keyword)
        {
            List<customer> customers = new CustomerDAO().SelectByKeyword(keyword);
            return customers;
        }

        [HttpPost]
        [Route("api/customers")]
        public bool AddNew(customer newcustomer)
        {
            bool result = new CustomerDAO().Insert(newcustomer);
            return result;
        }

        [HttpPut]
        [Route("api/customers/{ID}")]
        public bool Update(customer newcustomer)
        {
            bool result = new CustomerDAO().Update(newcustomer);
            return result;
        }

        [HttpDelete]
        [Route("api/customers/{ID}")]
        public bool Delete(int ID)
        {
            bool result = new CustomerDAO().Delete(ID);
            return result;
        }
    }
}