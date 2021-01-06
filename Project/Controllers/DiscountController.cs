using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class DiscountController
    {
        static Database db = new Database();
        public static bool AddDiscount(dynamic discount)
        {
            Discount d = new Discount();
            d.FoodId = discount.FoodId;
            d.Amount = discount.Amount;
            d.DNAme = discount.DName;
            return db.Discouts.AddDiscount(d);
        }
        public static bool DeleteDiscount(string id)
        {
            return db.Discouts.DeleteDiscount(id);
        }
        public static Discount GetDiscount(string id)
        {
            return db.Discouts.GetDiscount(id);
        }
        public static ArrayList GetAllDiscount()
        {
            return db.Discouts.GetAllDiscount();
        }
    }
}
