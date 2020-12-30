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
    public partial class LoginInfo : Form
    {
        public LoginInfo()
        {
            InitializeComponent();
        }

        private void LoginInfo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
             if(checkPass.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void loginClicked(object sender, EventArgs e)
        {
            string UserName = userName.Text;
            string Password = password.Text;
            string catagory = Catagory.SelectedItem.ToString();
          
          if(catagory.Equals("Admin"))
            {
                dynamic AdminResult = AdminController.AuthenticateAdmin(UserName, Password);
               
                if(AdminResult!=null)
                {
                    string welcomeName = AdminResult.Name;
                    new AdminPortal(welcomeName ).Show();
                }
                else
                {
                    MessageBox.Show("User Not Valid","Invalid Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (catagory.Equals("Customer"))
            {
                var CustomerResult =CustomerController.AuthenticateCustomer(UserName, Password);
                if (CustomerResult != null)
                {
                    new CustomerPortal().Show();
                }
                else { 
                    MessageBox.Show("User Not Valid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (catagory.Equals("Employee"))
            {
                var EmployeeResult = EmployeeController.AuthenticEmployee(UserName, Password);
                if (EmployeeResult != null)
                {
                    new EmployeePortal().Show();
                }
                else
                {
                    MessageBox.Show("User Not Valid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ForgetPassword().Show();
        }
    }
}
