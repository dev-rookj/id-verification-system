namespace id_verification_system
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.header = new System.Windows.Forms.PictureBox();
            this.userBG = new System.Windows.Forms.PictureBox();
            this.passBG = new System.Windows.Forms.PictureBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.PictureBox();
            this.loginStatus = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Image = ((System.Drawing.Image)(resources.GetObject("header.Image")));
            this.header.Location = new System.Drawing.Point(293, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(524, 137);
            this.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header.TabIndex = 2;
            this.header.TabStop = false;
            // 
            // userBG
            // 
            this.userBG.Image = ((System.Drawing.Image)(resources.GetObject("userBG.Image")));
            this.userBG.Location = new System.Drawing.Point(371, 177);
            this.userBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBG.Name = "userBG";
            this.userBG.Size = new System.Drawing.Size(632, 73);
            this.userBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userBG.TabIndex = 3;
            this.userBG.TabStop = false;
            // 
            // passBG
            // 
            this.passBG.Image = ((System.Drawing.Image)(resources.GetObject("passBG.Image")));
            this.passBG.Location = new System.Drawing.Point(371, 282);
            this.passBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBG.Name = "passBG";
            this.passBG.Size = new System.Drawing.Size(632, 73);
            this.passBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passBG.TabIndex = 4;
            this.passBG.TabStop = false;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.userLabel.Location = new System.Drawing.Point(105, 177);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(257, 73);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Username:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.passLabel.Location = new System.Drawing.Point(105, 282);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(257, 73);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Password:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.Location = new System.Drawing.Point(447, 414);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(220, 80);
            this.loginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBtn.TabIndex = 7;
            this.loginBtn.TabStop = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseDown);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            this.loginBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseUp);
            // 
            // loginStatus
            // 
            this.loginStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginStatus.Location = new System.Drawing.Point(16, 362);
            this.loginStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(1099, 46);
            this.loginStatus.TabIndex = 8;
            this.loginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(167)))));
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.userField.ForeColor = System.Drawing.Color.White;
            this.userField.Location = new System.Drawing.Point(389, 194);
            this.userField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(593, 34);
            this.userField.TabIndex = 9;
            this.userField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userField_KeyDown);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(167)))));
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passField.ForeColor = System.Drawing.Color.White;
            this.passField.Location = new System.Drawing.Point(389, 299);
            this.passField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(593, 34);
            this.passField.TabIndex = 10;
            this.passField.UseSystemPasswordChar = true;
            this.passField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passField_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1131, 582);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginStatus);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.userBG);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.passBG);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox userBG;
        private System.Windows.Forms.PictureBox passBG;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.PictureBox loginBtn;
        private System.Windows.Forms.Label loginStatus;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
    }
}

