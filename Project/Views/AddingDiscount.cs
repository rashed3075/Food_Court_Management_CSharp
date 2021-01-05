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
    public partial class AddingDiscount : Form
    {
        public AddingDiscount()
        {
            InitializeComponent();
        }

        private void AddingDiscount_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void ConfrimCliked(object sender, EventArgs e)
        {
            var discount = new
            {
                DiscountID = 0,
                FoodId = tbFoodId.Text,
                Amount = Convert.ToInt32(tbAmount.Text),
                DName = tbName.Text
            };
            var foodResult = FoodController.GetFood(tbFoodId.Text);
            if (foodResult != null)
            {
                int a = foodResult.Price - Convert.ToInt32(tbAmount.Text);
                if (a >= 0)
                {
                    var price = new
                    {
                        Price = a,
                        Id = tbFoodId.Text
                    };
                    var discountResult = DiscountController.AddDiscount(discount);
                    if (discountResult)
                    {
                        var priceDeduct = FoodController.UpdateFood2(price);
                        MessageBox.Show("Discount Added Successfully", "Discount add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                }
                else
                {
                    MessageBox.Show("Insuffficient Discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Food Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
