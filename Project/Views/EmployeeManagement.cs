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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeReg().Show();
        }

        private void RemoveEmployee(object sender, EventArgs e)
        {
            new RemoveEmployee().Show();
        }

        private void uEmployee(object sender, EventArgs e)
        {
            new UpdateEmployee().Show();
        }

        private void fEmployee(object sender, EventArgs e)
        {
            SearchEmployee se = new SearchEmployee();
            this.Visible = false;
            se.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeList el = new EmployeeList();
            this.Visible = false;
            el.Visible = true;
        }
    }
}
