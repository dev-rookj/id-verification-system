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
        private string studentName;

        public Student_View(string name)
        {
            InitializeComponent();
            studentName = name;
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

        private void infoEdit_Click(object sender, EventArgs e)
        {
            new Edit_Student().ShowDialog();
        }

        private void Student_View_Load(object sender, EventArgs e)
        {
            LoadStudentInfo(studentName);
        }
    }
}
