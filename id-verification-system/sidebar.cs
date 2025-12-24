using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace id_verification_system
{
    public partial class sidebar : Form
    {
        public sidebar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Logout().ShowDialog();
        }

        private void sbDashboardBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Dashboard().Show();
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sbCoursesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Courses().Show();
        }

        private void sbRecordsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Records().Show();
        }
    }
}
