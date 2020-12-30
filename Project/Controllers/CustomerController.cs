using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string userName , string password)
        {
            return db.Customers.AuthenticateCustomer(userName, password);
        }
        public static bool AddCustomer(dynamic customer)
        {
            Customer c = new Customer();
            c.Name = customer.Name;
            c.Id = customer.Id;
            c.Gender = customer.Gender;
            c.MobileNo = customer.MobileNo;
            c.UserName = customer.UserName;
            c.Password = customer.Password;
            return db.Customers.AddCustomer(c);
        }

        public static Customer GetCustomer(string userName)
        {
            return db.Customers.GetCustomer(userName);
        }
        public static bool UpdateCustomer(dynamic customer)
        {
            Customer c = new Customer();
            c.Name = customer.Name;
            c.Id = customer.Id;
            c.Gender = customer.Gender;
            c.MobileNo = customer.MobileNo;
            c.UserName = customer.UserName;
            c.Password = customer.Password;
            return db.Customers.UpdateCustomer(c);
        }
        public static bool DeleteCustomer(string userName)
        {
            return db.Customers.DeleteCustomer(userName);
        }
        public static ArrayList GetAllCustomer()
        {
            return db.Customers.GetAllCustomer();
        }
    }
    
}
