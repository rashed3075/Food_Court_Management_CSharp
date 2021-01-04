using System;
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
    }
}
