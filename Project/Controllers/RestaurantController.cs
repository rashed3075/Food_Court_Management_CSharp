using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class RestaurantController
    {
        static Database db = new Database();
        public static bool AddRestaurant(dynamic restaurant)
        {
            Restaurant r = new Restaurant();
            r.Id = restaurant.Id;
            r.Name = restaurant.Name;
            r.Location = restaurant.Location;
            return db.Restaurants.AddRestaurant(r);
        }
        public static Restaurant GetRestaurant(string id)
        {
            return db.Restaurants.GetRestaurant(id);
        }
        public static bool UpdateRestaurant(dynamic restaurant)
        {
            Restaurant r = new Restaurant();
            r.Id = restaurant.Id;
            r.Name = restaurant.Name;
            r.Location = restaurant.Location;
            return db.Restaurants.UpdateRestaurant(r);
        }
        public static bool DeleteRestaurant(string id)
        {
            return db.Restaurants.DeleteRestautant(id);
        }
        public static ArrayList GetAllRestaurant()
        {
            return db.Restaurants.GetAllRestaurant();
        }

    }
}
