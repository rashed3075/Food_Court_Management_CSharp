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
    public partial class RestaurantList : Form
    {
        public RestaurantList()
        {
            InitializeComponent();
            var ds = RestaurantController.GetAllRestaurant();
            dgView.DataSource = ds;
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
