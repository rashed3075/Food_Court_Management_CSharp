using Project.Models;
using System;
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

    }
}
