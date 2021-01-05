using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Customers
    {
        SqlConnection conn;
        public Customers() { }
        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO CustomerInfo VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", customer.Name, customer.Id, customer.Gender, customer.MobileNo, customer.UserName, customer.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public Customer AuthenticateCustomer(string userName , string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM CustomerInfo WHERE UserName='{0}' AND Password='{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public ArrayList GetAllCustomer()
        {
            ArrayList customers = new ArrayList();
            conn.Open();
            string query = "Select * FROM CustomerInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
                customers.Add(customer);
            }
            conn.Close();
            return customers;
        }
        public Customer GetCustomer(string userName)
        {
            conn.Open();
            string query = String.Format("Select * FROM CustomerInfo WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public bool UpdateCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("UPDATE CustomerInfo SET Name='{0}',MobileNo='{1}' WHERE UserName='{2}'", customer.Name, customer.MobileNo, customer.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteCustomer(string userName)
        {
            conn.Open();
            string query = String.Format("DELETE FROM CustomerInfo WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false; 
        }
    }
}
