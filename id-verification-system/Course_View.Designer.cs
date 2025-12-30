namespace id_verification_system
{
    partial class Course_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_View));
            this.infoLabel = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.courseTime = new System.Windows.Forms.Label();
            this.courseInstructor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(16, 11);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(1099, 49);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "COURSE INFORMATION";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Arial", 18F);
            this.courseName.Location = new System.Drawing.Point(20, 150);
            this.courseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseName.Name = "courseName";
            this.courseName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.courseName.Size = new System.Drawing.Size(1095, 63);
            this.courseName.TabIndex = 2;
            this.courseName.Text = "Course Name: -";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTime
            // 
            this.courseTime.Font = new System.Drawing.Font("Arial", 18F);
            this.courseTime.Location = new System.Drawing.Point(23, 276);
            this.courseTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseTime.Name = "courseTime";
            this.courseTime.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.courseTime.Size = new System.Drawing.Size(1095, 63);
            this.courseTime.TabIndex = 3;
            this.courseTime.Text = "Time Slot: -";
            this.courseTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseTime.Click += new System.EventHandler(this.courseTime_Click);
            // 
            // courseInstructor
            // 
            this.courseInstructor.Font = new System.Drawing.Font("Arial", 18F);
            this.courseInstructor.Location = new System.Drawing.Point(18, 213);
            this.courseInstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseInstructor.Name = "courseInstructor";
            this.courseInstructor.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.courseInstructor.Size = new System.Drawing.Size(1095, 63);
            this.courseInstructor.TabIndex = 4;
            this.courseInstructor.Text = "Instructor: -";
            this.courseInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(919, 560);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Course_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseTime);
            this.Controls.Add(this.courseInstructor);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Course_View";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.Label courseName;
        public System.Windows.Forms.Label courseTime;
        public System.Windows.Forms.Label courseInstructor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}

