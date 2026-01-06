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

namespace id_verification_system
{
    public partial class Edit_Student : Form
    {
        private string currentId;
        private string currentPhotoPath;

        public Edit_Student(string id, string name, string age, string photoPath)
        {
            InitializeComponent();

            currentId = id; // original ID for lookup
            currentPhotoPath = photoPath;

            stID.Text = id; // now editable
            stName.Text = name;
            stAge.Text = age;
            stPhotoDirectory.Text = photoPath;
        }

        private void stPhotoBtn_Click(object sender, EventArgs e)
        {
            stSelectPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (stSelectPhoto.ShowDialog() == DialogResult.OK)
            {
                stPhotoDirectory.Text = stSelectPhoto.FileName;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newId = stID.Text.Trim();
            string newName = stName.Text.Trim();
            string newAge = stAge.Text.Trim();
            string selectedPhotoPath = stPhotoDirectory.Text.Trim();

            try
            {
                string photosDir = Path.Combine(Application.StartupPath, "photos");
                if (!Directory.Exists(photosDir))
                {
                    Directory.CreateDirectory(photosDir);
                }

                string oldPhotoFile = Path.Combine(photosDir, $"{currentId}.jpg");
                string newPhotoFile = Path.Combine(photosDir, $"{newId}.jpg");
                string tempPhotoFile = Path.Combine(photosDir, $"{newId}_temp.jpg");

                // Force release of any lingering file locks
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // If a new photo was selected and exists
                if (!string.IsNullOrEmpty(selectedPhotoPath) && File.Exists(selectedPhotoPath))
                {
                    // Copy selected photo to temp file first (safe copy)
                    using (FileStream sourceStream = new FileStream(selectedPhotoPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (FileStream tempStream = new FileStream(tempPhotoFile, FileMode.Create, FileAccess.Write))
                    {
                        sourceStream.CopyTo(tempStream);
                    }

                    // Delete old photo with retry logic
                    if (File.Exists(oldPhotoFile))
                    {
                        const int maxAttempts = 3;
                        for (int attempt = 1; attempt <= maxAttempts; attempt++)
                        {
                            try
                            {
                                File.Delete(oldPhotoFile);
                                break;
                            }
                            catch (IOException) when (attempt < maxAttempts)
                            {
                                System.Threading.Thread.Sleep(150);
                            }
                        }
                    }

                    // Rename temp file to final photo filename
                    File.Move(tempPhotoFile, newPhotoFile);

                    // Update photo path to relative
                    stPhotoDirectory.Text = $"photos\\{newId}.jpg";
                }

                // Update DB record
                string connString = "Data Source=systemDB.db;";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string updateQuery = @"
                UPDATE students 
                SET student_id = @NewId, name = @Name, age = @Age, photo_directory = @Photo 
                WHERE student_id = @OldId";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewId", newId);
                        cmd.Parameters.AddWithValue("@Name", newName);
                        cmd.Parameters.AddWithValue("@Age", newAge);
                        cmd.Parameters.AddWithValue("@Photo", stPhotoDirectory.Text.Trim());
                        cmd.Parameters.AddWithValue("@OldId", currentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Tag = newId;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


