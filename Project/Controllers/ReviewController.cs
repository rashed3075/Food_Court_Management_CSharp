using Project.Models;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ReviewController
    {
        static Database db = new Database();
        public static bool MakeReview(dynamic review)
        {
            Review r = new Review();
            r.restId = review.restId;
            r.review = review.review;
            return db.Reviews.MakeReview(r);
        }
    }
}
