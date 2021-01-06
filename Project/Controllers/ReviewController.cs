using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ReviewController
    {
        static Database db = new Database();
        public static bool AddReview(dynamic review)
        {
            Review r = new Review();
            r.RestaurantId = review.RestaurantId;
            r.RestaurantReview = review.RestaurantReview;
            return db.Reviews.AddReview(r);
        }
        public static ArrayList GetAllReview()
        {
            return db.Reviews.GetAllReview();
        }
        public static ArrayList GetSomeReview(string id)
        {
            return db.Reviews.GetSomeReview(id);
        }
        
    }
}
