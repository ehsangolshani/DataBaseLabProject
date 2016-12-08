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
    public partial class ExamPage : Form
    {
        public ExamPage()
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

        private void showAndMarkParticipatorsB_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayAndMarkExamParticipators mainPage = new DisplayAndMarkExamParticipators();
            mainPage.ShowDialog();
            this.Close();
        }

        private void addExamB_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddExam mainPage = new AddExam();
            mainPage.ShowDialog();
            this.Close();
        }

        private void searchExamB_Click(object sender, EventArgs e)
        {

        }

        private void removeSelectedExamB_Click(object sender, EventArgs e)
        {

        }

        private void showAbsentsB_Click(object sender, EventArgs e)
        {

        }
    }
}
