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
    public partial class AllReview : Form
    {
        public AllReview()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = tbRestId.Text;
            var restResult = RestaurantController.GetRestaurant(id);
            if (restResult != null)
            {
                var ds = ReviewController.GetSomeReview(id);
                dataGridView1.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Review Not Found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = ReviewController.GetAllReview();
            dataGridView2.DataSource = ds;
        }
    }
}
