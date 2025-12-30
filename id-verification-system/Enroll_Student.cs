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
    public partial class Enroll_Student : Form
    {

        public Enroll_Student()
        {
            InitializeComponent();
        }

        private void stPhotoBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = stSelectPhoto.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = stSelectPhoto.FileName;
                stPhotoDirectory.Text = "Photo uploaded!";
            }
        }
    }
}


