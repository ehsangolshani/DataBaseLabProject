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
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamPage mainPage = new ExamPage();
            mainPage.ShowDialog();
            this.Close();
        }

        private void addExamB_Click(object sender, EventArgs e)
        {

        }
    }
}
