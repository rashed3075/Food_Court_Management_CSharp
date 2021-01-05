using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Orders
    {
        SqlConnection conn;
        public Orders() { }
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddOrder(Order order)
        {
            conn.Open();
            string query = String.Format("INSERT INTO OrderHistory VALUES('{0}','{1}')",order.FId,order.FQuantity);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
       public ArrayList GetAllOrder()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = String.Format("select * FROM OrderHistory");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {  
                Order order = new Order();
              
                order.OrderId = reader.GetInt32(reader.GetOrdinal("OrderId"));
                order.FId = reader.GetString(reader.GetOrdinal("FId"));
                order.FQuantity = reader.GetInt32(reader.GetOrdinal("FQuantity"));
                orders.Add(order);
               ;
            }
            conn.Close();
            return orders;
        }
    }
}
