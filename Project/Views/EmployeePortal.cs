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
        public EmployeePortal()
        {
            InitializeComponent();
        }

        private void cManagement_Click(object sender, EventArgs e)
        {
            new CustomerManagement().Show();
        }
    }
}
