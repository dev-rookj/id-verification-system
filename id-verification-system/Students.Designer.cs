namespace id_verification_system
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.clockIcon = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.sbBG = new System.Windows.Forms.PictureBox();
            this.sbTogBtn = new System.Windows.Forms.PictureBox();
            this.sbDashboardBtn = new System.Windows.Forms.PictureBox();
            this.sbStudentsBtn = new System.Windows.Forms.PictureBox();
            this.sbCoursesBtn = new System.Windows.Forms.PictureBox();
            this.sbRecordsBtn = new System.Windows.Forms.PictureBox();
            this.sbLogoutBtn = new System.Windows.Forms.PictureBox();
            this.listHeader = new System.Windows.Forms.Label();
            this.listBG = new System.Windows.Forms.PictureBox();
            this.enrollBtn = new System.Windows.Forms.PictureBox();
            this.listMenu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // clockIcon
            // 
            this.clockIcon.Image = ((System.Drawing.Image)(resources.GetObject("clockIcon.Image")));
            this.clockIcon.Location = new System.Drawing.Point(89, 13);
            this.clockIcon.Name = "clockIcon";
            this.clockIcon.Size = new System.Drawing.Size(48, 44);
            this.clockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clockIcon.TabIndex = 0;
            this.clockIcon.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.timeLabel.Location = new System.Drawing.Point(143, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 43);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00PM";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // sbBG
            // 
            this.sbBG.Image = ((System.Drawing.Image)(resources.GetObject("sbBG.Image")));
            this.sbBG.Location = new System.Drawing.Point(0, 1);
            this.sbBG.Name = "sbBG";
            this.sbBG.Size = new System.Drawing.Size(71, 681);
            this.sbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbBG.TabIndex = 19;
            this.sbBG.TabStop = false;
            // 
            // sbTogBtn
            // 
            this.sbTogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbTogBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbTogBtn.Image")));
            this.sbTogBtn.Location = new System.Drawing.Point(10, 18);
            this.sbTogBtn.Name = "sbTogBtn";
            this.sbTogBtn.Size = new System.Drawing.Size(50, 50);
            this.sbTogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbTogBtn.TabIndex = 20;
            this.sbTogBtn.TabStop = false;
            // 
            // sbDashboardBtn
            // 
            this.sbDashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbDashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbDashboardBtn.Image")));
            this.sbDashboardBtn.Location = new System.Drawing.Point(10, 121);
            this.sbDashboardBtn.Name = "sbDashboardBtn";
            this.sbDashboardBtn.Size = new System.Drawing.Size(50, 50);
            this.sbDashboardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbDashboardBtn.TabIndex = 21;
            this.sbDashboardBtn.TabStop = false;
            this.sbDashboardBtn.Click += new System.EventHandler(this.sbDashboardBtn_Click);
            // 
            // sbStudentsBtn
            // 
            this.sbStudentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbStudentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbStudentsBtn.Image")));
            this.sbStudentsBtn.Location = new System.Drawing.Point(10, 188);
            this.sbStudentsBtn.Name = "sbStudentsBtn";
            this.sbStudentsBtn.Size = new System.Drawing.Size(50, 50);
            this.sbStudentsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbStudentsBtn.TabIndex = 22;
            this.sbStudentsBtn.TabStop = false;
            // 
            // sbCoursesBtn
            // 
            this.sbCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbCoursesBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbCoursesBtn.Image")));
            this.sbCoursesBtn.Location = new System.Drawing.Point(10, 255);
            this.sbCoursesBtn.Name = "sbCoursesBtn";
            this.sbCoursesBtn.Size = new System.Drawing.Size(50, 50);
            this.sbCoursesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbCoursesBtn.TabIndex = 23;
            this.sbCoursesBtn.TabStop = false;
            // 
            // sbRecordsBtn
            // 
            this.sbRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbRecordsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbRecordsBtn.Image")));
            this.sbRecordsBtn.Location = new System.Drawing.Point(10, 324);
            this.sbRecordsBtn.Name = "sbRecordsBtn";
            this.sbRecordsBtn.Size = new System.Drawing.Size(50, 50);
            this.sbRecordsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbRecordsBtn.TabIndex = 24;
            this.sbRecordsBtn.TabStop = false;
            // 
            // sbLogoutBtn
            // 
            this.sbLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.sbLogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("sbLogoutBtn.Image")));
            this.sbLogoutBtn.Location = new System.Drawing.Point(10, 619);
            this.sbLogoutBtn.Name = "sbLogoutBtn";
            this.sbLogoutBtn.Size = new System.Drawing.Size(50, 50);
            this.sbLogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbLogoutBtn.TabIndex = 25;
            this.sbLogoutBtn.TabStop = false;
            this.sbLogoutBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listHeader
            // 
            this.listHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHeader.Location = new System.Drawing.Point(401, 29);
            this.listHeader.Name = "listHeader";
            this.listHeader.Size = new System.Drawing.Size(492, 50);
            this.listHeader.TabIndex = 26;
            this.listHeader.Text = "STUDENTS LIST";
            this.listHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBG
            // 
            this.listBG.Image = ((System.Drawing.Image)(resources.GetObject("listBG.Image")));
            this.listBG.Location = new System.Drawing.Point(89, 82);
            this.listBG.Name = "listBG";
            this.listBG.Size = new System.Drawing.Size(1163, 587);
            this.listBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.listBG.TabIndex = 27;
            this.listBG.TabStop = false;
            // 
            // enrollBtn
            // 
            this.enrollBtn.Image = ((System.Drawing.Image)(resources.GetObject("enrollBtn.Image")));
            this.enrollBtn.Location = new System.Drawing.Point(1152, 18);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(100, 50);
            this.enrollBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enrollBtn.TabIndex = 28;
            this.enrollBtn.TabStop = false;
            // 
            // listMenu
            // 
            this.listMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.listMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.listMenu.ForeColor = System.Drawing.Color.White;
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 35;
            this.listMenu.Items.AddRange(new object[] {
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur",
            "Abrenica, Aljur"});
            this.listMenu.Location = new System.Drawing.Point(114, 95);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(1112, 560);
            this.listMenu.TabIndex = 29;
            this.listMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listMenu_DrawItem);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listHeader);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.listBG);
            this.Controls.Add(this.sbTogBtn);
            this.Controls.Add(this.sbDashboardBtn);
            this.Controls.Add(this.sbStudentsBtn);
            this.Controls.Add(this.sbCoursesBtn);
            this.Controls.Add(this.sbRecordsBtn);
            this.Controls.Add(this.sbLogoutBtn);
            this.Controls.Add(this.sbBG);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clockIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Students";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Students_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clockIcon;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox sbBG;
        private System.Windows.Forms.PictureBox sbTogBtn;
        private System.Windows.Forms.PictureBox sbDashboardBtn;
        private System.Windows.Forms.PictureBox sbStudentsBtn;
        private System.Windows.Forms.PictureBox sbCoursesBtn;
        private System.Windows.Forms.PictureBox sbRecordsBtn;
        private System.Windows.Forms.PictureBox sbLogoutBtn;
        private System.Windows.Forms.Label listHeader;
        private System.Windows.Forms.PictureBox listBG;
        private System.Windows.Forms.PictureBox enrollBtn;
        private System.Windows.Forms.ListBox listMenu;
    }
}

