using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.App.Models;

namespace WebApiProject.App.Controllers
{
    public interface ICustomerRepo
    {
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomers();
        bool AddCustomer(Customer customer);
    }
}
