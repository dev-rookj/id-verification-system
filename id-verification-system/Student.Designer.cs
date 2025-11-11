namespace id_verification_system
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.clockIcon = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.header = new System.Windows.Forms.PictureBox();
            this.sbBG = new System.Windows.Forms.PictureBox();
            this.sbTogBtn = new System.Windows.Forms.PictureBox();
            this.sbDashboardBtn = new System.Windows.Forms.PictureBox();
            this.sbStudentsBtn = new System.Windows.Forms.PictureBox();
            this.sbCoursesBtn = new System.Windows.Forms.PictureBox();
            this.sbRecordsBtn = new System.Windows.Forms.PictureBox();
            this.sbLogoutBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // clockIcon
            // 
            this.clockIcon.Image = ((System.Drawing.Image)(resources.GetObject("clockIcon.Image")));
            this.clockIcon.Location = new System.Drawing.Point(119, 16);
            this.clockIcon.Margin = new System.Windows.Forms.Padding(4);
            this.clockIcon.Name = "clockIcon";
            this.clockIcon.Size = new System.Drawing.Size(64, 54);
            this.clockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clockIcon.TabIndex = 0;
            this.clockIcon.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.timeLabel.Location = new System.Drawing.Point(191, 17);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(267, 53);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00PM";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // header
            // 
            this.header.Image = ((System.Drawing.Image)(resources.GetObject("header.Image")));
            this.header.Location = new System.Drawing.Point(465, 17);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(760, 182);
            this.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header.TabIndex = 2;
            this.header.TabStop = false;
            // 
            // sbBG
            // 
            this.sbBG.Image = ((System.Drawing.Image)(resources.GetObject("sbBG.Image")));
            this.sbBG.Location = new System.Drawing.Point(0, 1);
            this.sbBG.Margin = new System.Windows.Forms.Padding(4);
            this.sbBG.Name = "sbBG";
            this.sbBG.Size = new System.Drawing.Size(95, 838);
            this.sbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbBG.TabIndex = 19;
            this.sbBG.TabStop = false;
            // 
            // sbTogBtn
            // 
            this.sbTogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbTogBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbTogBtn.Image")));
            this.sbTogBtn.Location = new System.Drawing.Point(13, 22);
            this.sbTogBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbTogBtn.Name = "sbTogBtn";
            this.sbTogBtn.Size = new System.Drawing.Size(67, 62);
            this.sbTogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbTogBtn.TabIndex = 20;
            this.sbTogBtn.TabStop = false;
            // 
            // sbDashboardBtn
            // 
            this.sbDashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbDashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbDashboardBtn.Image")));
            this.sbDashboardBtn.Location = new System.Drawing.Point(13, 149);
            this.sbDashboardBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbDashboardBtn.Name = "sbDashboardBtn";
            this.sbDashboardBtn.Size = new System.Drawing.Size(67, 62);
            this.sbDashboardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbDashboardBtn.TabIndex = 21;
            this.sbDashboardBtn.TabStop = false;
            // 
            // sbStudentsBtn
            // 
            this.sbStudentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbStudentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbStudentsBtn.Image")));
            this.sbStudentsBtn.Location = new System.Drawing.Point(13, 231);
            this.sbStudentsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbStudentsBtn.Name = "sbStudentsBtn";
            this.sbStudentsBtn.Size = new System.Drawing.Size(67, 62);
            this.sbStudentsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbStudentsBtn.TabIndex = 22;
            this.sbStudentsBtn.TabStop = false;
            // 
            // sbCoursesBtn
            // 
            this.sbCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbCoursesBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbCoursesBtn.Image")));
            this.sbCoursesBtn.Location = new System.Drawing.Point(13, 314);
            this.sbCoursesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbCoursesBtn.Name = "sbCoursesBtn";
            this.sbCoursesBtn.Size = new System.Drawing.Size(67, 62);
            this.sbCoursesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbCoursesBtn.TabIndex = 23;
            this.sbCoursesBtn.TabStop = false;
            // 
            // sbRecordsBtn
            // 
            this.sbRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbRecordsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbRecordsBtn.Image")));
            this.sbRecordsBtn.Location = new System.Drawing.Point(13, 399);
            this.sbRecordsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbRecordsBtn.Name = "sbRecordsBtn";
            this.sbRecordsBtn.Size = new System.Drawing.Size(67, 62);
            this.sbRecordsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbRecordsBtn.TabIndex = 24;
            this.sbRecordsBtn.TabStop = false;
            // 
            // sbLogoutBtn
            // 
            this.sbLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbLogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbLogoutBtn.Image")));
            this.sbLogoutBtn.Location = new System.Drawing.Point(13, 762);
            this.sbLogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbLogoutBtn.Name = "sbLogoutBtn";
            this.sbLogoutBtn.Size = new System.Drawing.Size(67, 62);
            this.sbLogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbLogoutBtn.TabIndex = 25;
            this.sbLogoutBtn.TabStop = false;
            this.sbLogoutBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.sbTogBtn);
            this.Controls.Add(this.sbDashboardBtn);
            this.Controls.Add(this.sbStudentsBtn);
            this.Controls.Add(this.sbCoursesBtn);
            this.Controls.Add(this.sbRecordsBtn);
            this.Controls.Add(this.sbLogoutBtn);
            this.Controls.Add(this.sbBG);
            this.Controls.Add(this.header);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clockIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clockIcon;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox sbBG;
        private System.Windows.Forms.PictureBox sbTogBtn;
        private System.Windows.Forms.PictureBox sbDashboardBtn;
        private System.Windows.Forms.PictureBox sbStudentsBtn;
        private System.Windows.Forms.PictureBox sbCoursesBtn;
        private System.Windows.Forms.PictureBox sbRecordsBtn;
        private System.Windows.Forms.PictureBox sbLogoutBtn;
    }
}

