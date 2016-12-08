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
    public partial class AddCourseToTeacher : Form
    {
        public AddCourseToTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersPage mainPage = new TeachersPage();
            mainPage.ShowDialog();
            this.Close();
        }
    }
}