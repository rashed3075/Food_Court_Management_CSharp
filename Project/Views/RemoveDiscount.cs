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
    public partial class RemoveDiscount : Form
    {
        public RemoveDiscount()
        {
            InitializeComponent();
        }

        private void RemoveDiscount_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void confrim_Click(object sender, EventArgs e)
        {
            string FoodId = tbId.Text;
            var DiscountResult = DiscountController.DeleteDiscount(FoodId);
            if (DiscountResult)
            {
                MessageBox.Show("Remove Discount Successfully");
                var foodResult = FoodController.GetFood(FoodId);
                var DiscountResult1 = DiscountController.GetDiscount(FoodId);
                int a = foodResult.Price + DiscountResult1.Amount;
                var updatePrice = new
                {
                    Id = FoodId,
                    Price = a
                };
                var updateResult = FoodController.UpdateFood2(updatePrice);
            }
            else
            {
                MessageBox.Show("Food Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
