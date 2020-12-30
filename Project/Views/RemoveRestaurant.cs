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
    public partial class RemoveRestaurant : Form
    {
        public RemoveRestaurant()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            dynamic restaurant = RestaurantController.DeleteRestaurant(id);
            if (restaurant)
            {
                MessageBox.Show("Delete Restaurant Successfully");
            }
            else
            {
                MessageBox.Show("Restaurant Not found");
            }
        }
    }
}
