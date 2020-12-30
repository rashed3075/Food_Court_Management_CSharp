using Project.Controllers; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class AdminReg : Form
    {
        public AdminReg()
        {
            InitializeComponent();
        }

        private void DoReg(object sender, EventArgs e)
        {
            var admin = new
            {
                Id = AdminId.Text,
                Name = AdminName.Text,
                UserName = AdminUser.Text,
                Password = AdminPass.Text,
                MobileNo = AdminMobile.Text,
                Gender = AdminGender.SelectedItem.ToString()
            };
            var result = AdminController.AddAdmin(admin);
             if (result)
            {
                MessageBox.Show("Admin Added");
            }
            else {
                MessageBox.Show("Could not Add Admin","Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
