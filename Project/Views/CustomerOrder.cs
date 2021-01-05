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
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void ConfirmClicked(object sender, EventArgs e)
        {
            var order = new
            {
                OrderId = 0,
                FId = tbId.Text,
                FQuantity = Convert.ToInt32(tbQuantity.Text)
            };
            var FoodResult = FoodController.GetFood(tbId.Text);
            if (FoodResult != null)
            {
               
                int a = FoodResult.Quantity - Convert.ToInt32(tbQuantity.Text);
                if (a > 0)
                {
                    var food = new
                    {
                        Id = tbId.Text,
                        Quantity = a
                    };
                    var x = FoodController.UpdateFood1(food);
                    var OrderResult = OrderController.AddOrder(order);
                    if (OrderResult)
                    {
                        MessageBox.Show("Confirm Order Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry Food is not available right now", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not find any food", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
