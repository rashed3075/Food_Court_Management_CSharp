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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
            var ds = EmployeeController.getAllEmployee();
            dgView.DataSource = ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManagement ep = new EmployeeManagement();
            this.Visible = false;
            ep.Visible = true;
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
