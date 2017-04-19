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
            if (product == null) return false;
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product> {};
        }

        public Product GetProductById(int id)
        {
            if (id == 0) return null;

            return new Product
            {
                Name = "Toilet Paper",
                Price = 2.99,
                StockRemaining = 2
            };
        }
    }
}