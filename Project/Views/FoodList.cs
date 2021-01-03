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
    public partial class FoodList : Form
    {
        public FoodList()
        {
            InitializeComponent();
           

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SbmitClicked(object sender, EventArgs e)
        {
            string id = tbId.Text;
            dynamic food = FoodController.GetAllFood(id);
            if (food!=null)
            {
                dynamic restaurant = RestaurantController.GetRestaurant(id);
                if (restaurant != null)
                {
                    tbName.Text = restaurant.Name;
                }
                else
                {
                    MessageBox.Show("No Restaurant found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgView.DataSource = food;
            }
            else
            {
                MessageBox.Show("No Restaurant found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
