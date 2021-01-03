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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            var cl = CustomerController.GetAllCustomer();
            dgViewCustomerList.DataSource = cl;
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {

        }

        private void labelCustomerList_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
