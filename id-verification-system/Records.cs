using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            LoadRecords();
        }

        private void LoadRecords()
        {
            recordsTable.Rows.Clear();

            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = "SELECT record_date, record_time, student_id, student_name, course_name, remarks FROM records ORDER BY record_id DESC";
                using (var cmd = new SQLiteCommand(q, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recordsTable.Rows.Add(
                            reader.GetString(0), // DateCol
                            reader.GetString(1), // TimeCol
                            reader.GetString(2), // StudentNoCol
                            reader.GetString(3), // StudentNameCol
                            reader.GetString(4), // CourseNameCol
                            reader.GetString(5)  // RemarksCol
                        );
                    }
                }
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainMenu menu = new MainMenu();
                menu.Show();

                this.Hide();
            }
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
            // load
        }

        private void spBackBtn_Click(object sender, EventArgs e)
        {
            if (sidePanel.Visible)
            {
                sidePanel.Visible = false;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Enabled = true;
                }
            }
        }

        private void sbTogBtn_Click(object sender, EventArgs e)
        {
            if (!sidePanel.Visible)
            {
                sidePanel.Visible = true;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl != sidePanel)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainMenu menu = new MainMenu();
                menu.Show();

                this.Hide();
            }
        }
    }
}
