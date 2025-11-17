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
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(824, 40);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "COURSE INFORMATION";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Arial", 18F);
            this.courseName.Location = new System.Drawing.Point(15, 122);
            this.courseName.Name = "courseName";
            this.courseName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseName.Size = new System.Drawing.Size(821, 51);
            this.courseName.TabIndex = 2;
            this.courseName.Text = "Course Name: -";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTime
            // 
            this.courseTime.Font = new System.Drawing.Font("Arial", 18F);
            this.courseTime.Location = new System.Drawing.Point(15, 173);
            this.courseTime.Name = "courseTime";
            this.courseTime.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseTime.Size = new System.Drawing.Size(821, 51);
            this.courseTime.TabIndex = 3;
            this.courseTime.Text = "Time Slot: -";
            this.courseTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseInstructor
            // 
            this.courseInstructor.Font = new System.Drawing.Font("Arial", 18F);
            this.courseInstructor.Location = new System.Drawing.Point(15, 224);
            this.courseInstructor.Name = "courseInstructor";
            this.courseInstructor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseInstructor.Size = new System.Drawing.Size(821, 51);
            this.courseInstructor.TabIndex = 4;
            this.courseInstructor.Text = "Instructor: -";
            this.courseInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Course_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(848, 517);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseTime);
            this.Controls.Add(this.courseInstructor);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Course_View";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.Label courseName;
        public System.Windows.Forms.Label courseTime;
        public System.Windows.Forms.Label courseInstructor;
    }
}

