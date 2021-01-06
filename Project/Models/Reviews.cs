using System;
using System.Collections;
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
        public bool AddReview(Review review)
        {
            conn.Open();
            string query = String.Format("INSERT INTO RReview VALUES('{0}','{1}')", review.RestaurantId,review.RestaurantReview);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }      
        public ArrayList GetSomeReview(string id)
        {
            ArrayList reviews = new ArrayList();

            conn.Open();
            string query = String.Format("SELECT * FROM RReview WHERE RestaurantId='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Review review = new Review();
                review.RestaurantId = reader.GetString(reader.GetOrdinal("RestaurantId"));
                review.RestaurantReview = reader.GetString(reader.GetOrdinal("RestaurantReview"));
                reviews.Add(review);
            }
            conn.Close();
            return reviews;
        }
        public ArrayList GetAllReview()
        {
            ArrayList reviews = new ArrayList();

            conn.Open();
            string query = String.Format("SELECT * FROM RReview");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Review review = new Review();
                review.RestaurantId = reader.GetString(reader.GetOrdinal("RestId"));
                review.RestaurantReview = reader.GetString(reader.GetOrdinal("RestaurantReview"));
                reviews.Add(review);
            }
            conn.Close();
            return reviews;
        }
    }
}
