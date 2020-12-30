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
    public partial class FindRestaurant : Form
    {
        public FindRestaurant()
        {
            InitializeComponent();
        }

        private void FindRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            dynamic restaurant = RestaurantController.GetRestaurant(id);
            if (restaurant != null)
            {
                tbName.Text = restaurant.Name;
                tbLocation.Text = restaurant.Location;
            }
            else
            {
                MessageBox.Show("No Restaurant Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
