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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string userName = tbUser.Text;
            dynamic cust = CustomerController.GetCustomer(userName);
            if (cust != null)
            {
                panel.Visible = true;
                tbName.Text = cust.Name;
                tbMobile.Text = cust.MobileNo;
            }
            else
            {
                MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cust = new
            {
                Name = tbName.Text,
                MobileNo = tbMobile.Text,
                UserName = tbUser.Text

            };
            var result = CustomerController.UpdateCustomer(cust);
            if (result)
            {
                MessageBox.Show("Customer Updated");
            }
            else
            {
                MessageBox.Show("Customer couldn't updated");
            }
        }
    }
}
