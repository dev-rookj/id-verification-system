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
    public partial class Form2 : Form
    {
        public string kups
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public void UpdateLabel(string label)
        {
            label1.Text = label;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
