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
    public partial class RemoveFood : Form
    {
        public RemoveFood()
        {
            InitializeComponent();
        }

        private void deleteclicked(object sender, EventArgs e)
        {
            string id = tbID.Text;
            dynamic food = FoodController.DeleteFood(id);
            if (food)
            {
                MessageBox.Show("Delete Food successfully...");
            }
            else
            {
                MessageBox.Show("Food Not Found", "Food Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
