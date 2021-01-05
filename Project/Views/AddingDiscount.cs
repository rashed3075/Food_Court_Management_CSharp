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
    public partial class AddingDiscount : Form
    {
        public AddingDiscount()
        {
            InitializeComponent();
        }

        private void AddingDiscount_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
