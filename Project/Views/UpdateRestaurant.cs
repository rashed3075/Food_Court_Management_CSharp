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
    public partial class UpdateRestaurant : Form
    {
        public UpdateRestaurant()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            string id = tbId.Text;
            dynamic restaurant = RestaurantController.GetRestaurant(id);
            if (restaurant != null)
            {
                panel.Visible = true;
                tbName.Text = restaurant.Name;
                tbLocation.Text = restaurant.Location;
            }
            else
            {
                MessageBox.Show("No Restaurant Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClicked(object sender, EventArgs e)
        {
            var restaurant = new
            {
                Id =tbId.Text,
                Name=tbName.Text,
                Location=tbLocation.Text
            };
            var result = RestaurantController.UpdateRestaurant(restaurant);
            if (result)
            {
                MessageBox.Show("Restaurant Updated");
            }
            else
            {
                MessageBox.Show("Restaurant couldn't updated");
            }
        }
    }
}
