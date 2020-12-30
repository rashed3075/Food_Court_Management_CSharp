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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void LoginPage(object sender, EventArgs e)
        {
            new LoginInfo().Show();
        }

        private void SubmtClicked(object sender, EventArgs e)
        {
            passwordPanel.Visible = true;
            string userName = TbUser.Text;
            string catagory = TbCatagory.SelectedItem.ToString();
            if(catagory.Equals("Admin"))
            {
                dynamic admin = AdminController.GetAdmin(userName);
                if(admin!=null)
                {
                    TbPassword.Text = admin.Password;
                }
                else
                { 
                        MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if(catagory.Equals("Customer"))
            {
                dynamic customer = CustomerController.GetCustomer(userName);
                if(customer!=null)
                {
                    TbPassword.Text = customer.Password;
                }
                else
                {
                    MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (catagory.Equals("Employee"))
            {
                dynamic employee = EmployeeController.GetEmployee(userName);
                if (employee != null)
                {
                    TbPassword.Text = employee.Password;
                }
                else
                {
                    MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
