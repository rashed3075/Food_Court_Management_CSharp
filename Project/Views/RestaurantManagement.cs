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
    public partial class RestaurantManagement : Form
    {
        public RestaurantManagement()
        {
            InitializeComponent();
        }

        private void adClick(object sender, EventArgs e)
        {
            new RestaurantRegForm().Show();
        }

        private void rmClicked(object sender, EventArgs e)
        {
            new RemoveRestaurant().Show();
        }

        private void urClicked(object sender, EventArgs e)
        {
            new UpdateRestaurant().Show();
        }

        private void frClicked(object sender, EventArgs e)
        {
            new FindRestaurant().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new RestaurantList().Show();
        }
    }
}
