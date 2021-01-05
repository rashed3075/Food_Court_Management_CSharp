using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
   public class OrderController
    {
        static Database db = new Database();
        public static bool AddOrder(dynamic order)
        {
            Order o = new Order();
            o.FId = order.FId;
            o.FQuantity = order.FQuantity;
            return db.Orders.AddOrder(o);
        }
       public static ArrayList GetAllOrder()
        {
            return db.Orders.GetAllOrder();
        }
    }
}
