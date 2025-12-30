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
    public partial class Student_View : Form
    {
        public Student_View()
        {
            InitializeComponent();
        }

        private void infoEdit_Click(object sender, EventArgs e)
        {
            new Edit_Student().ShowDialog();
        }
    }
}
