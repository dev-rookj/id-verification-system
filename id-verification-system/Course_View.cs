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
    public partial class Course_View : Form
    {

        private Course _selectedCourse;
        public Course_View(Course selectedCourse)
        {
            InitializeComponent();
            _selectedCourse = selectedCourse;

            label1.Text = _selectedCourse.courseName;
            label2.Text = _selectedCourse.insName;
            label3.Text = _selectedCourse.timeSlot;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_selectedCourse == null) return; // _selectedCourse = Course object na nasa Course_View

            Edit_Course editForm = new Edit_Course(_selectedCourse);
            editForm.ShowDialog();

            // OPTIONAL: Refresh labels sa Course_View after edit
            label1.Text = _selectedCourse.courseName;
            label2.Text = _selectedCourse.insName;
            label3.Text = _selectedCourse.timeSlot;
        }

        private void courseTime_Click(object sender, EventArgs e)
        {

        }
    }
}
