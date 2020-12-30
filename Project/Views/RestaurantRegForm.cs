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
    public partial class RestaurantRegForm : Form
    {
        public RestaurantRegForm()
        {
            InitializeComponent();
        }

        private void regClick(object sender, EventArgs e)
        {
            var restaurant = new
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Location = tbLocation.Text
            };
            var result = RestaurantController.AddRestaurant(restaurant);
            if (result)
            {
                MessageBox.Show("Restaurant Added", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Could not Add Restaurant", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
