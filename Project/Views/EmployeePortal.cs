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
    public partial class EmployeePortal : Form
    {
        public EmployeePortal(string name)
        {
            InitializeComponent();
            string output = String.Format("Welcome {0}", name);
            WelcomeBox.Text = output;
        }

        private void cManagement_Click(object sender, EventArgs e)
        {
            new CustomerManagement().Show();
        }

        private void addDiscount_Click(object sender, EventArgs e)
        {
            new AddingDiscount().Show();
        }

        private void deliverOrder_Click(object sender, EventArgs e)
        {
            new OrderHistory().Show();
        }

        private void editDiscount_Click(object sender, EventArgs e)
        {
            LoginInfo li = new LoginInfo();
            this.Visible = false;
            li.Visible = true;
        }
    }
}
