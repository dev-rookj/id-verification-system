using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace id_verification_system
{
    public partial class Student_View : Form
    {
        Students students = new Students();
        private string currentStudentId;
        private string currentStudentName;

        public Student_View(string id, string name)
        {
            InitializeComponent();
            currentStudentId = id;
            currentStudentName = name;

            // Show info on screen
            infoStudNum.Text = id;
            infoName.Text = name;
        }

        public void LoadStudentInfo(string studentId)
        {
            string connString = "Data Source=systemDB.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                string query = "SELECT student_id, name, age, photo_directory FROM students WHERE student_id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assign values to labels
                            infoStudNum.Text = "Student Number: " + reader["student_id"].ToString();
                            infoName.Text = "Name: " + reader["name"].ToString();
                            infoAge.Text = "Age: " + reader["age"].ToString();

                            // Load photo into PictureBox
                            string photoPath = reader["photo_directory"].ToString();
                            if (File.Exists(photoPath))
                            {
                                infoPhoto.Image = Image.FromFile(photoPath);
                                infoPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            else
                            {
                                infoPhoto.Image = null; // or set a placeholder image
                            }
                        }
                        else
                        {
                            MessageBox.Show("No student found with ID " + studentId);
                        }
                    }
                }
            }
        }

        private void DropStudent()
        {
            if (string.IsNullOrEmpty(currentStudentId))
            {
                MessageBox.Show("No student selected to drop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to drop this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                string connString = "Data Source=systemDB.db;";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM students WHERE student_id = @Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentStudentId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            if (infoPhoto.Image != null)
                            {
                                infoPhoto.Image.Dispose(); // releases the file lock
                                infoPhoto.Image = null;    // clears the reference
                            }
                            // Delete associated photo file
                            string photoPath = Path.Combine(Application.StartupPath, "photos", $"{currentStudentId}.jpg");
                            if (File.Exists(photoPath))
                            {
                                try
                                {
                                    File.Delete(photoPath);
                                }
                                catch (Exception fileEx)
                                {
                                    MessageBox.Show($"Student record dropped, but failed to remove photo: {fileEx.Message}",
                                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            MessageBox.Show($"This student record has been dropped successfully. Click the refresh button to see the updated list.",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No record found to drop.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dropping student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoEdit_Click(object sender, EventArgs e)
        {
            new Edit_Student().ShowDialog();
        }

        private void Student_View_Load(object sender, EventArgs e)
        {
            LoadStudentInfo(currentStudentName);
        }

        private void infoDrop_Click(object sender, EventArgs e)
        {
            DropStudent();
        }
    }
}
