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

namespace id_verification_system
{
    public partial class Add_Course : Form
    {
        public Courses.Course NewCourse { get; private set; }

        public Add_Course()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
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

            NewCourse = new Courses.Course
            {
                courseName = courseName.Text,
                insName = insName.Text,
                timeSlot = timeSlot.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    }


