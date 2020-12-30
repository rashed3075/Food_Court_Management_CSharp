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
    public partial class CustomerReg : Form
    {
        public CustomerReg()
        {
            InitializeComponent();
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            var customer = new
            {
                Name = tbName.Text,
                Id = custId.Text,
                Gender = tbGender.SelectedItem.ToString(),
                MobileNo = tbMobile.Text,
                UserName = tbUser.Text,
                Password = tbPass.Text
            };
            var result = CustomerController.AddCustomer(customer);
            if (result)
            {
                MessageBox.Show("Customer Added","Customer Registration",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Could not Add Customer", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
