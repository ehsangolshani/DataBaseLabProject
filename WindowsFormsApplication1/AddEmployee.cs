using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeB_Click(object sender, EventArgs e)
        {

        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePage mainPage = new EmployeePage();
            mainPage.ShowDialog();
            this.Close();
        }
    }
}
