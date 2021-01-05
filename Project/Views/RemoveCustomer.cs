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
    public partial class RemoveCustomer : Form
    {
        public RemoveCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            string userName = tbRemoveCustomer.Text;
            dynamic customer = CustomerController.DeleteCustomer(userName);
            if (customer)
            {
                MessageBox.Show("Customer Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Customer Not found");
            }
        }
    }
}
