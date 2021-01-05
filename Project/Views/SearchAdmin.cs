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
    public partial class SearchAdmin : Form
    {
        public SearchAdmin()
        {
            InitializeComponent();
        }

        private void SearchAdmin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            dynamic cust = AdminController.GetAdmin(user);
            if (cust != null)
            {
                tbName.Text = cust.Name;
                tbMobile.Text = cust.MobileNo;
                tbGender.Text = cust.Gender;
                tbId.Text = cust.Id;
            }
            else
            {
                MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
