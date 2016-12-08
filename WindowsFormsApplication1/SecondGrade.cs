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
    public partial class SecondGrade : Form
    {
        public SecondGrade()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradesPage gradesPage = new GradesPage();
            gradesPage.ShowDialog();
            this.Close();
        }
    }
}
