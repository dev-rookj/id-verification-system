namespace id_verification_system
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.recordsTable = new System.Windows.Forms.DataGridView();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).BeginInit();
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
            this.sbStudentsBtn.Click += new System.EventHandler(this.sbStudentsBtn_Click);
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
            this.sbCoursesBtn.Click += new System.EventHandler(this.sbCoursesBtn_Click);
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
            this.listHeader.Text = "RECORD LOG";
            this.listHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordsTable
            // 
            this.recordsTable.AllowUserToDeleteRows = false;
            this.recordsTable.AllowUserToResizeColumns = false;
            this.recordsTable.AllowUserToResizeRows = false;
            this.recordsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.recordsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(98)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.recordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recordsTable.ColumnHeadersHeight = 26;
            this.recordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol,
            this.TimeCol,
            this.StudentNoCol,
            this.StudentNameCol,
            this.CourseNameCol,
            this.RemarksCol});
            this.recordsTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(98)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordsTable.GridColor = System.Drawing.Color.Black;
            this.recordsTable.Location = new System.Drawing.Point(89, 94);
            this.recordsTable.Name = "recordsTable";
            this.recordsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recordsTable.RowHeadersVisible = false;
            this.recordsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recordsTable.RowTemplate.Height = 26;
            this.recordsTable.Size = new System.Drawing.Size(1163, 559);
            this.recordsTable.TabIndex = 27;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "DATE";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimeCol
            // 
            this.TimeCol.HeaderText = "TIME";
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 90;
            // 
            // StudentNoCol
            // 
            this.StudentNoCol.HeaderText = "STUDENT NO.";
            this.StudentNoCol.Name = "StudentNoCol";
            this.StudentNoCol.ReadOnly = true;
            this.StudentNoCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentNoCol.Width = 220;
            // 
            // StudentNameCol
            // 
            this.StudentNameCol.HeaderText = "STUDENT NAME";
            this.StudentNameCol.Name = "StudentNameCol";
            this.StudentNameCol.ReadOnly = true;
            this.StudentNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentNameCol.Width = 250;
            // 
            // CourseNameCol
            // 
            this.CourseNameCol.HeaderText = "COURSE NAME";
            this.CourseNameCol.Name = "CourseNameCol";
            this.CourseNameCol.ReadOnly = true;
            this.CourseNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNameCol.Width = 350;
            // 
            // RemarksCol
            // 
            this.RemarksCol.HeaderText = "REMARKS";
            this.RemarksCol.Name = "RemarksCol";
            this.RemarksCol.ReadOnly = true;
            this.RemarksCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemarksCol.Width = 130;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.recordsTable);
            this.Controls.Add(this.listHeader);
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
            this.Name = "Records";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Students_FormClosed);
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).EndInit();
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
        private System.Windows.Forms.DataGridView recordsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksCol;
    }
}

