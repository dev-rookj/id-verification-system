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
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
