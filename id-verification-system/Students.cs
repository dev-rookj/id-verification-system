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
    public partial class Students : Form
    {
        public Students()
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
            listMenu.Items.Add("niggas");
        }

        private void listMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listMenu.SelectedItem != null)
            {
                new Student_View().ShowDialog();
            }
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
    }
}
