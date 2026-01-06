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
    public partial class Edit_Course : Form
    {
        public Edit_Course()
        {
            InitializeComponent();

            cStart.ValidatingType = typeof(DateTime);
            cEnd.ValidatingType = typeof(DateTime);
        }
    }
}


