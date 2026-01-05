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
using System.IO;

namespace id_verification_system
{
    public partial class Students : Form
    {
        public string studName;
        public Students()
        {
            InitializeComponent();
            time.Start();
        }

        public void LoadStudents()
        {
            string connString = "Data Source=systemDB.db;";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string query = "SELECT student_id, name FROM students ORDER BY name ASC";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    listMenu.Items.Clear();

                    while (reader.Read())
                    {
                        string studentId = reader["student_id"].ToString();
                        string studentName = reader["name"].ToString();

                        listMenu.Items.Add($"{studentId} - {studentName}");
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

        private void listMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Get the item text
            string text = listMenu.Items[e.Index].ToString();

            // Decide background color
            Color backColor;
            Color foreColor;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backColor = Color.FromArgb(39, 98, 33);   // custom background for selected item
                foreColor = Color.White;      // custom text color
            }
            else
            {
                backColor = listMenu.BackColor;
                foreColor = listMenu.ForeColor;
            }

            // Fill background
            using (SolidBrush bgBrush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

            // Draw text
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, foreColor, TextFormatFlags.Left);
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

        private void Students_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void listMenu_DoubleClick(object sender, EventArgs e)
        {
            /*if (listMenu.SelectedItem != null)
            {
                // Split "ID - Name" back into parts
                string selectedItem = listMenu.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                string studentId = parts[0].Trim();   // ID
                string studentName = parts[1].Trim(); // Name

                // Pass ID (safer than name) to Student_View
                Student_View viewForm = new Student_View(studentId);
                viewForm.ShowDialog();
            }*/

            if (listMenu.SelectedItem == null) return;

            string selected = listMenu.SelectedItem.ToString();
            string[] parts = selected.Split(new[] { '-' }, 2);

            if (parts.Length < 2) return;

            string selectedId = parts[0].Trim();
            string selectedName = parts[1].Trim();

            // Pass ID and Name into Student_View
            Student_View view = new Student_View(selectedId, selectedName);
            view.ShowDialog();
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

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            new Enroll_Student().ShowDialog();
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadStudents();
            listMenu.Refresh();
        }
    }
}
