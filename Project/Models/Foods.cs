using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Foods
    {
        SqlConnection conn;
        public Foods() { }
        public Foods(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddFood(Food food)
        {
            conn.Open();
            Restaurant restaurant = new Restaurant();
            string query = String.Format("INSERT INTO FoodItem VALUES('{0}','{1}','{2}','{3}','{4}')", food.Id, food.Name, food.Quantity, food.Price,food.RestId);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public bool DeleteFood(string id)
        {
            conn.Open();
            string query = String.Format("DELETE FROM FoodItem WHERE RestId='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Food GetFood(string id)
        {
            conn.Open();
            string query = String.Format("Select FoodItem.*,Restaurant.Id,Restaurant.Name FROM FoodItem,Restaurant WHERE (FoodItem.RestId=Restaurant.Id) AND RestId='{0}'",id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Food food = null;
            while (reader.Read())
            {
                food = new Food();
                food.Id = reader.GetString(reader.GetOrdinal("Id"));
                food.Name = reader.GetString(reader.GetOrdinal("Name"));
                food.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                food.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                food.RestId = reader.GetString(reader.GetOrdinal("RestId"));
                
            }
            conn.Close();
            return food;
        }



    }
}
