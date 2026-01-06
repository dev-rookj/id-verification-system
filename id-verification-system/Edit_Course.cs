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
    public partial class Edit_Course : Form
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

        private readonly int currentCourseId;

        public Edit_Course(int courseId)
        {
            InitializeComponent();
            currentCourseId = courseId;

            cSchedType.Items.AddRange(new[] { "lecture", "laboratory" });
            cSchedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cSchedType.Visible = false;

            cIsMajorSubject.CheckedChanged += (s, e) =>
            {
                cSchedType.Visible = cIsMajorSubject.Checked;
            };

            LoadCourse(currentCourseId);
        }

        private void LoadCourse(int id)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"SELECT course_code, course_name, instructor, start_time, end_time, day_of_the_week, major_subject, sched_type
                     FROM courses WHERE course_id=@Id";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cCourseCode.Text = reader.GetString(0);
                            cCourseName.Text = reader.GetString(1);
                            cInstructor.Text = reader.GetString(2);

                            DateTime s = DateTime.ParseExact(reader.GetString(3), "HH:mm", null);
                            DateTime e = DateTime.ParseExact(reader.GetString(4), "HH:mm", null);
                            cStart.Text = s.ToString("hh:mm tt");
                            cEnd.Text = e.ToString("hh:mm tt");

                            cDOTW.SelectedItem = reader.GetString(5);

                            bool isMajor = reader.GetBoolean(6);
                            cIsMajorSubject.Checked = isMajor;
                            cSchedType.Visible = isMajor;
                            if (isMajor && !reader.IsDBNull(7))
                                cSchedType.SelectedItem = reader.GetString(7);
                        }
                    }
                }
            }
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
                string q = @"UPDATE courses
                     SET course_code=@Code,
                         course_name=@Name,
                         instructor=@Instructor,
                         start_time=@Start,
                         end_time=@End,
                         day_of_the_week=@Day,
                         major_subject=@Major,
                         sched_type=@SchedType
                     WHERE course_id=@Id";
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
                    cmd.Parameters.AddWithValue("@Id", currentCourseId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Course updated successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No course found to update.");
                    }
                }
            }
        }


        private void cIsMajorSubject_CheckedChanged(object sender, EventArgs e)
        {
            cSchedType.Visible = cIsMajorSubject.Checked;
        }
    }
}


