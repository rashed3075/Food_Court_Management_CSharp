using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
   public class Discount
    {
        public int DiscountId { set; get; }
        public string FoodId { get; set; }
        public int Amount { get; set; }
        public string DNAme { get; set; }
    }
}
