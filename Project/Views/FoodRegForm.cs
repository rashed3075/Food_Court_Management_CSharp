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
    public partial class FoodRegForm : Form
    {
        public FoodRegForm()
        {
            InitializeComponent();
        }

        private void RegClicked(object sender, EventArgs e)
        {
            var food = new
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Quantity = Convert.ToInt32(tbQuantity.Text),
                Price = Convert.ToInt32(tbPrice.Text),
                RestId = tbRestId.Text
            };
            var RestResult = RestaurantController.GetRestaurant(tbRestId.Text);
            if (RestResult != null)
            {
                var result = FoodController.AddFood(food);
                if (result)
                {
                    MessageBox.Show("Food Added", "Food Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Could not Add Food", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not Add Restaurant", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
