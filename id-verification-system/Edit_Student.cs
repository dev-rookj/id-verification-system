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
    public partial class Edit_Student : Form
    {

        public Edit_Student()
        {
            InitializeComponent();
            stName.Text = "Aljur Abrenica";
            stAge.Text = "69";
            stID.Text = "202410000";
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


