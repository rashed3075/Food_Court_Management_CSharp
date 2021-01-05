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
    public partial class CustomerPortal : Form
    {
        public CustomerPortal(string name)
        {
            InitializeComponent();
            string output = String.Format("Welcome {0}", name);
            WelcomeBox.Text = output;
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            new FoodList().Show();
        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            new CustomerOrder().Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            new OrderHistory().Show();
        }

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            new RestaurantList().Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            new ReviewRestaurant().Show();
        }
    }
}
