using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.Controllers
{
    public class FoodController
    {
        static Database db = new Database();
        public static bool AddFood(dynamic food)
        {
            Food f = new Food();
            f.Id = food.Id;
            f.Name = food.Name;
            f.Quantity = food.Quantity;
            f.Price = food.Price;
            f.RestId = food.RestId;
            return db.Foods.AddFood(f);
        }
        public static bool DeleteFood(string id)
        {
            return db.Foods.DeleteFood(id);
        }
        public static Food GetFood(string id)
        {
            return db.Foods.GetFood(id);
        }
        public static bool UpdateFood(dynamic food)
        {
            Food f = new Food();
            f.Id = food.Id;
            f.Name = food.Name;
            f.Quantity = food.Quantity;
            f.Price = food.Price;
            return db.Foods.UpdateFood(f);
        }
        public static ArrayList GetAllFood(string id)
        {
            return db.Foods.GetAllFood(id);
        }
        public static bool UpdateFood1(dynamic food)
        {
            Food f = new Food();
            f.Id = food.Id;
            f.Quantity = food.Quantity;
       
            return db.Foods.UpdateFood1(f);
        }
        public static bool UpdateFood2(dynamic food)
        {
            Food f = new Food();
            f.Id = food.Id;
            f.Price = food.Price;

            return db.Foods.UpdateFood2(f);
        }
    }
}
