using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Reviews
    {
        SqlConnection conn;
        public Reviews() { }
        public Reviews(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool MakeReview(Review review)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Review VALUES('{0}','{1}')", review.restId,review.review);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
    }
}
