using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static id_verification_system.Courses;

namespace id_verification_system
{
    public partial class Edit_Course : Form
    {
        private Course _courseToEdit;
        public Edit_Course(Course course)
        {
            InitializeComponent();

            _courseToEdit = course;

            // Load existing values to TextBoxes
            courseName.Text = _courseToEdit.courseName;
            insName.Text = _courseToEdit.insName;
            timeSlot.Text = _courseToEdit.timeSlot;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseName.Text) ||
        string.IsNullOrWhiteSpace(insName.Text) ||
        string.IsNullOrWhiteSpace(timeSlot.Text))
            {
                MessageBox.Show("Please fill up all fields.");
                return;
            }

            // Update existing course
            _courseToEdit.courseName = courseName.Text;
            _courseToEdit.insName = insName.Text;
            _courseToEdit.timeSlot = timeSlot.Text;

            MessageBox.Show("Course updated successfully!");
            this.Close();
        }
    }
}
