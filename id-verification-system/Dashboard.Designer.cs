namespace id_verification_system
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.clockIcon = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.header = new System.Windows.Forms.PictureBox();
            this.curClassLabelBG = new System.Windows.Forms.PictureBox();
            this.curClassBG = new System.Windows.Forms.PictureBox();
            this.curClassLabel = new System.Windows.Forms.Label();
            this.curClass = new System.Windows.Forms.Label();
            this.curTimeLabelBG = new System.Windows.Forms.PictureBox();
            this.curTimeLabel = new System.Windows.Forms.Label();
            this.curTimeBG = new System.Windows.Forms.PictureBox();
            this.curTime = new System.Windows.Forms.Label();
            this.curStatusLabel = new System.Windows.Forms.Label();
            this.curStatusLabelBG = new System.Windows.Forms.PictureBox();
            this.curStatus = new System.Windows.Forms.Label();
            this.curStatusBG = new System.Windows.Forms.PictureBox();
            this.infoBG = new System.Windows.Forms.PictureBox();
            this.infoFieldBG = new System.Windows.Forms.PictureBox();
            this.infoField = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.Label();
            this.infoReset = new System.Windows.Forms.Timer(this.components);
            this.sbBG = new System.Windows.Forms.PictureBox();
            this.sbTogBtn = new System.Windows.Forms.PictureBox();
            this.sbDashboardBtn = new System.Windows.Forms.PictureBox();
            this.sbStudentsBtn = new System.Windows.Forms.PictureBox();
            this.sbCoursesBtn = new System.Windows.Forms.PictureBox();
            this.sbRecordsBtn = new System.Windows.Forms.PictureBox();
            this.sbLogoutBtn = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.spRecordsBtn = new System.Windows.Forms.PictureBox();
            this.spCoursesBtn = new System.Windows.Forms.PictureBox();
            this.spBackBtn = new System.Windows.Forms.PictureBox();
            this.spStudentBtn = new System.Windows.Forms.PictureBox();
            this.spUser = new System.Windows.Forms.Label();
            this.spDashboardBtn = new System.Windows.Forms.PictureBox();
            this.spUserIcon = new System.Windows.Forms.PictureBox();
            this.spLogo = new System.Windows.Forms.PictureBox();
            this.spContainer = new System.Windows.Forms.PictureBox();
            this.spBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClassLabelBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClassBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTimeLabelBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTimeBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curStatusLabelBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curStatusBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFieldBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRecordsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCoursesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStudentBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDashboardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBG)).BeginInit();
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
            // header
            // 
            this.header.Image = ((System.Drawing.Image)(resources.GetObject("header.Image")));
            this.header.Location = new System.Drawing.Point(349, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(570, 148);
            this.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header.TabIndex = 2;
            this.header.TabStop = false;
            // 
            // curClassLabelBG
            // 
            this.curClassLabelBG.Image = ((System.Drawing.Image)(resources.GetObject("curClassLabelBG.Image")));
            this.curClassLabelBG.Location = new System.Drawing.Point(183, 188);
            this.curClassLabelBG.Name = "curClassLabelBG";
            this.curClassLabelBG.Size = new System.Drawing.Size(224, 50);
            this.curClassLabelBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curClassLabelBG.TabIndex = 3;
            this.curClassLabelBG.TabStop = false;
            // 
            // curClassBG
            // 
            this.curClassBG.Image = ((System.Drawing.Image)(resources.GetObject("curClassBG.Image")));
            this.curClassBG.Location = new System.Drawing.Point(426, 177);
            this.curClassBG.Name = "curClassBG";
            this.curClassBG.Size = new System.Drawing.Size(729, 70);
            this.curClassBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curClassBG.TabIndex = 4;
            this.curClassBG.TabStop = false;
            // 
            // curClassLabel
            // 
            this.curClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(98)))), ((int)(((byte)(33)))));
            this.curClassLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.curClassLabel.ForeColor = System.Drawing.Color.White;
            this.curClassLabel.Location = new System.Drawing.Point(195, 194);
            this.curClassLabel.Name = "curClassLabel";
            this.curClassLabel.Size = new System.Drawing.Size(197, 36);
            this.curClassLabel.TabIndex = 5;
            this.curClassLabel.Text = "Current Class";
            this.curClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curClass
            // 
            this.curClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.curClass.Font = new System.Drawing.Font("Arial", 18F);
            this.curClass.ForeColor = System.Drawing.Color.White;
            this.curClass.Location = new System.Drawing.Point(442, 194);
            this.curClass.Name = "curClass";
            this.curClass.Size = new System.Drawing.Size(693, 36);
            this.curClass.TabIndex = 6;
            this.curClass.Text = "[SUBJCODE] Subject Title";
            this.curClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curTimeLabelBG
            // 
            this.curTimeLabelBG.Image = ((System.Drawing.Image)(resources.GetObject("curTimeLabelBG.Image")));
            this.curTimeLabelBG.Location = new System.Drawing.Point(184, 278);
            this.curTimeLabelBG.Name = "curTimeLabelBG";
            this.curTimeLabelBG.Size = new System.Drawing.Size(128, 50);
            this.curTimeLabelBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curTimeLabelBG.TabIndex = 7;
            this.curTimeLabelBG.TabStop = false;
            // 
            // curTimeLabel
            // 
            this.curTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(98)))), ((int)(((byte)(33)))));
            this.curTimeLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.curTimeLabel.ForeColor = System.Drawing.Color.White;
            this.curTimeLabel.Location = new System.Drawing.Point(194, 284);
            this.curTimeLabel.Name = "curTimeLabel";
            this.curTimeLabel.Size = new System.Drawing.Size(106, 36);
            this.curTimeLabel.TabIndex = 8;
            this.curTimeLabel.Text = "Time";
            this.curTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curTimeBG
            // 
            this.curTimeBG.Image = ((System.Drawing.Image)(resources.GetObject("curTimeBG.Image")));
            this.curTimeBG.Location = new System.Drawing.Point(334, 268);
            this.curTimeBG.Name = "curTimeBG";
            this.curTimeBG.Size = new System.Drawing.Size(325, 70);
            this.curTimeBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curTimeBG.TabIndex = 9;
            this.curTimeBG.TabStop = false;
            // 
            // curTime
            // 
            this.curTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.curTime.Font = new System.Drawing.Font("Arial", 18F);
            this.curTime.ForeColor = System.Drawing.Color.White;
            this.curTime.Location = new System.Drawing.Point(344, 286);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(306, 36);
            this.curTime.TabIndex = 10;
            this.curTime.Text = "Subject Time";
            this.curTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curStatusLabel
            // 
            this.curStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(98)))), ((int)(((byte)(33)))));
            this.curStatusLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.curStatusLabel.ForeColor = System.Drawing.Color.White;
            this.curStatusLabel.Location = new System.Drawing.Point(698, 284);
            this.curStatusLabel.Name = "curStatusLabel";
            this.curStatusLabel.Size = new System.Drawing.Size(106, 36);
            this.curStatusLabel.TabIndex = 12;
            this.curStatusLabel.Text = "Status";
            this.curStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curStatusLabelBG
            // 
            this.curStatusLabelBG.Image = ((System.Drawing.Image)(resources.GetObject("curStatusLabelBG.Image")));
            this.curStatusLabelBG.Location = new System.Drawing.Point(688, 278);
            this.curStatusLabelBG.Name = "curStatusLabelBG";
            this.curStatusLabelBG.Size = new System.Drawing.Size(128, 50);
            this.curStatusLabelBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curStatusLabelBG.TabIndex = 11;
            this.curStatusLabelBG.TabStop = false;
            // 
            // curStatus
            // 
            this.curStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.curStatus.Font = new System.Drawing.Font("Arial", 18F);
            this.curStatus.ForeColor = System.Drawing.Color.White;
            this.curStatus.Location = new System.Drawing.Point(840, 286);
            this.curStatus.Name = "curStatus";
            this.curStatus.Size = new System.Drawing.Size(306, 36);
            this.curStatus.TabIndex = 14;
            this.curStatus.Text = "Ongoing/Up Next";
            this.curStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curStatusBG
            // 
            this.curStatusBG.Image = ((System.Drawing.Image)(resources.GetObject("curStatusBG.Image")));
            this.curStatusBG.Location = new System.Drawing.Point(830, 268);
            this.curStatusBG.Name = "curStatusBG";
            this.curStatusBG.Size = new System.Drawing.Size(325, 70);
            this.curStatusBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curStatusBG.TabIndex = 13;
            this.curStatusBG.TabStop = false;
            // 
            // infoBG
            // 
            this.infoBG.Image = ((System.Drawing.Image)(resources.GetObject("infoBG.Image")));
            this.infoBG.Location = new System.Drawing.Point(184, 353);
            this.infoBG.Name = "infoBG";
            this.infoBG.Size = new System.Drawing.Size(971, 271);
            this.infoBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoBG.TabIndex = 15;
            this.infoBG.TabStop = false;
            // 
            // infoFieldBG
            // 
            this.infoFieldBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.infoFieldBG.Image = ((System.Drawing.Image)(resources.GetObject("infoFieldBG.Image")));
            this.infoFieldBG.Location = new System.Drawing.Point(526, 363);
            this.infoFieldBG.Name = "infoFieldBG";
            this.infoFieldBG.Size = new System.Drawing.Size(296, 60);
            this.infoFieldBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoFieldBG.TabIndex = 16;
            this.infoFieldBG.TabStop = false;
            // 
            // infoField
            // 
            this.infoField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(216)))), ((int)(((byte)(167)))));
            this.infoField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoField.Font = new System.Drawing.Font("Arial", 18F);
            this.infoField.Location = new System.Drawing.Point(543, 377);
            this.infoField.Name = "infoField";
            this.infoField.Size = new System.Drawing.Size(261, 28);
            this.infoField.TabIndex = 17;
            this.infoField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.infoField_KeyDown);
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.infoText.Font = new System.Drawing.Font("Arial", 18F);
            this.infoText.ForeColor = System.Drawing.Color.White;
            this.infoText.Location = new System.Drawing.Point(438, 437);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(480, 172);
            this.infoText.TabIndex = 18;
            this.infoText.Text = "Scan your ID...";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoReset
            // 
            this.infoReset.Interval = 7500;
            this.infoReset.Tick += new System.EventHandler(this.infoReset_Tick);
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
            this.sbTogBtn.Click += new System.EventHandler(this.sbTogBtn_Click);
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
            this.sbRecordsBtn.Click += new System.EventHandler(this.sbRecordsBtn_Click);
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
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.spRecordsBtn);
            this.sidePanel.Controls.Add(this.spCoursesBtn);
            this.sidePanel.Controls.Add(this.spBackBtn);
            this.sidePanel.Controls.Add(this.spStudentBtn);
            this.sidePanel.Controls.Add(this.spUser);
            this.sidePanel.Controls.Add(this.spDashboardBtn);
            this.sidePanel.Controls.Add(this.spUserIcon);
            this.sidePanel.Controls.Add(this.spLogo);
            this.sidePanel.Controls.Add(this.spContainer);
            this.sidePanel.Controls.Add(this.spBG);
            this.sidePanel.ForeColor = System.Drawing.Color.Transparent;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(336, 681);
            this.sidePanel.TabIndex = 37;
            this.sidePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Logout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spRecordsBtn
            // 
            this.spRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.spRecordsBtn.Image = ((System.Drawing.Image)(resources.GetObject("spRecordsBtn.Image")));
            this.spRecordsBtn.Location = new System.Drawing.Point(58, 366);
            this.spRecordsBtn.Name = "spRecordsBtn";
            this.spRecordsBtn.Size = new System.Drawing.Size(214, 56);
            this.spRecordsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spRecordsBtn.TabIndex = 35;
            this.spRecordsBtn.TabStop = false;
            // 
            // spCoursesBtn
            // 
            this.spCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.spCoursesBtn.Image = ((System.Drawing.Image)(resources.GetObject("spCoursesBtn.Image")));
            this.spCoursesBtn.Location = new System.Drawing.Point(58, 301);
            this.spCoursesBtn.Name = "spCoursesBtn";
            this.spCoursesBtn.Size = new System.Drawing.Size(214, 56);
            this.spCoursesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spCoursesBtn.TabIndex = 34;
            this.spCoursesBtn.TabStop = false;
            this.spCoursesBtn.Click += new System.EventHandler(this.sbCoursesBtn_Click);
            // 
            // spBackBtn
            // 
            this.spBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.spBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("spBackBtn.Image")));
            this.spBackBtn.Location = new System.Drawing.Point(265, 28);
            this.spBackBtn.Name = "spBackBtn";
            this.spBackBtn.Size = new System.Drawing.Size(50, 50);
            this.spBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spBackBtn.TabIndex = 28;
            this.spBackBtn.TabStop = false;
            this.spBackBtn.Click += new System.EventHandler(this.spBackBtn_Click);
            // 
            // spStudentBtn
            // 
            this.spStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.spStudentBtn.Image = ((System.Drawing.Image)(resources.GetObject("spStudentBtn.Image")));
            this.spStudentBtn.Location = new System.Drawing.Point(58, 236);
            this.spStudentBtn.Name = "spStudentBtn";
            this.spStudentBtn.Size = new System.Drawing.Size(214, 56);
            this.spStudentBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spStudentBtn.TabIndex = 33;
            this.spStudentBtn.TabStop = false;
            this.spStudentBtn.Click += new System.EventHandler(this.sbStudentsBtn_Click);
            // 
            // spUser
            // 
            this.spUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.spUser.Font = new System.Drawing.Font("Arial", 14F);
            this.spUser.ForeColor = System.Drawing.Color.White;
            this.spUser.Location = new System.Drawing.Point(86, 100);
            this.spUser.Name = "spUser";
            this.spUser.Size = new System.Drawing.Size(202, 34);
            this.spUser.TabIndex = 30;
            this.spUser.Text = "admin";
            this.spUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spDashboardBtn
            // 
            this.spDashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.spDashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("spDashboardBtn.Image")));
            this.spDashboardBtn.Location = new System.Drawing.Point(58, 171);
            this.spDashboardBtn.Name = "spDashboardBtn";
            this.spDashboardBtn.Size = new System.Drawing.Size(214, 56);
            this.spDashboardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spDashboardBtn.TabIndex = 32;
            this.spDashboardBtn.TabStop = false;
            // 
            // spUserIcon
            // 
            this.spUserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.spUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("spUserIcon.Image")));
            this.spUserIcon.Location = new System.Drawing.Point(44, 99);
            this.spUserIcon.Name = "spUserIcon";
            this.spUserIcon.Size = new System.Drawing.Size(35, 35);
            this.spUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spUserIcon.TabIndex = 29;
            this.spUserIcon.TabStop = false;
            // 
            // spLogo
            // 
            this.spLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.spLogo.Image = ((System.Drawing.Image)(resources.GetObject("spLogo.Image")));
            this.spLogo.Location = new System.Drawing.Point(18, 20);
            this.spLogo.Name = "spLogo";
            this.spLogo.Size = new System.Drawing.Size(233, 62);
            this.spLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spLogo.TabIndex = 27;
            this.spLogo.TabStop = false;
            // 
            // spContainer
            // 
            this.spContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(149)))));
            this.spContainer.Image = ((System.Drawing.Image)(resources.GetObject("spContainer.Image")));
            this.spContainer.Location = new System.Drawing.Point(44, 156);
            this.spContainer.Name = "spContainer";
            this.spContainer.Size = new System.Drawing.Size(244, 485);
            this.spContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spContainer.TabIndex = 31;
            this.spContainer.TabStop = false;
            // 
            // spBG
            // 
            this.spBG.Image = ((System.Drawing.Image)(resources.GetObject("spBG.Image")));
            this.spBG.Location = new System.Drawing.Point(0, 0);
            this.spBG.Name = "spBG";
            this.spBG.Size = new System.Drawing.Size(336, 681);
            this.spBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spBG.TabIndex = 26;
            this.spBG.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.sbTogBtn);
            this.Controls.Add(this.sbDashboardBtn);
            this.Controls.Add(this.sbStudentsBtn);
            this.Controls.Add(this.sbCoursesBtn);
            this.Controls.Add(this.sbRecordsBtn);
            this.Controls.Add(this.sbLogoutBtn);
            this.Controls.Add(this.sbBG);
            this.Controls.Add(this.curClassLabel);
            this.Controls.Add(this.curClassLabelBG);
            this.Controls.Add(this.curClass);
            this.Controls.Add(this.curClassBG);
            this.Controls.Add(this.curTimeLabel);
            this.Controls.Add(this.curTimeLabelBG);
            this.Controls.Add(this.curTime);
            this.Controls.Add(this.curTimeBG);
            this.Controls.Add(this.curStatusLabel);
            this.Controls.Add(this.curStatusLabelBG);
            this.Controls.Add(this.curStatus);
            this.Controls.Add(this.curStatusBG);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.infoField);
            this.Controls.Add(this.infoFieldBG);
            this.Controls.Add(this.infoBG);
            this.Controls.Add(this.header);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clockIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanClass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClassLabelBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClassBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTimeLabelBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTimeBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curStatusLabelBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curStatusBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFieldBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTogBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbDashboardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbStudentsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbCoursesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbRecordsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbLogoutBtn)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spRecordsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCoursesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStudentBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDashboardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox clockIcon;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox curClassLabelBG;
        private System.Windows.Forms.PictureBox curClassBG;
        private System.Windows.Forms.Label curClassLabel;
        private System.Windows.Forms.Label curClass;
        private System.Windows.Forms.PictureBox curTimeLabelBG;
        private System.Windows.Forms.Label curTimeLabel;
        private System.Windows.Forms.PictureBox curTimeBG;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Label curStatusLabel;
        private System.Windows.Forms.PictureBox curStatusLabelBG;
        private System.Windows.Forms.Label curStatus;
        private System.Windows.Forms.PictureBox curStatusBG;
        private System.Windows.Forms.PictureBox infoBG;
        private System.Windows.Forms.PictureBox infoFieldBG;
        private System.Windows.Forms.TextBox infoField;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Timer infoReset;
        private System.Windows.Forms.PictureBox sbBG;
        private System.Windows.Forms.PictureBox sbTogBtn;
        private System.Windows.Forms.PictureBox sbDashboardBtn;
        private System.Windows.Forms.PictureBox sbStudentsBtn;
        private System.Windows.Forms.PictureBox sbCoursesBtn;
        private System.Windows.Forms.PictureBox sbRecordsBtn;
        private System.Windows.Forms.PictureBox sbLogoutBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spRecordsBtn;
        private System.Windows.Forms.PictureBox spCoursesBtn;
        private System.Windows.Forms.PictureBox spBackBtn;
        private System.Windows.Forms.PictureBox spStudentBtn;
        private System.Windows.Forms.Label spUser;
        private System.Windows.Forms.PictureBox spDashboardBtn;
        private System.Windows.Forms.PictureBox spUserIcon;
        private System.Windows.Forms.PictureBox spLogo;
        private System.Windows.Forms.PictureBox spContainer;
        private System.Windows.Forms.PictureBox spBG;
    }
}

