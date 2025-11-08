using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace id_verification_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kupal = new Form2();
            kupal.Show();
            Hide();

            kupal.kups = "TARANTADOOOO";
            kupal.UpdateLabel("UHULOLLL");
            kupal.Show();
        }
    }
}
