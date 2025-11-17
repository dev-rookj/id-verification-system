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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            time.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
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

        private void sbStudentsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Students().Show();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                recordsTable.Rows.Add("11/17/2025",
                "14:05:30",
                202410647,
                "Abrenica, Aljur",
                "[DCIT50] Object Oriented Programming",
                "LATE");
            }
        }
    }
}
