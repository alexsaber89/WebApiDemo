using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.App.DAL;
using WebApiProject.App.Models;

namespace WebApiProject.App.Controllers
{
    public class CustomerController : ApiController
    {
        readonly ICustomerRepo _customerRepo;

        public CustomerController()
        {
            _customerRepo = new CustomerRepo();
        }

        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        [Route("api/customer/{id}")]
        public HttpResponseMessage HttpGetCustomerById(int id)
        {
            var customer = _customerRepo.GetCustomerById(id);

            if (customer == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Customer with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        [HttpGet]
        [Route("api/customer")]
        public HttpResponseMessage HttpGetAllCustomers()
        {
            var customers = _customerRepo.GetAllCustomers();

            if (customers == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There are no customers present.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, customers);
        }

        [HttpPost]
        [Route("api/product/addCustomer")]
        public HttpResponseMessage HttpAddProduct(Customer customer)
        {
            bool addedCustomer = _customerRepo.AddCustomer(customer);

            if (!addedCustomer)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There was a problem adding the customer.  Please try again.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, addedCustomer);
        }
    }
}
