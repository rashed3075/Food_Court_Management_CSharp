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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void loginCicked(object sender, EventArgs e)
        {
            new LoginInfo().Show();
        }

        private void RegClicked(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit!", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
