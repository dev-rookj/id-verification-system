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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoPhoto = new System.Windows.Forms.PictureBox();
            this.infoStudNum = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.infoAge = new System.Windows.Forms.Label();
            this.infoEdit = new System.Windows.Forms.PictureBox();
            this.infoDrop = new System.Windows.Forms.PictureBox();
            this.recordsTable = new System.Windows.Forms.DataGridView();
            this.infoClose = new System.Windows.Forms.Label();
            this.infoRecentLabel = new System.Windows.Forms.Label();
            this.infoFilterLabel = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.infoPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFilterLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Location = new System.Drawing.Point(16, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(917, 40);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "STUDENT INFORMATION";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPhoto
            // 
            this.infoPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPhoto.Image = ((System.Drawing.Image)(resources.GetObject("infoPhoto.Image")));
            this.infoPhoto.Location = new System.Drawing.Point(19, 61);
            this.infoPhoto.Name = "infoPhoto";
            this.infoPhoto.Size = new System.Drawing.Size(100, 100);
            this.infoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPhoto.TabIndex = 1;
            this.infoPhoto.TabStop = false;
            // 
            // infoStudNum
            // 
            this.infoStudNum.Font = new System.Drawing.Font("Arial", 14F);
            this.infoStudNum.Location = new System.Drawing.Point(125, 61);
            this.infoStudNum.Name = "infoStudNum";
            this.infoStudNum.Size = new System.Drawing.Size(262, 40);
            this.infoStudNum.TabIndex = 2;
            this.infoStudNum.Text = "Student No.: ";
            this.infoStudNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoName
            // 
            this.infoName.Font = new System.Drawing.Font("Arial", 14F);
            this.infoName.Location = new System.Drawing.Point(125, 101);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(303, 40);
            this.infoName.TabIndex = 3;
            this.infoName.Text = "Name: ";
            this.infoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoAge
            // 
            this.infoAge.Font = new System.Drawing.Font("Arial", 14F);
            this.infoAge.Location = new System.Drawing.Point(434, 101);
            this.infoAge.Name = "infoAge";
            this.infoAge.Size = new System.Drawing.Size(303, 40);
            this.infoAge.TabIndex = 4;
            this.infoAge.Text = "Age:";
            this.infoAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoEdit
            // 
            this.infoEdit.Image = ((System.Drawing.Image)(resources.GetObject("infoEdit.Image")));
            this.infoEdit.Location = new System.Drawing.Point(666, 572);
            this.infoEdit.Name = "infoEdit";
            this.infoEdit.Size = new System.Drawing.Size(120, 50);
            this.infoEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoEdit.TabIndex = 6;
            this.infoEdit.TabStop = false;
            this.infoEdit.Click += new System.EventHandler(this.infoEdit_Click);
            // 
            // infoDrop
            // 
            this.infoDrop.Image = ((System.Drawing.Image)(resources.GetObject("infoDrop.Image")));
            this.infoDrop.Location = new System.Drawing.Point(809, 572);
            this.infoDrop.Name = "infoDrop";
            this.infoDrop.Size = new System.Drawing.Size(120, 50);
            this.infoDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoDrop.TabIndex = 7;
            this.infoDrop.TabStop = false;
            this.infoDrop.Click += new System.EventHandler(this.infoDrop_Click);
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
            this.recordsTable.Location = new System.Drawing.Point(19, 221);
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
            this.recordsTable.RowHeadersWidth = 51;
            this.recordsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recordsTable.RowTemplate.Height = 26;
            this.recordsTable.Size = new System.Drawing.Size(910, 345);
            this.recordsTable.TabIndex = 28;
            // 
            // infoClose
            // 
            this.infoClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.infoClose.ForeColor = System.Drawing.Color.Red;
            this.infoClose.Location = new System.Drawing.Point(902, 9);
            this.infoClose.Name = "infoClose";
            this.infoClose.Size = new System.Drawing.Size(31, 26);
            this.infoClose.TabIndex = 29;
            this.infoClose.Text = "X";
            this.infoClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoClose.Click += new System.EventHandler(this.infoClose_Click);
            // 
            // infoRecentLabel
            // 
            this.infoRecentLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.infoRecentLabel.Location = new System.Drawing.Point(12, 178);
            this.infoRecentLabel.Name = "infoRecentLabel";
            this.infoRecentLabel.Size = new System.Drawing.Size(215, 40);
            this.infoRecentLabel.TabIndex = 30;
            this.infoRecentLabel.Text = "Most recent logs";
            this.infoRecentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoFilterLabel
            // 
            this.infoFilterLabel.Image = ((System.Drawing.Image)(resources.GetObject("infoFilterLabel.Image")));
            this.infoFilterLabel.Location = new System.Drawing.Point(233, 176);
            this.infoFilterLabel.Name = "infoFilterLabel";
            this.infoFilterLabel.Size = new System.Drawing.Size(177, 39);
            this.infoFilterLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoFilterLabel.TabIndex = 31;
            this.infoFilterLabel.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.comboBox1.Font = new System.Drawing.Font("Arial", 19F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nigga",
            "nigga",
            "nigga"});
            this.comboBox1.Location = new System.Drawing.Point(417, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(512, 36);
            this.comboBox1.TabIndex = 32;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "DATE";
            this.DateCol.MinimumWidth = 6;
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateCol.Width = 125;
            // 
            // TimeCol
            // 
            this.TimeCol.HeaderText = "TIME";
            this.TimeCol.MinimumWidth = 6;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 125;
            // 
            // CourseNameCol
            // 
            this.CourseNameCol.HeaderText = "COURSE NAME";
            this.CourseNameCol.MinimumWidth = 6;
            this.CourseNameCol.Name = "CourseNameCol";
            this.CourseNameCol.ReadOnly = true;
            this.CourseNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNameCol.Width = 500;
            // 
            // RemarksCol
            // 
            this.RemarksCol.HeaderText = "REMARKS";
            this.RemarksCol.MinimumWidth = 6;
            this.RemarksCol.Name = "RemarksCol";
            this.RemarksCol.ReadOnly = true;
            this.RemarksCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemarksCol.Width = 158;
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(945, 635);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.infoFilterLabel);
            this.Controls.Add(this.infoRecentLabel);
            this.Controls.Add(this.infoClose);
            this.Controls.Add(this.recordsTable);
            this.Controls.Add(this.infoDrop);
            this.Controls.Add(this.infoEdit);
            this.Controls.Add(this.infoStudNum);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.infoAge);
            this.Controls.Add(this.infoPhoto);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.infoDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFilterLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox infoEdit;
        public System.Windows.Forms.PictureBox infoPhoto;
        public System.Windows.Forms.Label infoStudNum;
        public System.Windows.Forms.Label infoName;
        public System.Windows.Forms.Label infoAge;
        private System.Windows.Forms.PictureBox infoDrop;
        private System.Windows.Forms.DataGridView recordsTable;
        private System.Windows.Forms.Label infoClose;
        private System.Windows.Forms.Label infoRecentLabel;
        private System.Windows.Forms.PictureBox infoFilterLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksCol;
    }
}

