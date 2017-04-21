using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.App.DAL;

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
    }
}
