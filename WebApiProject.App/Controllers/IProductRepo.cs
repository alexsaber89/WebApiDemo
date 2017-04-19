using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.App.Models;

namespace WebApiProject.App.Controllers
{
    public interface IProductRepo
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        bool AddProduct(Product product);
    }
}
