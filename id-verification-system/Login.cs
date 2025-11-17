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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void VerifyLogin(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (userField.Text == "admin" && passField.Text == "pass")
                {
                    this.Owner.Hide();
                    Hide();
                    new Dashboard().Show();
                }
                else
                {
                    loginStatus.ForeColor = Color.Red;
                    loginStatus.Text = "Invalid credentials.";
                }
            }
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("assets/loginbtn.png");
        }

        private void loginBtn_MouseDown(object sender, MouseEventArgs e)
        {
            loginBtn.Image = Image.FromFile("assets/loginbtn-active.png");
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("assets/loginbtn-hover.png");
        }

        private void loginBtn_MouseUp(object sender, MouseEventArgs e)
        {
            loginBtn.Image = Image.FromFile("assets/loginbtn-hover.png");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userField.Text == "admin" && passField.Text == "pass")
            {
                this.Owner.Hide();
                Hide();
                new Dashboard().Show();
            }
            else
            {
                loginStatus.ForeColor = Color.Red;
                loginStatus.Text = "Invalid credentials.";
            }
        }

        private void userField_KeyDown(object sender, KeyEventArgs e)
        {
            VerifyLogin(e);
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            VerifyLogin(e);
        }
    }
}
