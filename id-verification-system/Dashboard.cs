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
            course();
        }

        public void course()
        {
            DateTime datetime = DateTime.Now;
            DayOfWeek day = datetime.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Monday:
                    curClass.Text = "NO CLASSES";
                    curTime.Text = "NO CLASSES";
                    curStatus.Text = "NO CLASSES";

                    break;

                case DayOfWeek.Tuesday:
                    if (datetime.Hour == 14 && datetime.Hour < 16 && datetime.Minute <= 59)
                    {
                        curClass.Text = "PATHFIT 3: PHYSICAL ACTIVITIES TOWWARDS HEALTH AND FITNESS I";
                        curTime.Text = "2:00PM - 4:00PM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 16 && datetime.Hour < 18 && datetime.Minute <= 59)
                    {
                        curClass.Text = "INSY 50: FUNDAMENTALS OF INFORMATION SYSTEM";
                        curTime.Text = "4:00PM - 6:00PM";
                        curStatus.Text = "ONGOING";
                    }
                    else
                    {
                        curClass.Text = "NO CLASSES";
                    }
                    break;

                case DayOfWeek.Wednesday:
                    if (datetime.Hour == 9 && datetime.Hour < 11 && datetime.Minute <= 59)
                    {
                        curClass.Text = "COSC 55: DISCRETE STRUCTURES II";
                        curTime.Text = "9:00AM - 11:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 12 && datetime.Hour < 14 && datetime.Minute <= 59)
                    {
                        curClass.Text = "DCIT 50: OBJECT ORIENTED PROGRAMMING (LECTURE)";
                        curTime.Text = "12:00PM - 2:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 14 && datetime.Hour < 16 && datetime.Minute <= 59)
                    {
                        curClass.Text = "DCIT 50: OBJECT ORIENTED PROGRAMMING (LABORATORY)";
                        curTime.Text = "2:00PM - 4:00PM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 16 && datetime.Hour < 18 && datetime.Minute <= 59)
                    {
                        curClass.Text = "GNED 04: MGA BABASAHIN HINGGIL SA KASAYSAYAN NG PILIPINAS";
                        curTime.Text = "4:00PM - 6:00PM";
                        curStatus.Text = "ONGOING";
                    }
                    else
                    {
                        curClass.Text = "NO CLASSES";
                    }
                    break;

                case DayOfWeek.Thursday:
                    curClass.Text = "NO CLASSES";
                    curTime.Text = "NO CLASSES";
                    curStatus.Text = "NO CLASSES";
                    break;

                case DayOfWeek.Friday:
                    if (datetime.Hour == 7 && datetime.Hour < 9 && datetime.Minute <= 59)
                    {
                        curClass.Text = "MATH 1: ANALYTIC GEOMETRY";
                        curTime.Text = "7:00AM - 9:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 9 && datetime.Hour < 11 && datetime.Minute <= 59)
                    {
                        curClass.Text = "DCIT 24: INFORMATION MANAGEMENT (LECTURE)";
                        curTime.Text = "9:00AM - 11:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 12 && datetime.Hour < 14 && datetime.Minute <= 59)
                    {
                        curClass.Text = "DCIT 24: INFORMATION MANAGEMENT (LABORATORY)";
                        curTime.Text = "12:00PM - 2:00PM";
                        curStatus.Text = "ONGOING";
                    }
                    else
                    {
                        curClass.Text = "NO CLASSES";
                    }
                    break;

                case DayOfWeek.Saturday:
                    if (datetime.Hour == 7 && datetime.Hour < 9 && datetime.Minute <= 59)
                    {
                        curClass.Text = "COSC 60: DIGITAL LOGICC  DESIGN (LECTURE)";
                        curTime.Text = "7:00AM - 9:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else if (datetime.Hour == 9 && datetime.Hour < 11 && datetime.Minute <= 59)
                    {
                        curClass.Text = "COSC 60: DIGITAL LOGIC DESIGN (LABORATORY)";
                        curTime.Text = "9:00AM - 11:00AM";
                        curStatus.Text = "ONGOING";
                    }
                    else
                    {
                        curClass.Text = "NO CLASSES";
                    }
                    break;

                case DayOfWeek.Sunday:
                    curClass.Text = "NO CLASSES";
                    curTime.Text = "NO CLASSES";
                    curStatus.Text = "NO CLASSES";
                    break;
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
            course();
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
           new Logout().ShowDialog();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sbStudentsBtn_Click(object sender, EventArgs e)
        {
            new Students().Show();
            Hide();

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

        private void sbTogBtn_Click(object sender, EventArgs e)
        {
            if(!sidePanel.Visible)
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

        private void spBackBtn_Click(object sender, EventArgs e)
        {
            if (sidePanel.Visible)
            {
                sidePanel.Visible = false;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Enabled = true;
                }

                infoField.Focus();
            }
        }
    }
}
