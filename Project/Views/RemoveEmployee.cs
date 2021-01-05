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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            string userName = tbUser.Text;
            dynamic employee = EmployeeController.DeleteEmployee(userName);
            if (employee)
            {
                MessageBox.Show("Employee Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Employee Not found");
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
