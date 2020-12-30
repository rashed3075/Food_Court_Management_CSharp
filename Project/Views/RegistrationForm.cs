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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminReg().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmployeeReg().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerReg().Show();
        }
    }
}
