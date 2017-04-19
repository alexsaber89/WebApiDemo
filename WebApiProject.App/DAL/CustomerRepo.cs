using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiProject.App.Controllers;
using WebApiProject.App.Models;

namespace WebApiProject.App.DAL
{
    public class CustomerRepo : ICustomerRepo
    {
        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}