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
    public partial class Add_Course : Form
    {
        // Accepts "hh:mm AM/PM" and returns "HH:mm" for DB storage.
        public static string To24Hour(string input)
        {
            if (DateTime.TryParseExact(input.Trim(),
                new[] { "h:mm tt", "hh:mm tt" },
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime dt))
            {
                return dt.ToString("HH:mm");
            }
            throw new FormatException("Invalid time format. Use HH:MM AM/PM.");
        }

        public static bool IsEndAfterStart(string start24, string end24)
        {
            TimeSpan s = TimeSpan.Parse(start24);
            TimeSpan e = TimeSpan.Parse(end24);
            return e > s;
        }
        public static bool IsValidAmPm(string masked)
        {
            if (string.IsNullOrWhiteSpace(masked) || masked.Length < 2) return false;
            string suffix = masked.Substring(masked.Length - 2);
            return suffix == "AM" || suffix == "PM";
        }

        public Add_Course()
        {
            InitializeComponent();

            cStart.ValidatingType = typeof(DateTime);
            cEnd.ValidatingType = typeof(DateTime);

            cSchedType.Visible = cIsMajorSubject.Checked;
        }

        private bool CourseCodeExists(string code)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = "SELECT COUNT(*) FROM courses WHERE course_code=@Code";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", code);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void cSave_Click(object sender, EventArgs e)
        {
            string code = cCourseCode.Text.Trim();
            string name = cCourseName.Text.Trim();
            string instructor = cInstructor.Text.Trim();
            string startRaw = cStart.Text.Trim();
            string endRaw = cEnd.Text.Trim();
            string day = cDOTW.SelectedItem as string;
            bool isMajor = cIsMajorSubject.Checked;
            string schedType = isMajor ? cSchedType.SelectedItem?.ToString() : null;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(instructor) || string.IsNullOrWhiteSpace(day))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (isMajor && string.IsNullOrEmpty(schedType))
            {
                MessageBox.Show("Select Lecture or Laboratory for major subjects.");
                return;
            }

            if (!CourseUtils.IsValidAmPm(startRaw) || !CourseUtils.IsValidAmPm(endRaw))
            {
                MessageBox.Show("Time must end with AM or PM.");
                return;
            }

            string start24 = CourseUtils.To24Hour(startRaw);
            string end24 = CourseUtils.To24Hour(endRaw);

            if (start24 == end24 || !CourseUtils.IsEndAfterStart(start24, end24))
            {
                MessageBox.Show("Invalid schedule times.");
                return;
            }

            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"INSERT INTO courses
            (course_code, course_name, instructor, start_time, end_time, day_of_the_week, major_subject, sched_type)
            VALUES (@Code, @Name, @Instructor, @Start, @End, @Day, @Major, @SchedType)";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", code);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Instructor", instructor);
                    cmd.Parameters.AddWithValue("@Start", start24);
                    cmd.Parameters.AddWithValue("@End", end24);
                    cmd.Parameters.AddWithValue("@Day", day);
                    cmd.Parameters.AddWithValue("@Major", isMajor ? 1 : 0);
                    cmd.Parameters.AddWithValue("@SchedType", schedType);

                    cmd.ExecuteNonQuery();
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cIsMajorSubject_CheckedChanged(object sender, EventArgs e)
        {
            cSchedType.Visible = cIsMajorSubject.Checked;
        }
    }
}


