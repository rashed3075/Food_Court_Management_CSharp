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
    public partial class EmployeeReg : Form
    {
        public EmployeeReg()
        {
            InitializeComponent();
        }

        private void EmployeeRegister(object sender, EventArgs e)
        {
            var employee = new
            {
                Name = tbName.Text,
                Id = tbId.Text,
            Gender = tbGender.SelectedItem.ToString(),
            MobileNo = tbMobile.Text,
            UserName = tbUser.Text,
            Password = tbPass.Text
            };
            var result = EmployeeController.AddEmployee(employee);
            if(result)
            {
                MessageBox.Show("Employee Added", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Could not Add Employee", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
