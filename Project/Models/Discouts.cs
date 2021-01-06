using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Discouts
    {
        SqlConnection conn;
        public Discouts() { }
        public Discouts(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddDiscount(Discount discount)
        {
            conn.Open();
            
            string query = String.Format("INSERT INTO DiscountHistory VALUES('{0}','{1}','{2}')",discount.FoodId,discount.Amount,discount.DNAme);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public bool DeleteDiscount(string id)
        {
            conn.Open();
            string query = String.Format("DELETE FROM DiscountHistory WHERE DiscountId='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Discount GetDiscount(string id)
        {
            conn.Open();
            string query = String.Format("Select * FROM DiscountHistory WHERE FoodId='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Discount discount = null;

            while (reader.Read())
            {
                discount = new Discount();
                discount.DiscountId = reader.GetInt32(reader.GetOrdinal("DiscountId"));
                discount.FoodId = reader.GetString(reader.GetOrdinal("FoodId"));
                discount.Amount = reader.GetInt32(reader.GetOrdinal("Amount"));
                discount.DNAme = reader.GetString(reader.GetOrdinal("DName"));
            }
            conn.Close();
            return discount;
        }
        public ArrayList GetAllDiscount()
        {
            ArrayList discounts = new ArrayList();
            conn.Open();
            string query = "Select * FROM DiscountHistory";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Discount discount = new Discount();
                discount.DiscountId = reader.GetInt32(reader.GetOrdinal("DiscountId"));
                discount.FoodId = reader.GetString(reader.GetOrdinal("FoodId"));
                discount.Amount = reader.GetInt32(reader.GetOrdinal("Amount"));
                discount.DNAme = reader.GetString(reader.GetOrdinal("DName"));
                discounts.Add(discount);
            }

            conn.Close();
            return discounts;
        }

    }
}
