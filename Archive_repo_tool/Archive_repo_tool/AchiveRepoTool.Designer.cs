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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mtrolblWarning = new MetroFramework.Controls.MetroLabel();
            this.ReprecoessQueuebtn = new MetroFramework.Controls.MetroButton();
            this.TimeFrameGrp = new MetroFramework.Controls.MetroPanel();
            this.EndTimetxt = new MetroFramework.Controls.MetroDateTime();
            this.StartTimetxt = new MetroFramework.Controls.MetroDateTime();
            this.EndTimelbl = new MetroFramework.Controls.MetroLabel();
            this.StartTimelbl = new MetroFramework.Controls.MetroLabel();
            this.ArchFiletxt = new MetroFramework.Controls.MetroTextBox();
            this.ArchFilelbl = new MetroFramework.Controls.MetroLabel();
            this.Browsebtn = new MetroFramework.Controls.MetroButton();
            this.Queuefiletxt = new MetroFramework.Controls.MetroTextBox();
            this.QueueFilelbl = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.repoTypeBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.piVersion = new MetroFramework.Controls.MetroLabel();
            this.NewVersionBtn = new MetroFramework.Controls.MetroRadioButton();
            this.OldVersionBtn = new MetroFramework.Controls.MetroRadioButton();
            this.VersionBox = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.TimeFrameGrp.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
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
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(53, 91);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(784, 410);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mtrolblWarning);
            this.metroTabPage1.Controls.Add(this.ReprecoessQueuebtn);
            this.metroTabPage1.Controls.Add(this.TimeFrameGrp);
            this.metroTabPage1.Controls.Add(this.ArchFiletxt);
            this.metroTabPage1.Controls.Add(this.ArchFilelbl);
            this.metroTabPage1.Controls.Add(this.Browsebtn);
            this.metroTabPage1.Controls.Add(this.Queuefiletxt);
            this.metroTabPage1.Controls.Add(this.QueueFilelbl);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.repoTypeBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(776, 368);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Corrupt Archive";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 2;
            // 
            // mtrolblWarning
            // 
            this.mtrolblWarning.AutoSize = true;
            this.mtrolblWarning.Location = new System.Drawing.Point(507, 22);
            this.mtrolblWarning.Name = "mtrolblWarning";
            this.mtrolblWarning.Size = new System.Drawing.Size(243, 19);
            this.mtrolblWarning.TabIndex = 28;
            this.mtrolblWarning.Text = "NOTE: REMEMBER TO TAKE A BACKUP!";
            this.mtrolblWarning.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // ReprecoessQueuebtn
            // 
            this.ReprecoessQueuebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReprecoessQueuebtn.Location = new System.Drawing.Point(422, 257);
            this.ReprecoessQueuebtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReprecoessQueuebtn.Name = "ReprecoessQueuebtn";
            this.ReprecoessQueuebtn.Size = new System.Drawing.Size(201, 47);
            this.ReprecoessQueuebtn.TabIndex = 27;
            this.ReprecoessQueuebtn.Text = "Reprocess";
            this.ReprecoessQueuebtn.UseSelectable = true;
            // 
            // TimeFrameGrp
            // 
            this.TimeFrameGrp.Controls.Add(this.EndTimetxt);
            this.TimeFrameGrp.Controls.Add(this.StartTimetxt);
            this.TimeFrameGrp.Controls.Add(this.EndTimelbl);
            this.TimeFrameGrp.Controls.Add(this.StartTimelbl);
            this.TimeFrameGrp.HorizontalScrollbarBarColor = true;
            this.TimeFrameGrp.HorizontalScrollbarHighlightOnWheel = false;
            this.TimeFrameGrp.HorizontalScrollbarSize = 5;
            this.TimeFrameGrp.Location = new System.Drawing.Point(0, 196);
            this.TimeFrameGrp.Margin = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Name = "TimeFrameGrp";
            this.TimeFrameGrp.Padding = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Size = new System.Drawing.Size(344, 168);
            this.TimeFrameGrp.TabIndex = 26;
            this.TimeFrameGrp.Text = "Time of Target Archive";
            this.TimeFrameGrp.VerticalScrollbarBarColor = true;
            this.TimeFrameGrp.VerticalScrollbarHighlightOnWheel = false;
            this.TimeFrameGrp.VerticalScrollbarSize = 6;
            // 
            // EndTimetxt
            // 
            this.EndTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.EndTimetxt.Enabled = false;
            this.EndTimetxt.Location = new System.Drawing.Point(99, 91);
            this.EndTimetxt.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndTimetxt.Name = "EndTimetxt";
            this.EndTimetxt.Size = new System.Drawing.Size(209, 29);
            this.EndTimetxt.TabIndex = 17;
            // 
            // StartTimetxt
            // 
            this.StartTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.StartTimetxt.Enabled = false;
            this.StartTimetxt.Location = new System.Drawing.Point(99, 42);
            this.StartTimetxt.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartTimetxt.Name = "StartTimetxt";
            this.StartTimetxt.Size = new System.Drawing.Size(209, 29);
            this.StartTimetxt.TabIndex = 16;
            this.StartTimetxt.Value = new System.DateTime(2017, 10, 19, 0, 0, 0, 0);
            // 
            // EndTimelbl
            // 
            this.EndTimelbl.AutoSize = true;
            this.EndTimelbl.Location = new System.Drawing.Point(16, 94);
            this.EndTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimelbl.Name = "EndTimelbl";
            this.EndTimelbl.Size = new System.Drawing.Size(67, 19);
            this.EndTimelbl.TabIndex = 1;
            this.EndTimelbl.Text = "End Time:";
            // 
            // StartTimelbl
            // 
            this.StartTimelbl.AutoSize = true;
            this.StartTimelbl.Location = new System.Drawing.Point(13, 42);
            this.StartTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimelbl.Name = "StartTimelbl";
            this.StartTimelbl.Size = new System.Drawing.Size(73, 19);
            this.StartTimelbl.TabIndex = 0;
            this.StartTimelbl.Text = "Start Time:";
            // 
            // ArchFiletxt
            // 
            // 
            // 
            // 
            this.ArchFiletxt.CustomButton.Image = null;
            this.ArchFiletxt.CustomButton.Location = new System.Drawing.Point(375, 1);
            this.ArchFiletxt.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ArchFiletxt.CustomButton.Name = "";
            this.ArchFiletxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ArchFiletxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ArchFiletxt.CustomButton.TabIndex = 1;
            this.ArchFiletxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ArchFiletxt.CustomButton.UseSelectable = true;
            this.ArchFiletxt.CustomButton.Visible = false;
            this.ArchFiletxt.Lines = new string[0];
            this.ArchFiletxt.Location = new System.Drawing.Point(192, 95);
            this.ArchFiletxt.Margin = new System.Windows.Forms.Padding(4);
            this.ArchFiletxt.MaxLength = 32767;
            this.ArchFiletxt.Name = "ArchFiletxt";
            this.ArchFiletxt.PasswordChar = '\0';
            this.ArchFiletxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ArchFiletxt.SelectedText = "";
            this.ArchFiletxt.SelectionLength = 0;
            this.ArchFiletxt.SelectionStart = 0;
            this.ArchFiletxt.ShortcutsEnabled = true;
            this.ArchFiletxt.Size = new System.Drawing.Size(401, 27);
            this.ArchFiletxt.TabIndex = 25;
            this.ArchFiletxt.UseSelectable = true;
            this.ArchFiletxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ArchFiletxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ArchFilelbl
            // 
            this.ArchFilelbl.AutoSize = true;
            this.ArchFilelbl.Location = new System.Drawing.Point(0, 80);
            this.ArchFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchFilelbl.Name = "ArchFilelbl";
            this.ArchFilelbl.Size = new System.Drawing.Size(176, 19);
            this.ArchFilelbl.TabIndex = 24;
            this.ArchFilelbl.Text = "Destination Archive File Path:";
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(551, 141);
            this.Browsebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(100, 34);
            this.Browsebtn.TabIndex = 23;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseSelectable = true;
            // 
            // Queuefiletxt
            // 
            // 
            // 
            // 
            this.Queuefiletxt.CustomButton.Image = null;
            this.Queuefiletxt.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.Queuefiletxt.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Queuefiletxt.CustomButton.Name = "";
            this.Queuefiletxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Queuefiletxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Queuefiletxt.CustomButton.TabIndex = 1;
            this.Queuefiletxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Queuefiletxt.CustomButton.UseSelectable = true;
            this.Queuefiletxt.CustomButton.Visible = false;
            this.Queuefiletxt.Lines = new string[0];
            this.Queuefiletxt.Location = new System.Drawing.Point(192, 145);
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
            // 
            // QueueFilelbl
            // 
            this.QueueFilelbl.AutoSize = true;
            this.QueueFilelbl.Location = new System.Drawing.Point(0, 148);
            this.QueueFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QueueFilelbl.Name = "QueueFilelbl";
            this.QueueFilelbl.Size = new System.Drawing.Size(126, 19);
            this.QueueFilelbl.TabIndex = 21;
            this.QueueFilelbl.Text = "Corrupted File Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "What are you Reprocessing?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // repoTypeBox
            // 
            this.repoTypeBox.FormattingEnabled = true;
            this.repoTypeBox.ItemHeight = 23;
            this.repoTypeBox.Items.AddRange(new object[] {
            "Corrupt Archive",
            "Corrupt Event Queue",
            "Corrupt Buffer Queue"});
            this.repoTypeBox.Location = new System.Drawing.Point(192, 22);
            this.repoTypeBox.Name = "repoTypeBox";
            this.repoTypeBox.Size = new System.Drawing.Size(187, 29);
            this.repoTypeBox.TabIndex = 19;
            this.repoTypeBox.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.VersionBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(776, 368);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Corrupt Event Queue";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 1;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(871, 476);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Corrupt Buffer Queue";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 2;
            // 
            // piVersion
            // 
            this.piVersion.AutoSize = true;
            this.piVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.piVersion.Location = new System.Drawing.Point(306, 50);
            this.piVersion.Name = "piVersion";
            this.piVersion.Size = new System.Drawing.Size(144, 19);
            this.piVersion.TabIndex = 17;
            this.piVersion.Text = "PI Data Archive Version";
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
            // VersionBox
            // 
            this.VersionBox.Controls.Add(this.OldVersionBtn);
            this.VersionBox.Controls.Add(this.NewVersionBtn);
            this.VersionBox.HorizontalScrollbarBarColor = true;
            this.VersionBox.HorizontalScrollbarHighlightOnWheel = false;
            this.VersionBox.HorizontalScrollbarSize = 5;
            this.VersionBox.Location = new System.Drawing.Point(181, 86);
            this.VersionBox.Margin = new System.Windows.Forms.Padding(4);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Padding = new System.Windows.Forms.Padding(4);
            this.VersionBox.Size = new System.Drawing.Size(267, 168);
            this.VersionBox.TabIndex = 14;
            this.VersionBox.Text = "Buffer Subsystem Version";
            this.VersionBox.VerticalScrollbarBarColor = true;
            this.VersionBox.VerticalScrollbarHighlightOnWheel = false;
            this.VersionBox.VerticalScrollbarSize = 6;
            this.VersionBox.Visible = false;
            // 
            // AchiveRepoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
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
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.TimeFrameGrp.ResumeLayout(false);
            this.TimeFrameGrp.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.VersionBox.ResumeLayout(false);
            this.VersionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Successtxt;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroComboBox repoTypeBox;
        private MetroFramework.Controls.MetroLabel piVersion;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton ReprecoessQueuebtn;
        private MetroFramework.Controls.MetroPanel TimeFrameGrp;
        private MetroFramework.Controls.MetroDateTime EndTimetxt;
        private MetroFramework.Controls.MetroDateTime StartTimetxt;
        private MetroFramework.Controls.MetroLabel EndTimelbl;
        private MetroFramework.Controls.MetroLabel StartTimelbl;
        private MetroFramework.Controls.MetroTextBox ArchFiletxt;
        private MetroFramework.Controls.MetroLabel ArchFilelbl;
        private MetroFramework.Controls.MetroButton Browsebtn;
        private MetroFramework.Controls.MetroTextBox Queuefiletxt;
        private MetroFramework.Controls.MetroLabel QueueFilelbl;
        private MetroFramework.Controls.MetroLabel mtrolblWarning;
        private MetroFramework.Controls.MetroPanel VersionBox;
        private MetroFramework.Controls.MetroRadioButton OldVersionBtn;
        private MetroFramework.Controls.MetroRadioButton NewVersionBtn;
    }
}

