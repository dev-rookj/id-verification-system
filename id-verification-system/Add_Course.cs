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
        public Add_Course()
        {
            InitializeComponent();

            cStart.ValidatingType = typeof(DateTime);
            cEnd.ValidatingType = typeof(DateTime);
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
            // Basic validations
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

            // Enforce AM/PM only
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

            if (CourseCodeExists(code))
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

            // Insert into DB
            try
            {
                string connString = "Data Source=systemDB.db;";
                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string q = @"INSERT INTO courses
                         (course_code, course_name, instructor, start_time, end_time, day_of_the_week)
                         VALUES (@Code, @Name, @Instructor, @Start, @End, @Day)";
                    using (var cmd = new SQLiteCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Instructor", instructor);
                        cmd.Parameters.AddWithValue("@Start", start24);
                        cmd.Parameters.AddWithValue("@End", end24);
                        cmd.Parameters.AddWithValue("@Day", day);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


