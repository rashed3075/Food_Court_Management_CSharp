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
    public partial class UpdateFood : Form
    {
        public UpdateFood()
        {
            InitializeComponent();
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            string id = tbId.Text;
            dynamic food = FoodController.GetFood(id);
            if (food != null)
            {
                panel.Visible = true;
                tbName.Text = food.Name;
                tbQuantity.Text = Convert.ToString(food.Quantity);
                tbPrice.Text = Convert.ToString(food.Price);
                dynamic restaurant = RestaurantController.GetRestaurant(food.RestId);
                tbRestaurant.Text = restaurant.Name;
            }
            else
            {
                MessageBox.Show("No Food Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            var food = new
            {
                Id = tbId.Text,
                Quantity=Convert.ToInt32(tbQuantity.Text),
                Price=Convert.ToInt32(tbPrice.Text)
            };
            var result = FoodController.UpdateFood(food);
            
            if (result)
            {
                MessageBox.Show("Food Updated");
            }
            else
            {
                MessageBox.Show("Food couldn't updated");
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
