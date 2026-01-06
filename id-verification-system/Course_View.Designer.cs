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
            this.courseClose = new System.Windows.Forms.Label();
            this.courseDelete = new System.Windows.Forms.PictureBox();
            this.courseEdit = new System.Windows.Forms.PictureBox();
            this.courseCode = new System.Windows.Forms.Label();
            this.courseDOTW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(15, 35);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(902, 40);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "COURSE INFORMATION";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Arial", 18F);
            this.courseName.Location = new System.Drawing.Point(98, 177);
            this.courseName.Name = "courseName";
            this.courseName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseName.Size = new System.Drawing.Size(714, 51);
            this.courseName.TabIndex = 2;
            this.courseName.Text = "Course Name: -";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTime
            // 
            this.courseTime.Font = new System.Drawing.Font("Arial", 18F);
            this.courseTime.Location = new System.Drawing.Point(98, 279);
            this.courseTime.Name = "courseTime";
            this.courseTime.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseTime.Size = new System.Drawing.Size(714, 51);
            this.courseTime.TabIndex = 3;
            this.courseTime.Text = "Time Slot: -";
            this.courseTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseTime.Click += new System.EventHandler(this.courseTime_Click);
            // 
            // courseInstructor
            // 
            this.courseInstructor.Font = new System.Drawing.Font("Arial", 18F);
            this.courseInstructor.Location = new System.Drawing.Point(98, 228);
            this.courseInstructor.Name = "courseInstructor";
            this.courseInstructor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseInstructor.Size = new System.Drawing.Size(714, 51);
            this.courseInstructor.TabIndex = 4;
            this.courseInstructor.Text = "Instructor: -";
            this.courseInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseClose
            // 
            this.courseClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.courseClose.ForeColor = System.Drawing.Color.Red;
            this.courseClose.Location = new System.Drawing.Point(886, 9);
            this.courseClose.Name = "courseClose";
            this.courseClose.Size = new System.Drawing.Size(31, 26);
            this.courseClose.TabIndex = 30;
            this.courseClose.Text = "X";
            this.courseClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseDelete
            // 
            this.courseDelete.Image = ((System.Drawing.Image)(resources.GetObject("courseDelete.Image")));
            this.courseDelete.Location = new System.Drawing.Point(797, 534);
            this.courseDelete.Name = "courseDelete";
            this.courseDelete.Size = new System.Drawing.Size(120, 50);
            this.courseDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.courseDelete.TabIndex = 32;
            this.courseDelete.TabStop = false;
            // 
            // courseEdit
            // 
            this.courseEdit.Image = ((System.Drawing.Image)(resources.GetObject("courseEdit.Image")));
            this.courseEdit.Location = new System.Drawing.Point(654, 534);
            this.courseEdit.Name = "courseEdit";
            this.courseEdit.Size = new System.Drawing.Size(120, 50);
            this.courseEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.courseEdit.TabIndex = 31;
            this.courseEdit.TabStop = false;
            // 
            // courseCode
            // 
            this.courseCode.Font = new System.Drawing.Font("Arial", 18F);
            this.courseCode.Location = new System.Drawing.Point(98, 126);
            this.courseCode.Name = "courseCode";
            this.courseCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseCode.Size = new System.Drawing.Size(714, 51);
            this.courseCode.TabIndex = 33;
            this.courseCode.Text = "Course Code: -";
            this.courseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseDOTW
            // 
            this.courseDOTW.Font = new System.Drawing.Font("Arial", 18F);
            this.courseDOTW.Location = new System.Drawing.Point(98, 330);
            this.courseDOTW.Name = "courseDOTW";
            this.courseDOTW.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseDOTW.Size = new System.Drawing.Size(714, 51);
            this.courseDOTW.TabIndex = 34;
            this.courseDOTW.Text = "Day of the Week: -";
            this.courseDOTW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Course_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(929, 596);
            this.Controls.Add(this.courseDOTW);
            this.Controls.Add(this.courseCode);
            this.Controls.Add(this.courseDelete);
            this.Controls.Add(this.courseEdit);
            this.Controls.Add(this.courseClose);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseTime);
            this.Controls.Add(this.courseInstructor);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Course_View";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            ((System.ComponentModel.ISupportInitialize)(this.courseDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.Label courseName;
        public System.Windows.Forms.Label courseTime;
        public System.Windows.Forms.Label courseInstructor;
        private System.Windows.Forms.Label courseClose;
        private System.Windows.Forms.PictureBox courseDelete;
        private System.Windows.Forms.PictureBox courseEdit;
        public System.Windows.Forms.Label courseCode;
        public System.Windows.Forms.Label courseDOTW;
    }
}

