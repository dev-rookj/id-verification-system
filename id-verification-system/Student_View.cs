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

            LoadStudentInfo(currentStudentId);

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
                            // 🔒 Release image lock early
                            if (infoPhoto.Image != null)
                            {
                                infoPhoto.Image.Dispose();
                                infoPhoto.Image = null;
                            }

                            // 🔄 Force GC to finalize any lingering image handles
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            // 🧹 Delete photo file with retry logic
                            string photoPath = Path.Combine(Application.StartupPath, "photos", $"{currentStudentId}.jpg");
                            if (File.Exists(photoPath))
                            {
                                const int maxAttempts = 3;
                                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                                {
                                    try
                                    {
                                        File.Delete(photoPath);
                                        break;
                                    }
                                    catch (IOException) when (attempt < maxAttempts)
                                    {
                                        System.Threading.Thread.Sleep(150); // wait before retry
                                    }
                                    catch (Exception fileEx)
                                    {
                                        MessageBox.Show($"Student record dropped, but failed to remove photo: {fileEx.Message}",
                                                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                    }
                                }
                            }

                            MessageBox.Show("This student record has been dropped successfully.",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
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
            // Release any lock from infoPhoto before opening Edit_Student
            if (infoPhoto.Image != null)
            {
                infoPhoto.Image.Dispose();
                infoPhoto.Image = null;
            }

            if (string.IsNullOrEmpty(currentStudentId))
            {
                MessageBox.Show("No student selected to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentAge = "";
            string photoPath = "";

            try
            {
                string connString = "Data Source=systemDB.db;";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT age, photo_directory FROM students WHERE student_id = @Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentStudentId);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                studentAge = reader["age"].ToString();
                                photoPath = reader["photo_directory"].ToString();
                            }
                        }
                    }
                }

                // Open Edit_Student form with current info
                using (Edit_Student editForm = new Edit_Student(currentStudentId, currentStudentName, studentAge, photoPath))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // If ID was changed, update currentStudentId
                        if (editForm.Tag != null)
                            currentStudentId = editForm.Tag.ToString();

                        // 🔄 Refresh student info and logs
                        LoadStudentInfo(currentStudentId);

                        // Reload updated photo safely
                        string updatedPhotoPath = Path.Combine(Application.StartupPath, $"photos\\{currentStudentId}.jpg");
                        if (File.Exists(updatedPhotoPath))
                        {
                            using (FileStream fs = new FileStream(updatedPhotoPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                            using (Image img = Image.FromStream(fs))
                            {
                                infoPhoto.Image = new Bitmap(img);
                                infoPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        else
                        {
                            infoPhoto.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Student_View_Load(object sender, EventArgs e)
        {
            LoadStudentInfo(currentStudentId);
        }

        private void infoDrop_Click(object sender, EventArgs e)
        {
            DropStudent();
        }

        private void infoClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
