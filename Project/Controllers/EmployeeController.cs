using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public static class EmployeeController
    {
         static Database db = new Database();
        public static Employee AuthenticEmployee(string userName, string password)
        {
            return db.Employees.AuthenticEmployee(userName, password);
        }
        public static bool AddEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.Id = employee.Id;
            e.Gender = employee.Gender;
            e.MobileNo = employee.MobileNo;
            e.UserName = employee.UserName;
            e.Password = employee.Password;
            return db.Employees.AddEmployee(e);
        }
        public static Employee GetEmployee(string userName)
        {
            return db.Employees.GetEmployee(userName);
        }
        public static bool UpdateEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.MobileNo = employee.MobileNo;
            e.UserName = employee.UserName;
          
            return db.Employees.UpdateEmployee(e);
        }
        public static bool DeleteEmployee(string userName)
        {
            return db.Employees.DeleteEmployee(userName);
        }
        public static ArrayList getAllEmployee()
        {
            return db.Employees.GetAllEmployee();
        }
    }
   
}
