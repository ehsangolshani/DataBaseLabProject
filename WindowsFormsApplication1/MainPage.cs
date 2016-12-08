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
    public partial class MainPage : Form
    {
        public MainPage()
        {
    
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ////should be deleted
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            ////should be deleted

        }

        private void employeeB_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePage employeePage = new EmployeePage();
            employeePage.ShowDialog();
            this.Close();
        }

        private void teachersB_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersPage teacherPage = new TeachersPage();
            teacherPage.ShowDialog();
            this.Close();
        }

        private void gradesB_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradesPage gradesPage = new GradesPage();
            gradesPage.ShowDialog();
            this.Close();
        }

        private void examsB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamPage examPage = new ExamPage();
            examPage.ShowDialog();
            this.Close();
        }

        private void eventsB_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventPage eventPage = new EventPage();
            eventPage.ShowDialog();
            this.Close();
        }

        private void financeB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinancialPage financialPage = new FinancialPage();
            financialPage.ShowDialog();
            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
