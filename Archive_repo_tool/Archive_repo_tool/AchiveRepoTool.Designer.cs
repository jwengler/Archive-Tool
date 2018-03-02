namespace Archive_repo_tool
{

    partial class AchiveRepoTool
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
            this.Successtxt = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.archiveTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.mtrolblWarning = new MetroFramework.Controls.MetroLabel();
            this.ReprecoessQueuebtn = new MetroFramework.Controls.MetroButton();
            this.TimeFrameGrp = new MetroFramework.Controls.MetroPanel();
            this.EndTimetxt = new MetroFramework.Controls.MetroDateTime();
            this.StartTimetxt = new MetroFramework.Controls.MetroDateTime();
            this.EndTimelbl = new MetroFramework.Controls.MetroLabel();
            this.StartTimelbl = new MetroFramework.Controls.MetroLabel();
            this.ArchFilelbl = new MetroFramework.Controls.MetroLabel();
            this.Browsebtn = new MetroFramework.Controls.MetroButton();
            this.Queuefiletxt = new MetroFramework.Controls.MetroTextBox();
            this.QueueFilelbl = new MetroFramework.Controls.MetroLabel();
            this.eventQueueTab = new MetroFramework.Controls.MetroTabPage();
            this.VersionBox = new MetroFramework.Controls.MetroPanel();
            this.OldVersionBtn = new MetroFramework.Controls.MetroRadioButton();
            this.NewVersionBtn = new MetroFramework.Controls.MetroRadioButton();
            this.bufferQueueTab = new MetroFramework.Controls.MetroTabPage();
            this.piVersion = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.archiveTab.SuspendLayout();
            this.TimeFrameGrp.SuspendLayout();
            this.eventQueueTab.SuspendLayout();
            this.VersionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Successtxt
            // 
            this.Successtxt.AutoSize = true;
            this.Successtxt.Location = new System.Drawing.Point(376, 612);
            this.Successtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Successtxt.Name = "Successtxt";
            this.Successtxt.Size = new System.Drawing.Size(0, 0);
            this.Successtxt.TabIndex = 11;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.archiveTab);
            this.metroTabControl1.Location = new System.Drawing.Point(53, 91);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(816, 414);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            // 
            // archiveTab
            // 
            this.archiveTab.Controls.Add(this.metroLabel1);
            this.archiveTab.Controls.Add(this.metroProgressSpinner1);
            this.archiveTab.Controls.Add(this.mtrolblWarning);
            this.archiveTab.Controls.Add(this.ReprecoessQueuebtn);
            this.archiveTab.Controls.Add(this.TimeFrameGrp);
            this.archiveTab.Controls.Add(this.ArchFilelbl);
            this.archiveTab.Controls.Add(this.Browsebtn);
            this.archiveTab.Controls.Add(this.Queuefiletxt);
            this.archiveTab.Controls.Add(this.QueueFilelbl);
            this.archiveTab.HorizontalScrollbarBarColor = true;
            this.archiveTab.HorizontalScrollbarHighlightOnWheel = false;
            this.archiveTab.HorizontalScrollbarSize = 1;
            this.archiveTab.Location = new System.Drawing.Point(4, 38);
            this.archiveTab.Name = "archiveTab";
            this.archiveTab.Size = new System.Drawing.Size(808, 372);
            this.archiveTab.TabIndex = 0;
            this.archiveTab.Text = "Corrupt Archive";
            this.archiveTab.VerticalScrollbarBarColor = true;
            this.archiveTab.VerticalScrollbarHighlightOnWheel = false;
            this.archiveTab.VerticalScrollbarSize = 1;
            this.archiveTab.Click += new System.EventHandler(this.archiveTab_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(442, 263);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(300, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Completed Successfully! Logs Located on Desktop";
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Visible = false;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(710, 197);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(52, 47);
            this.metroProgressSpinner1.Speed = 3F;
            this.metroProgressSpinner1.Spinning = false;
            this.metroProgressSpinner1.TabIndex = 29;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // mtrolblWarning
            // 
            this.mtrolblWarning.AutoSize = true;
            this.mtrolblWarning.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtrolblWarning.Location = new System.Drawing.Point(515, 14);
            this.mtrolblWarning.Name = "mtrolblWarning";
            this.mtrolblWarning.Size = new System.Drawing.Size(265, 19);
            this.mtrolblWarning.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrolblWarning.TabIndex = 28;
            this.mtrolblWarning.Text = "NOTE: REMEMBER TO TAKE A BACKUP!";
            this.mtrolblWarning.UseStyleColors = true;
            // 
            // ReprecoessQueuebtn
            // 
            this.ReprecoessQueuebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReprecoessQueuebtn.Location = new System.Drawing.Point(505, 197);
            this.ReprecoessQueuebtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReprecoessQueuebtn.Name = "ReprecoessQueuebtn";
            this.ReprecoessQueuebtn.Size = new System.Drawing.Size(201, 47);
            this.ReprecoessQueuebtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReprecoessQueuebtn.TabIndex = 27;
            this.ReprecoessQueuebtn.Text = "Reprocess";
            this.ReprecoessQueuebtn.UseSelectable = true;
            this.ReprecoessQueuebtn.UseStyleColors = true;
            this.ReprecoessQueuebtn.Click += new System.EventHandler(this.ReprecoessQueuebtn_Click);
            // 
            // TimeFrameGrp
            // 
            this.TimeFrameGrp.Controls.Add(this.EndTimetxt);
            this.TimeFrameGrp.Controls.Add(this.StartTimetxt);
            this.TimeFrameGrp.Controls.Add(this.EndTimelbl);
            this.TimeFrameGrp.Controls.Add(this.StartTimelbl);
            this.TimeFrameGrp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeFrameGrp.HorizontalScrollbarBarColor = true;
            this.TimeFrameGrp.HorizontalScrollbarHighlightOnWheel = false;
            this.TimeFrameGrp.HorizontalScrollbarSize = 1;
            this.TimeFrameGrp.Location = new System.Drawing.Point(19, 147);
            this.TimeFrameGrp.Margin = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Name = "TimeFrameGrp";
            this.TimeFrameGrp.Padding = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Size = new System.Drawing.Size(344, 147);
            this.TimeFrameGrp.TabIndex = 26;
            this.TimeFrameGrp.Text = "Time of Target Archive";
            this.TimeFrameGrp.VerticalScrollbarBarColor = true;
            this.TimeFrameGrp.VerticalScrollbarHighlightOnWheel = false;
            this.TimeFrameGrp.VerticalScrollbarSize = 1;
            // 
            // EndTimetxt
            // 
            this.EndTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.EndTimetxt.Enabled = false;
            this.EndTimetxt.Location = new System.Drawing.Point(105, 82);
            this.EndTimetxt.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndTimetxt.Name = "EndTimetxt";
            this.EndTimetxt.Size = new System.Drawing.Size(209, 30);
            this.EndTimetxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.EndTimetxt.TabIndex = 17;
            this.EndTimetxt.UseStyleColors = true;
            // 
            // StartTimetxt
            // 
            this.StartTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.StartTimetxt.Enabled = false;
            this.StartTimetxt.Location = new System.Drawing.Point(105, 33);
            this.StartTimetxt.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartTimetxt.Name = "StartTimetxt";
            this.StartTimetxt.Size = new System.Drawing.Size(209, 30);
            this.StartTimetxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.StartTimetxt.TabIndex = 16;
            this.StartTimetxt.UseStyleColors = true;
            this.StartTimetxt.Value = new System.DateTime(2017, 10, 19, 0, 0, 0, 0);
            // 
            // EndTimelbl
            // 
            this.EndTimelbl.AutoSize = true;
            this.EndTimelbl.Location = new System.Drawing.Point(19, 87);
            this.EndTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimelbl.Name = "EndTimelbl";
            this.EndTimelbl.Size = new System.Drawing.Size(67, 19);
            this.EndTimelbl.TabIndex = 1;
            this.EndTimelbl.Text = "End Time:";
            // 
            // StartTimelbl
            // 
            this.StartTimelbl.AutoSize = true;
            this.StartTimelbl.Location = new System.Drawing.Point(19, 38);
            this.StartTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimelbl.Name = "StartTimelbl";
            this.StartTimelbl.Size = new System.Drawing.Size(73, 19);
            this.StartTimelbl.TabIndex = 0;
            this.StartTimelbl.Text = "Start Time:";
            // 
            // ArchFilelbl
            // 
            this.ArchFilelbl.AutoSize = true;
            this.ArchFilelbl.Location = new System.Drawing.Point(18, 106);
            this.ArchFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchFilelbl.Name = "ArchFilelbl";
            this.ArchFilelbl.Size = new System.Drawing.Size(176, 19);
            this.ArchFilelbl.TabIndex = 24;
            this.ArchFilelbl.Text = "Destination Archive File Path:";
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(602, 46);
            this.Browsebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(100, 34);
            this.Browsebtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Browsebtn.TabIndex = 23;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseSelectable = true;
            this.Browsebtn.UseStyleColors = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // Queuefiletxt
            // 
            // 
            // 
            // 
            this.Queuefiletxt.CustomButton.Image = null;
            this.Queuefiletxt.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.Queuefiletxt.CustomButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Queuefiletxt.CustomButton.Name = "";
            this.Queuefiletxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Queuefiletxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Queuefiletxt.CustomButton.TabIndex = 1;
            this.Queuefiletxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Queuefiletxt.CustomButton.UseSelectable = true;
            this.Queuefiletxt.CustomButton.Visible = false;
            this.Queuefiletxt.Lines = new string[0];
            this.Queuefiletxt.Location = new System.Drawing.Point(221, 50);
            this.Queuefiletxt.Margin = new System.Windows.Forms.Padding(4);
            this.Queuefiletxt.MaxLength = 32767;
            this.Queuefiletxt.Name = "Queuefiletxt";
            this.Queuefiletxt.PasswordChar = '\0';
            this.Queuefiletxt.ReadOnly = true;
            this.Queuefiletxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Queuefiletxt.SelectedText = "";
            this.Queuefiletxt.SelectionLength = 0;
            this.Queuefiletxt.SelectionStart = 0;
            this.Queuefiletxt.ShortcutsEnabled = true;
            this.Queuefiletxt.Size = new System.Drawing.Size(336, 27);
            this.Queuefiletxt.TabIndex = 22;
            this.Queuefiletxt.UseSelectable = true;
            this.Queuefiletxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Queuefiletxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Queuefiletxt.TextChanged += new System.EventHandler(this.Queuefiletxt_TextChanged);
            this.Queuefiletxt.Click += new System.EventHandler(this.Queuefiletxt_Click);
            // 
            // QueueFilelbl
            // 
            this.QueueFilelbl.AutoSize = true;
            this.QueueFilelbl.Location = new System.Drawing.Point(18, 54);
            this.QueueFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QueueFilelbl.Name = "QueueFilelbl";
            this.QueueFilelbl.Size = new System.Drawing.Size(126, 19);
            this.QueueFilelbl.TabIndex = 21;
            this.QueueFilelbl.Text = "Corrupted File Path:";
            // 
            // eventQueueTab
            // 
            this.eventQueueTab.Controls.Add(this.VersionBox);
            this.eventQueueTab.HorizontalScrollbarBarColor = true;
            this.eventQueueTab.HorizontalScrollbarHighlightOnWheel = false;
            this.eventQueueTab.HorizontalScrollbarSize = 1;
            this.eventQueueTab.Location = new System.Drawing.Point(4, 38);
            this.eventQueueTab.Name = "eventQueueTab";
            this.eventQueueTab.Size = new System.Drawing.Size(808, 309);
            this.eventQueueTab.TabIndex = 1;
            this.eventQueueTab.Text = "Corrupt Event Queue";
            this.eventQueueTab.VerticalScrollbarBarColor = true;
            this.eventQueueTab.VerticalScrollbarHighlightOnWheel = false;
            this.eventQueueTab.VerticalScrollbarSize = 2;
            // 
            // VersionBox
            // 
            this.VersionBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VersionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VersionBox.Controls.Add(this.OldVersionBtn);
            this.VersionBox.Controls.Add(this.NewVersionBtn);
            this.VersionBox.HorizontalScrollbarBarColor = true;
            this.VersionBox.HorizontalScrollbarHighlightOnWheel = false;
            this.VersionBox.HorizontalScrollbarSize = 1;
            this.VersionBox.Location = new System.Drawing.Point(398, 136);
            this.VersionBox.Margin = new System.Windows.Forms.Padding(4);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Padding = new System.Windows.Forms.Padding(4);
            this.VersionBox.Size = new System.Drawing.Size(170, 124);
            this.VersionBox.TabIndex = 14;
            this.VersionBox.Text = "Buffer Subsystem Version";
            this.VersionBox.VerticalScrollbarBarColor = true;
            this.VersionBox.VerticalScrollbarHighlightOnWheel = false;
            this.VersionBox.VerticalScrollbarSize = 2;
            // 
            // OldVersionBtn
            // 
            this.OldVersionBtn.AutoSize = true;
            this.OldVersionBtn.Location = new System.Drawing.Point(29, 94);
            this.OldVersionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OldVersionBtn.Name = "OldVersionBtn";
            this.OldVersionBtn.Size = new System.Drawing.Size(121, 15);
            this.OldVersionBtn.TabIndex = 1;
            this.OldVersionBtn.TabStop = true;
            this.OldVersionBtn.Text = "Versions Before 4.3";
            this.OldVersionBtn.UseSelectable = true;
            // 
            // NewVersionBtn
            // 
            this.NewVersionBtn.AutoSize = true;
            this.NewVersionBtn.Location = new System.Drawing.Point(29, 42);
            this.NewVersionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NewVersionBtn.Name = "NewVersionBtn";
            this.NewVersionBtn.Size = new System.Drawing.Size(136, 15);
            this.NewVersionBtn.TabIndex = 0;
            this.NewVersionBtn.TabStop = true;
            this.NewVersionBtn.Text = "Versions 4.3 and Later";
            this.NewVersionBtn.UseSelectable = true;
            // 
            // bufferQueueTab
            // 
            this.bufferQueueTab.HorizontalScrollbarBarColor = true;
            this.bufferQueueTab.HorizontalScrollbarHighlightOnWheel = false;
            this.bufferQueueTab.HorizontalScrollbarSize = 1;
            this.bufferQueueTab.Location = new System.Drawing.Point(4, 38);
            this.bufferQueueTab.Name = "bufferQueueTab";
            this.bufferQueueTab.Size = new System.Drawing.Size(808, 309);
            this.bufferQueueTab.TabIndex = 2;
            this.bufferQueueTab.Text = "Corrupt Buffer Queue";
            this.bufferQueueTab.VerticalScrollbarBarColor = true;
            this.bufferQueueTab.VerticalScrollbarHighlightOnWheel = false;
            this.bufferQueueTab.VerticalScrollbarSize = 2;
            // 
            // piVersion
            // 
            this.piVersion.AutoSize = true;
            this.piVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.piVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.piVersion.Location = new System.Drawing.Point(328, 59);
            this.piVersion.Name = "piVersion";
            this.piVersion.Size = new System.Drawing.Size(165, 19);
            this.piVersion.Style = MetroFramework.MetroColorStyle.Blue;
            this.piVersion.TabIndex = 17;
            this.piVersion.Text = "PI Data Archive Version";
            this.piVersion.UseStyleColors = true;
            // 
            // AchiveRepoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 509);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.piVersion);
            this.Controls.Add(this.Successtxt);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AchiveRepoTool";
            this.Padding = new System.Windows.Forms.Padding(27, 88, 27, 29);
            this.Text = "Archive Reprocessing Tool";
            this.Load += new System.EventHandler(this.AchiveRepoTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.archiveTab.ResumeLayout(false);
            this.archiveTab.PerformLayout();
            this.TimeFrameGrp.ResumeLayout(false);
            this.TimeFrameGrp.PerformLayout();
            this.eventQueueTab.ResumeLayout(false);
            this.VersionBox.ResumeLayout(false);
            this.VersionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Successtxt;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage archiveTab;
        private MetroFramework.Controls.MetroLabel piVersion;
        private MetroFramework.Controls.MetroTabPage eventQueueTab;
        private MetroFramework.Controls.MetroButton ReprecoessQueuebtn;
        private MetroFramework.Controls.MetroPanel TimeFrameGrp;
        private MetroFramework.Controls.MetroDateTime EndTimetxt;
        private MetroFramework.Controls.MetroDateTime StartTimetxt;
        private MetroFramework.Controls.MetroLabel EndTimelbl;
        private MetroFramework.Controls.MetroLabel StartTimelbl;
        private MetroFramework.Controls.MetroLabel ArchFilelbl;
        private MetroFramework.Controls.MetroButton Browsebtn;
        private MetroFramework.Controls.MetroTextBox Queuefiletxt;
        private MetroFramework.Controls.MetroLabel QueueFilelbl;
        private MetroFramework.Controls.MetroLabel mtrolblWarning;
        private MetroFramework.Controls.MetroPanel VersionBox;
        private MetroFramework.Controls.MetroRadioButton OldVersionBtn;
        private MetroFramework.Controls.MetroRadioButton NewVersionBtn;
        private MetroFramework.Controls.MetroTabPage bufferQueueTab;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

