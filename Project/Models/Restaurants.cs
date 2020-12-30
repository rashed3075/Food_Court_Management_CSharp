using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Restaurants
    {
        SqlConnection conn;
        public Restaurants() { }
        public Restaurants(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddRestaurant(Restaurant restaurant)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Restaurant VALUES('{0}','{1}','{2}')", restaurant.Id, restaurant.Name, restaurant.Location);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public bool DeleteRestautant(string id)
        {
            conn.Open();
            string query = String.Format("Delete FROM Restaurant WHERE Id='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool UpdateRestaurant(Restaurant restaurant)
        {
            conn.Open();
            string query = String.Format("UPDATE Restaurant SET Name='{0}',Location='{1}' WHERE Id='{2}'", restaurant.Name, restaurant.Location, restaurant.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Restaurant GetRestaurant(string id)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Restaurant WHERE Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Restaurant restaurant = null;
            while (reader.Read())
            {
                restaurant = new Restaurant();
                restaurant.Id = reader.GetString(reader.GetOrdinal("Id"));
                restaurant.Name = reader.GetString(reader.GetOrdinal("Name"));
                restaurant.Location = reader.GetString(reader.GetOrdinal("Location"));
            }
            conn.Close();
            return restaurant;
        }
        public ArrayList GetAllRestaurant()
        {
            ArrayList restaurants = new ArrayList();
            conn.Open();
            string query = "Select * FROM Restaurant";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Restaurant restaurant = new Restaurant();
                restaurant.Id = reader.GetString(reader.GetOrdinal("Id"));
                restaurant.Name = reader.GetString(reader.GetOrdinal("Name"));
                restaurant.Location = reader.GetString(reader.GetOrdinal("Location"));
                restaurants.Add(restaurant);
            }

            conn.Close();
            return restaurants;
        }
       

    }
}
