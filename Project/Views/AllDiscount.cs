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
    public partial class AllDiscount : Form
    {
        public AllDiscount()
        {
            InitializeComponent();
            var ds = DiscountController.GetAllDiscount();
            dataGridView1.DataSource = ds;
        }

        private void AllDiscount_Load(object sender, EventArgs e)
        {

        }
    }
}
