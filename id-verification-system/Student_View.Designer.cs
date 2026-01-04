namespace id_verification_system
{
    partial class Student_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_View));
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoPhoto = new System.Windows.Forms.PictureBox();
            this.infoStudNum = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.infoAge = new System.Windows.Forms.Label();
            this.infoEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(824, 40);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "STUDENT INFORMATION";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPhoto
            // 
            this.infoPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPhoto.Image = ((System.Drawing.Image)(resources.GetObject("infoPhoto.Image")));
            this.infoPhoto.Location = new System.Drawing.Point(19, 52);
            this.infoPhoto.Name = "infoPhoto";
            this.infoPhoto.Size = new System.Drawing.Size(100, 100);
            this.infoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPhoto.TabIndex = 1;
            this.infoPhoto.TabStop = false;
            // 
            // infoStudNum
            // 
            this.infoStudNum.Font = new System.Drawing.Font("Arial", 14F);
            this.infoStudNum.Location = new System.Drawing.Point(125, 52);
            this.infoStudNum.Name = "infoStudNum";
            this.infoStudNum.Size = new System.Drawing.Size(262, 40);
            this.infoStudNum.TabIndex = 2;
            this.infoStudNum.Text = "Student No.: ";
            this.infoStudNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoName
            // 
            this.infoName.Font = new System.Drawing.Font("Arial", 14F);
            this.infoName.Location = new System.Drawing.Point(125, 92);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(303, 40);
            this.infoName.TabIndex = 3;
            this.infoName.Text = "Name: ";
            this.infoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoAge
            // 
            this.infoAge.Font = new System.Drawing.Font("Arial", 14F);
            this.infoAge.Location = new System.Drawing.Point(434, 92);
            this.infoAge.Name = "infoAge";
            this.infoAge.Size = new System.Drawing.Size(303, 40);
            this.infoAge.TabIndex = 4;
            this.infoAge.Text = "Age:";
            this.infoAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoEdit
            // 
            this.infoEdit.Image = ((System.Drawing.Image)(resources.GetObject("infoEdit.Image")));
            this.infoEdit.Location = new System.Drawing.Point(689, 455);
            this.infoEdit.Name = "infoEdit";
            this.infoEdit.Size = new System.Drawing.Size(147, 50);
            this.infoEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoEdit.TabIndex = 6;
            this.infoEdit.TabStop = false;
            this.infoEdit.Click += new System.EventHandler(this.infoEdit_Click);
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(848, 517);
            this.Controls.Add(this.infoEdit);
            this.Controls.Add(this.infoStudNum);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.infoAge);
            this.Controls.Add(this.infoPhoto);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Student_View";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            this.Load += new System.EventHandler(this.Student_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox infoEdit;
        public System.Windows.Forms.PictureBox infoPhoto;
        public System.Windows.Forms.Label infoStudNum;
        public System.Windows.Forms.Label infoName;
        public System.Windows.Forms.Label infoAge;
    }
}

