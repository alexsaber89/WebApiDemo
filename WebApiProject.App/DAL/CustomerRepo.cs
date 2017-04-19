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
            if (customer == null) return false;
            return true;
        }

        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>{};
        }

        public Customer GetCustomerById(int id)
        {
            if (id == 0) return null;

            return new Customer
            {
                Name = "John Doe",
                Email = "john.doe@gmail.com",
                Phone = "(954) 336-7919"
            };
        }
    }
}