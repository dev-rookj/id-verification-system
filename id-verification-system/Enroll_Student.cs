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
    public partial class Enroll_Student : Form
    {
        public Enroll_Student()
        {
            InitializeComponent();
        }
        public void InsertStudent(int studentID, string name, int age, string photodir)
        {
            string connString = "Data Source=systemDB.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                // Step 1: Insert student with explicit student_id
                string insertQuery = "INSERT INTO students (student_id, name, age) VALUES (@Id, @Name, @Age)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", studentID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.ExecuteNonQuery();
                }

                // Step 2: Clone photo into bin/photos folder with studentId as filename
                string binFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "photos");
                Directory.CreateDirectory(binFolder);

                string extension = Path.GetExtension(photodir);
                string clonedFileName = studentID + extension; // e.g., "101.jpg"
                string clonedPath = Path.Combine(binFolder, clonedFileName);

                File.Copy(photodir, clonedPath, true);

                // Step 3: Save relative path (photos\101.jpg) into DB
                string relativePath = Path.Combine("photos", clonedFileName);

                string updateQuery = "UPDATE students SET photo_directory = @Photo WHERE student_id = @Id";
                using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@Photo", relativePath);
                    updateCmd.Parameters.AddWithValue("@Id", studentID);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }

        private void stPhotoBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = stSelectPhoto.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = stSelectPhoto.FileName;
                stPhotoDirectory.Text = stSelectPhoto.FileName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(stID.Text);
            string studentName = stName.Text;
            int studentAge = int.Parse(stAge.Text);
            string studentPhoto = stSelectPhoto.FileName;

            if (string.IsNullOrWhiteSpace(stID.Text) ||
           string.IsNullOrWhiteSpace(stName.Text) ||
           string.IsNullOrWhiteSpace(stAge.Text) ||
           string.IsNullOrWhiteSpace(stPhotoDirectory.Text))
            {
                MessageBox.Show("Please fill up all fields.");
                return;
            }

            InsertStudent(studentID, studentName, studentAge, studentPhoto);
            MessageBox.Show("Student record added successfully. Click the refresh button to see the updated list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            new Students().LoadStudents();
        }
    }
}


