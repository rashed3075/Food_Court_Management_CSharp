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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
            var ds = OrderController.GetAllOrder();
            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
