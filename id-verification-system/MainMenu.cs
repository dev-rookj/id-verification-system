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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            time.Start();
        }

        private void UpdateCurrentClass(DateTime now)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"SELECT course_code, course_name, start_time, end_time, major_subject, sched_type
                     FROM courses
                     WHERE day_of_the_week=@Day";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Day", now.DayOfWeek.ToString());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string code = reader.GetString(0);
                            string name = reader.GetString(1);
                            string start24 = reader.GetString(2);
                            string end24 = reader.GetString(3);
                            bool isMajor = reader.GetBoolean(4);
                            string schedType = reader.IsDBNull(5) ? "" : reader.GetString(5);

                            DateTime start = DateTime.ParseExact(start24, "HH:mm", null);
                            DateTime end = DateTime.ParseExact(end24, "HH:mm", null);

                            // Show class 10 minutes before start
                            if (now >= start.AddMinutes(-10) && now <= end)
                            {
                                // curClass format: [CODE] COURSE NAME (+ indicator if major)
                                string indicator = "";
                                if (isMajor && !string.IsNullOrEmpty(schedType))
                                {
                                    indicator = schedType.Equals("lecture", StringComparison.OrdinalIgnoreCase) ? "(LEC)" : "(LAB)";
                                }
                                curClass.Text = $"[{code}] {name} {indicator}";

                                // curTime format: STARTTIME - ENDTIME
                                curTime.Text = $"{start:hh\\:mm tt} - {end:hh\\:mm tt}";

                                // curStatus: Up Next if not started yet, Ongoing if started
                                if (now < start)
                                    curStatus.Text = "UP NEXT";
                                else
                                    curStatus.Text = "ONGOING";

                                return; // stop after first match
                            }
                        }
                    }
                }
            }

            // If no class matches, clear labels
            curClass.Text = "VACANT";
            curTime.Text = "";
            curStatus.Text = "";
        }


        private void time_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timeLabel.Text = now.ToString("hh:mm:ss tt");

            UpdateCurrentClass(now);
        }

        private void infoField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string scannedId = infoField.Text.Trim();
                infoField.Clear();

                DateTime now = DateTime.Now;
                var currentClass = DashboardUtils.GetCurrentClass(now);

                if (currentClass.curClass == "No class scheduled")
                {
                    MessageBox.Show("No class is ongoing or up next.");
                    return;
                }

                string studentName = DashboardUtils.LookupStudentName(scannedId);

                // Check if student exists
                if (studentName == "Unknown Student")
                {
                    infoText.Text = "Invalid Barcode.";
                    return;
                }

                DateTime classStart = DashboardUtils.ParseStartTime(currentClass.curTime);

                RecordUtils.SaveRecord(scannedId, studentName, currentClass.curClass, now, classStart, infoText, infoReset);
            }
        }

        private void infoReset_Tick(object sender, EventArgs e)
        {
            infoText.Text = "Scan your ID...";
            infoReset.Stop();
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Owner = this;
            login.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
