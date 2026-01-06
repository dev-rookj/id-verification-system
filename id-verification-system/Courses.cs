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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            time.Start();
            RefreshCourseList();
        }
        private void RefreshCourseList()
        {
            listMenu.Items.Clear();

            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = "SELECT course_code, course_name FROM courses ORDER BY course_code;";
                using (var cmd = new SQLiteCommand(q, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string code = reader.GetString(0);
                        string name = reader.GetString(1);

                        listMenu.Items.Add($"[{code}] {name}");
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

        private void sbStudentsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Students().Show();
        }

        private void sbRecordsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Records().Show();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add_Course())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCourseList();
                }
            }
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            RefreshCourseList();
        }

        private void listMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listMenu.SelectedItem == null) return;

            string selected = listMenu.SelectedItem.ToString();

            int startBracket = selected.IndexOf('[');
            int endBracket = selected.IndexOf(']');
            if (startBracket == -1 || endBracket == -1) return;

            string selectedCode = selected.Substring(startBracket + 1, endBracket - startBracket - 1).Trim();
            string selectedName = selected.Substring(endBracket + 1).Trim();

            using (var view = new Course_View(selectedCode, selectedName))
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    RefreshCourseList();
                }
            }
        }
    }
}
