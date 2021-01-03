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
        public CustomerPortal()
        {
            InitializeComponent();
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            new RestaurantList().Show();
        }
    }
}
