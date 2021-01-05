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
    public partial class ReviewRestaurant : Form
    {
        public ReviewRestaurant()
        {
            InitializeComponent();
        }

        private void ReviewRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void tbRestId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var review = new
            {
                RestaurantId = tbRestId.Text,
                RestaurantReview = tbReview.Text
            };
            var RestResult = RestaurantController.GetRestaurant(tbRestId.Text);
            if (RestResult != null)
            {
                var result = ReviewController.AddReview(review);
                if (result)
                {
                    MessageBox.Show("Review Recorded");
                }
                else
                {
                    MessageBox.Show("Review Recording failed");
                }
            }
            else
            {
                MessageBox.Show("Restaurant Not Found");
            }
        }
    }
}
