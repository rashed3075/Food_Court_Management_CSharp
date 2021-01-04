using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Database
    {
        public Admins Admins { get; set; }
        public Customers Customers { get; set; }
        public Employees Employees { get; set; }
        public Restaurants Restaurants { get; set; }
        public Foods Foods { get; set; }
        public Orders Orders { get; set; }

        public Database()
        {
           // string Nijhum = @"Server=LAPTOP-2U5ORHDR\SQLEXPRESS1;Database=Project;User Id=sa;Password=database;";
            string Rabby = @"Server=RABBY-PC\SQLEXPRESS;Database=Project;User Id=sa;Password=1234;";          
            //string Maliha = @"Server=103.148.99.54\SQLEXPRESS;Database=Project;User Id=sa;Password=78787878ml.;";          
            SqlConnection conn = new SqlConnection(Rabby);
            Admins = new Admins(conn);
            Customers = new Customers(conn);
            Employees = new Employees(conn);
            Restaurants = new Restaurants(conn);
            Foods = new Foods(conn);
            Orders = new Orders(conn);
        }
         
    }
}
