using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
   
    public class Admins
    {
        SqlConnection conn;
        public Admins() { }
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO AdminInfo VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",admin.Id,admin.Name,admin.UserName,admin.Password,admin.MobileNo,admin.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Admin AuthenticateAdmin(string userName , string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM AdminInfo WHERE UserName='{0}' AND Password='{1}'", userName, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetString(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admin.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
            }
            conn.Close();
            return admin;
        }
        public ArrayList GetAllAdmin()
        {
            ArrayList admins = new ArrayList();
            conn.Open();
            string query = "Select * FROM AdminInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Admin admin = new Admin();
                admin.Id = reader.GetString(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admin.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                admins.Add(admin);

            }
            conn.Close();
            return admins;
        }
        public Admin GetAdmin(string userName)
        {
            conn.Open();
            string query = String.Format("Select * FROM AdminInfo WHERE UserName='{0}'",userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while(reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetString(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admin.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
            }
            conn.Close();
            return admin;
        }
        public bool UpdateAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("UPDATE AdminInfo SET Name='{0}',MobileNo='{1}' WHERE UserName='{2}'", admin.Name,admin.MobileNo,admin.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteAdmin(string userName)
        {
            conn.Open();
            string query = String.Format("DELETE FROM AdminInfo WHERE UserName='{0}'",userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }


    }
}
