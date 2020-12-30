using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees() { }
        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO EmployeeInfo VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", employee.Name, employee.Id, employee.Gender, employee.MobileNo, employee.UserName, employee.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Employee AuthenticEmployee(string userName , string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM EmployeeInfo WHERE UserName='{0}' AND Password='{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Id = reader.GetString(reader.GetOrdinal("Id"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return employee;
        }
        public ArrayList GetAllEmployee()
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "Select * FROM EmployeeInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Id = reader.GetString(reader.GetOrdinal("Id"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public Employee GetEmployee(string userName)
        {
            conn.Open();
            string query = String.Format("Select * FROM EmployeeInfo WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                 employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Id = reader.GetString(reader.GetOrdinal("Id"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                
            }
            conn.Close();
            return employee;
        }
        public bool UpdateEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("UPDATE EmployeeInfo SET Name='{0}',MobileNo='{1}' WHERE UserName='{2}'", employee.Name, employee.MobileNo, employee.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteEmployee(string userName)
        {
            conn.Open();
            string query = String.Format("DELETE FROM EmployeeInfo WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
