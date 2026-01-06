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
using static id_verification_system.Courses;

namespace id_verification_system
{
    public partial class Course_View : Form
    {
        private readonly string currentCourseCode;
        private readonly string currentCourseName;

        public Course_View(string courseCode, string courseName)
        {
            InitializeComponent();
            currentCourseCode = courseCode;
            currentCourseName = courseName;

            LoadCourseInfo(currentCourseCode);
            this.FormClosing += Course_View_FormClosing; // optional auto-refresh hook
        }

        private void LoadCourseInfo(string code)
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
                            string name = reader.GetString(0);
                            string instructor = reader.GetString(1);
                            string start24 = reader.GetString(2);
                            string end24 = reader.GetString(3);
                            string day = reader.GetString(4);

                            DateTime s = DateTime.ParseExact(start24, "HH:mm", null);
                            DateTime e = DateTime.ParseExact(end24, "HH:mm", null);

                            courseCode.Text = "Course Code: " + code;
                            courseName.Text = "Course Name: " + name;
                            courseInstructor.Text = "Instructor: " + instructor;
                            courseSchedule.Text = $"Schedule: {s:hh\\:mm tt} - {e:hh\\:mm tt} (every {day})";
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void courseTime_Click(object sender, EventArgs e)
        {

        }

        private void courseEdit_Click(object sender, EventArgs e)
        {
            using (var editForm = new Edit_Course(currentCourseCode))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCourseInfo(currentCourseCode); // refresh details
                    this.DialogResult = DialogResult.OK; // signal parent refresh
                }
            }
        }

        private void courseDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this course?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            try
            {
                string connString = "Data Source=systemDB.db;";
                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string q = "DELETE FROM courses WHERE course_code=@Code";
                    using (var cmd = new SQLiteCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", currentCourseCode);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; // trigger parent refresh
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No course found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Course_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void courseClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
