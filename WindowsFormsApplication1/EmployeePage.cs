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
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void backMainB_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
            this.Close();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void showٍEmployeeSpecB_Click(object sender, EventArgs e)
        {

        }

        private void editٍEmployeeSpecB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeB_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeePage mainPage = new AddEmployeePage();
            mainPage.ShowDialog();
            this.Close();
        }

        private void removeEmployeeB_Click(object sender, EventArgs e)
        {

        }

        private void employeeGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
