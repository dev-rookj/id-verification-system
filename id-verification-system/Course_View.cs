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
        private readonly int currentCourseId;

        public Course_View(int courseId)
        {
            InitializeComponent();
            currentCourseId = courseId;
            LoadCourseInfo(currentCourseId);
        }

        private void LoadCourseInfo(int id)
        {
            string connString = "Data Source=systemDB.db;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string q = @"SELECT course_id, course_code, course_name, instructor, 
                            start_time, end_time, day_of_the_week, 
                            major_subject, sched_type
                     FROM courses WHERE course_id=@Id";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int courseId = reader.GetInt32(0);
                            string code = reader.GetString(1);
                            string name = reader.GetString(2);
                            string instructor = reader.GetString(3);
                            string start24 = reader.GetString(4);
                            string end24 = reader.GetString(5);
                            string day = reader.GetString(6);
                            bool isMajor = reader.GetBoolean(7);
                            string schedType = reader.IsDBNull(8) ? null : reader.GetString(8);

                            DateTime s = DateTime.ParseExact(start24, "HH:mm", null);
                            DateTime e = DateTime.ParseExact(end24, "HH:mm", null);

                            // Labels
                            courseCode.Text = $"[{courseId}] - [{code}] {name}";
                            courseInstructor.Text = "Instructor: " + instructor;
                            courseSchedule.Text = $"Schedule: {s:hh\\:mm tt} - {e:hh\\:mm tt} ({day})";
                            courseMajor.Text = $"Major Subject - {(isMajor ? "Yes" : "No")}";

                            if (isMajor && !string.IsNullOrEmpty(schedType))
                            {
                                courseSchedType.Visible = true;
                                courseSchedType.Text = $"Schedule Type - {schedType}";
                            }
                            else
                            {
                                courseSchedType.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void courseTime_Click(object sender, EventArgs e)
        {

        }

        private void courseEdit_Click(object sender, EventArgs e)
        {
            using (var editForm = new Edit_Course(currentCourseId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCourseInfo(currentCourseId); // refresh details
                    this.DialogResult = DialogResult.OK;
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
                    string q = "DELETE FROM courses WHERE course_id=@Id";
                    using (var cmd = new SQLiteCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentCourseId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
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
