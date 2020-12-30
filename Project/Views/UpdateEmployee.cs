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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void searchItem(object sender, EventArgs e)
        {
            panel.Visible = true;
            string userName = tbUser.Text;
            dynamic employee = EmployeeController.GetEmployee(userName);
            if (employee != null)
            {
                tbName.Text = employee.Name;
                tbMobile.Text = employee.MobileNo;
            }
            else
            {
                MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateClicked(object sender, EventArgs e)
        {
            var employee = new
            {
                 Name = tbName.Text,
                 MobileNo = tbMobile.Text,
                UserName = tbUser.Text

            };
            var result = EmployeeController.UpdateEmployee(employee);
            if(result)
            {
                MessageBox.Show("Employee Updated");
            }
            else
            {
                MessageBox.Show("Employee couldn't updated");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
