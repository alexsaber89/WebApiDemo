using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiProject.App.Controllers;
using WebApiProject.App.Models;

namespace WebApiProject.App.DAL
{
    public class ProductRepo : IProductRepo
    {
        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}