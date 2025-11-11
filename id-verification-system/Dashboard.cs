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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            time.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
        }

        private void infoField_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (infoField.Text.Length == 9)
                {
                    infoText.Text = "Student No.: STUDENT_NUMBER\r\nName: STUDENT_NAME\r\n\r\nTime In: " + DateTime.Now.ToString("hh:mm tt").ToUpper() + "\r\nRemarks: REMARK\r\n";
                    e.SuppressKeyPress = true;
                }
                else infoText.Text = "Invalid Barcode.";
                e.SuppressKeyPress = true;

                infoField.Text = "";
                infoReset.Stop(); // to avoid timer overlapping
                infoReset.Start();
            }
        }

        private void infoReset_Tick(object sender, EventArgs e)
        {
            infoText.Text = "Scan your ID...";
            infoReset.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Logout logout = new Logout();
           logout.ShowDialog();
           Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sbStudentsBtn_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            Hide();
        }
    }
}
