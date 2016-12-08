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
    public partial class TeachersPage : Form
    {
        public TeachersPage()
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

        private void addNewTeacherB_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeacher mainPage = new AddTeacher();
            mainPage.ShowDialog();
            this.Close();
        }

        private void addNewCourseForTeacherB_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourseToTeacher mainPage = new AddCourseToTeacher();
            mainPage.ShowDialog();
            this.Close();
        }
    }
}
