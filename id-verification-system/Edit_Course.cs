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
        private string To24Hour(string input)
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

        // Ensures end is strictly after start.
        private bool IsEndAfterStart(string start24, string end24)
        {
            TimeSpan s = TimeSpan.Parse(start24);
            TimeSpan e = TimeSpan.Parse(end24);
            return e > s;
        }
        private readonly string currentCourseCode;

        public Edit_Course(string courseCode)
        {
            InitializeComponent();
            currentCourseCode = courseCode;

            LoadCourse(currentCourseCode);
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

        private void LoadCourse(string code)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"SELECT course_name, instructor, start_time, end_time, day_of_the_week
                    FROM courses WHERE course_code=@Code";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", code);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cCourseCode.Text = code;              // optionally lock editing of code
                            cCourseName.Text = reader.GetString(0);
                            cInstructor.Text = reader.GetString(1);

                            // Convert 24h to "hh:mm tt" for display in mask
                            string start24 = reader.GetString(2);
                            string end24 = reader.GetString(3);
                            DateTime s = DateTime.ParseExact(start24, "HH:mm", null);
                            DateTime e = DateTime.ParseExact(end24, "HH:mm", null);
                            cStart.Text = s.ToString("hh:mm tt").ToUpper(); // e.g., "08:30 AM"
                            cEnd.Text = e.ToString("hh:mm tt").ToUpper();

                            cDOTW.SelectedItem = reader.GetString(4);
                        }
                    }
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

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(instructor) || string.IsNullOrWhiteSpace(day))
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string startSuffix = startRaw.Substring(startRaw.Length - 2);
            string endSuffix = endRaw.Substring(endRaw.Length - 2);
            if (!("AM".Equals(startSuffix) || "PM".Equals(startSuffix)) ||
                !("AM".Equals(endSuffix) || "PM".Equals(endSuffix)))
            {
                MessageBox.Show("Time must end with AM or PM.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string start24, end24;

            try
            {
                start24 = To24Hour(startRaw);
                end24 = To24Hour(endRaw);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Only check duplicates if course code was changed
            if (!code.Equals(currentCourseCode) && CourseCodeExists(code))
            {
                MessageBox.Show("Course code already exists. Please use a unique code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Time validation
            if (start24 == end24)
            {
                MessageBox.Show("Start and end time cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsEndAfterStart(start24, end24))
            {
                MessageBox.Show("Start time must be earlier than end time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connString = "Data Source=systemDB.db;";
                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string q = @"UPDATE courses
                         SET course_name=@Name, instructor=@Instructor, start_time=@Start, end_time=@End, day_of_the_week=@Day
                         WHERE course_code=@Code";
                    using (var cmd = new SQLiteCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Instructor", instructor);
                        cmd.Parameters.AddWithValue("@Start", start24);
                        cmd.Parameters.AddWithValue("@End", end24);
                        cmd.Parameters.AddWithValue("@Day", day);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No course found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


