using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string userName , string password)
        {
            return db.Admins.AuthenticateAdmin(userName, password);
        }
        public static bool AddAdmin(dynamic admin)
        {
            Admin a = new Admin();
            a.Id = admin.Id;
            a.Name = admin.Name;
            a.UserName = admin.UserName;
            a.Password = admin.Password;
            a.MobileNo = admin.MobileNo;
            a.Gender = admin.Gender;
            return db.Admins.AddAdmin(a);
        }
        public static Admin GetAdmin(string userName)
        {
            return db.Admins.GetAdmin(userName);
        }
        public static bool UpdateAdmin(dynamic admin)
        {
            Admin a = new Admin();
            a.Id = admin.Id;
            a.Name = admin.Name;
            a.UserName = admin.UserName;
            a.Password = admin.Password;
            a.MobileNo = admin.MobileNo;
            a.Gender = admin.Gender;
            return db.Admins.UpdateAdmin(a);
        }
        public static bool DeleteAdmin(string userName)
        {
            return db.Admins.DeleteAdmin(userName);
        }
        public static ArrayList GetAllAdmin()
        {
            return db.Admins.GetAllAdmin();
        }
    }
}
