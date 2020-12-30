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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchClicked(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            dynamic employee = EmployeeController.GetEmployee(user);
            if (employee != null)
            {
                tbName.Text = employee.Name;
                tbMobile.Text = employee.MobileNo;
                tbGender.Text = employee.Gender;
                tbId.Text = employee.Id;
            }
            else
            {
                MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManagement em = new EmployeeManagement();
            this.Visible = false;
            em.Visible = true;
        }
    }
}
