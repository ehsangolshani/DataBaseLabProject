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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersPage mainPage = new TeachersPage();
            mainPage.ShowDialog();
            this.Close();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
