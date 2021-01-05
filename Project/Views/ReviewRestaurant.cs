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
            var review = new {
                restId = tbRestId.Text,
                rev = tbReview.Text
            };

            var RestResult = RestaurantController.GetRestaurant(tbRestId.Text);
            if (RestResult != null)
            {
                var ReviewResult = ReviewController.MakeReview(review);
                if (ReviewResult)
                {
                    MessageBox.Show("Review Added Successfully", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Review Submission Failed", "Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Restaurant not found", "Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
