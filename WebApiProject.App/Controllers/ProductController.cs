using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.App.DAL;

namespace WebApiProject.App.Controllers
{
    public class ProductController : ApiController
    {
        readonly IProductRepo _productRepo;

        public ProductController()
        {
            _productRepo = new ProductRepo();
        }

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        [Route("api/product/{id}")]
        public HttpResponseMessage HttpGetProductById(int id)
        {
            var product = _productRepo.GetProductById(id);

            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Product with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, product);
        }
    }
}
