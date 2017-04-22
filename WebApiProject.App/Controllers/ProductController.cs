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

        [HttpGet]
        [Route("api/product")]
        public HttpResponseMessage HttpGetAllProducts()
        {
            var products = _productRepo.GetAllProducts();

            if (products == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There are no customers present.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        [HttpPost]
        [Route("api/product/addProduct")]
        public HttpResponseMessage HttpAddProduct(Product product)
        {
            bool addedProduct = _productRepo.AddProduct(product);

            if (!addedProduct)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There was a problem adding the product.  Please try again.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, addedProduct);
        }
    }
}
