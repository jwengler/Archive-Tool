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
            this.Inputs = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.QueueFilelbl = new System.Windows.Forms.Label();
            this.Queuefiletxt = new System.Windows.Forms.TextBox();
            this.ArchFilelbl = new System.Windows.Forms.Label();
            this.ArchFiletxt = new System.Windows.Forms.TextBox();
            this.TimeFrameGrp = new System.Windows.Forms.GroupBox();
            this.EndTimelbl = new System.Windows.Forms.Label();
            this.StartTimelbl = new System.Windows.Forms.Label();
            this.ReprecoessQueuebtn = new System.Windows.Forms.Button();
            this.Successtxt = new System.Windows.Forms.Label();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.VersionBox = new System.Windows.Forms.GroupBox();
            this.OldVersionBtn = new System.Windows.Forms.RadioButton();
            this.NewVersionBtn = new System.Windows.Forms.RadioButton();
            this.repoTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimetxt = new System.Windows.Forms.DateTimePicker();
            this.EndTimetxt = new System.Windows.Forms.DateTimePicker();
            this.TimeFrameGrp.SuspendLayout();
            this.VersionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inputs
            // 
            this.Inputs.AutoSize = true;
            this.Inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputs.Location = new System.Drawing.Point(17, 16);
            this.Inputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.Size = new System.Drawing.Size(99, 35);
            this.Inputs.TabIndex = 0;
            this.Inputs.Text = "Inputs";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(20, 52);
            this.warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(189, 17);
            this.warning.TabIndex = 1;
            this.warning.Text = "Remember to take a backup!";
            // 
            // QueueFilelbl
            // 
            this.QueueFilelbl.AutoSize = true;
            this.QueueFilelbl.Location = new System.Drawing.Point(24, 92);
            this.QueueFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QueueFilelbl.Name = "QueueFilelbl";
            this.QueueFilelbl.Size = new System.Drawing.Size(134, 17);
            this.QueueFilelbl.TabIndex = 2;
            this.QueueFilelbl.Text = "Corrupted File Path:";
            // 
            // Queuefiletxt
            // 
            this.Queuefiletxt.Location = new System.Drawing.Point(165, 89);
            this.Queuefiletxt.Margin = new System.Windows.Forms.Padding(4);
            this.Queuefiletxt.Name = "Queuefiletxt";
            this.Queuefiletxt.ReadOnly = true;
            this.Queuefiletxt.Size = new System.Drawing.Size(336, 22);
            this.Queuefiletxt.TabIndex = 3;
            // 
            // ArchFilelbl
            // 
            this.ArchFilelbl.AutoSize = true;
            this.ArchFilelbl.Location = new System.Drawing.Point(24, 135);
            this.ArchFilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchFilelbl.Name = "ArchFilelbl";
            this.ArchFilelbl.Size = new System.Drawing.Size(193, 17);
            this.ArchFilelbl.TabIndex = 4;
            this.ArchFilelbl.Text = "Destination Archive File Path:";
            // 
            // ArchFiletxt
            // 
            this.ArchFiletxt.Location = new System.Drawing.Point(217, 132);
            this.ArchFiletxt.Margin = new System.Windows.Forms.Padding(4);
            this.ArchFiletxt.Name = "ArchFiletxt";
            this.ArchFiletxt.Size = new System.Drawing.Size(401, 22);
            this.ArchFiletxt.TabIndex = 5;
            // 
            // TimeFrameGrp
            // 
            this.TimeFrameGrp.Controls.Add(this.EndTimetxt);
            this.TimeFrameGrp.Controls.Add(this.StartTimetxt);
            this.TimeFrameGrp.Controls.Add(this.EndTimelbl);
            this.TimeFrameGrp.Controls.Add(this.StartTimelbl);
            this.TimeFrameGrp.Location = new System.Drawing.Point(28, 188);
            this.TimeFrameGrp.Margin = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Name = "TimeFrameGrp";
            this.TimeFrameGrp.Padding = new System.Windows.Forms.Padding(4);
            this.TimeFrameGrp.Size = new System.Drawing.Size(317, 142);
            this.TimeFrameGrp.TabIndex = 6;
            this.TimeFrameGrp.TabStop = false;
            this.TimeFrameGrp.Text = "Time of Target Archive";
            // 
            // EndTimelbl
            // 
            this.EndTimelbl.AutoSize = true;
            this.EndTimelbl.Location = new System.Drawing.Point(16, 79);
            this.EndTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimelbl.Name = "EndTimelbl";
            this.EndTimelbl.Size = new System.Drawing.Size(72, 17);
            this.EndTimelbl.TabIndex = 1;
            this.EndTimelbl.Text = "End Time:";
            // 
            // StartTimelbl
            // 
            this.StartTimelbl.AutoSize = true;
            this.StartTimelbl.Location = new System.Drawing.Point(13, 36);
            this.StartTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimelbl.Name = "StartTimelbl";
            this.StartTimelbl.Size = new System.Drawing.Size(77, 17);
            this.StartTimelbl.TabIndex = 0;
            this.StartTimelbl.Text = "Start Time:";
            // 
            // ReprecoessQueuebtn
            // 
            this.ReprecoessQueuebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReprecoessQueuebtn.Location = new System.Drawing.Point(56, 354);
            this.ReprecoessQueuebtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReprecoessQueuebtn.Name = "ReprecoessQueuebtn";
            this.ReprecoessQueuebtn.Size = new System.Drawing.Size(201, 39);
            this.ReprecoessQueuebtn.TabIndex = 9;
            this.ReprecoessQueuebtn.Text = "Reprocess";
            this.ReprecoessQueuebtn.UseVisualStyleBackColor = false;
            this.ReprecoessQueuebtn.Click += new System.EventHandler(this.ReprecoessQueuebtn_Click);
            // 
            // Successtxt
            // 
            this.Successtxt.AutoSize = true;
            this.Successtxt.Location = new System.Drawing.Point(349, 367);
            this.Successtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Successtxt.Name = "Successtxt";
            this.Successtxt.Size = new System.Drawing.Size(0, 17);
            this.Successtxt.TabIndex = 11;
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(520, 86);
            this.Browsebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(100, 28);
            this.Browsebtn.TabIndex = 12;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // VersionBox
            // 
            this.VersionBox.Controls.Add(this.OldVersionBtn);
            this.VersionBox.Controls.Add(this.NewVersionBtn);
            this.VersionBox.Location = new System.Drawing.Point(353, 188);
            this.VersionBox.Margin = new System.Windows.Forms.Padding(4);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Padding = new System.Windows.Forms.Padding(4);
            this.VersionBox.Size = new System.Drawing.Size(267, 142);
            this.VersionBox.TabIndex = 13;
            this.VersionBox.TabStop = false;
            this.VersionBox.Text = "Buffer Subsystem Version";
            this.VersionBox.Visible = false;
            // 
            // OldVersionBtn
            // 
            this.OldVersionBtn.AutoSize = true;
            this.OldVersionBtn.Location = new System.Drawing.Point(29, 79);
            this.OldVersionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OldVersionBtn.Name = "OldVersionBtn";
            this.OldVersionBtn.Size = new System.Drawing.Size(154, 21);
            this.OldVersionBtn.TabIndex = 1;
            this.OldVersionBtn.TabStop = true;
            this.OldVersionBtn.Text = "Versions Before 4.3";
            this.OldVersionBtn.UseVisualStyleBackColor = true;
            // 
            // NewVersionBtn
            // 
            this.NewVersionBtn.AutoSize = true;
            this.NewVersionBtn.Location = new System.Drawing.Point(29, 36);
            this.NewVersionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NewVersionBtn.Name = "NewVersionBtn";
            this.NewVersionBtn.Size = new System.Drawing.Size(173, 21);
            this.NewVersionBtn.TabIndex = 0;
            this.NewVersionBtn.TabStop = true;
            this.NewVersionBtn.Text = "Versions 4.3 and Later";
            this.NewVersionBtn.UseVisualStyleBackColor = true;
            this.NewVersionBtn.CheckedChanged += new System.EventHandler(this.NewVersionBtn_CheckedChanged);
            // 
            // repoTypeBox
            // 
            this.repoTypeBox.FormattingEnabled = true;
            this.repoTypeBox.Items.AddRange(new object[] {
            "Corrupt Archive",
            "Corrupt Event Queue",
            "Corrupt Buffer Queue"});
            this.repoTypeBox.Location = new System.Drawing.Point(437, 29);
            this.repoTypeBox.Name = "repoTypeBox";
            this.repoTypeBox.Size = new System.Drawing.Size(183, 24);
            this.repoTypeBox.TabIndex = 14;
            this.repoTypeBox.SelectedIndexChanged += new System.EventHandler(this.repoTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(238, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "What are you Reprocessing?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartTimetxt
            // 
            this.StartTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.StartTimetxt.Location = new System.Drawing.Point(98, 36);
            this.StartTimetxt.Name = "StartTimetxt";
            this.StartTimetxt.Size = new System.Drawing.Size(209, 22);
            this.StartTimetxt.TabIndex = 16;
            this.StartTimetxt.Value = new System.DateTime(2017, 10, 19, 0, 0, 0, 0);
            this.StartTimetxt.ValueChanged += new System.EventHandler(this.StartTimetxt_ValueChanged);
            // 
            // EndTimetxt
            // 
            this.EndTimetxt.CustomFormat = "\"dd-MMM-yyyy HH:mm:ss\"";
            this.EndTimetxt.Location = new System.Drawing.Point(98, 76);
            this.EndTimetxt.Name = "EndTimetxt";
            this.EndTimetxt.Size = new System.Drawing.Size(209, 22);
            this.EndTimetxt.TabIndex = 17;
            // 
            // AchiveRepoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repoTypeBox);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.Successtxt);
            this.Controls.Add(this.ReprecoessQueuebtn);
            this.Controls.Add(this.TimeFrameGrp);
            this.Controls.Add(this.ArchFiletxt);
            this.Controls.Add(this.ArchFilelbl);
            this.Controls.Add(this.Queuefiletxt);
            this.Controls.Add(this.QueueFilelbl);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.Inputs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AchiveRepoTool";
            this.Text = "Archive Reprocessing Tool";
            this.TimeFrameGrp.ResumeLayout(false);
            this.TimeFrameGrp.PerformLayout();
            this.VersionBox.ResumeLayout(false);
            this.VersionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inputs;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label QueueFilelbl;
        private System.Windows.Forms.TextBox Queuefiletxt;
        private System.Windows.Forms.Label ArchFilelbl;
        private System.Windows.Forms.TextBox ArchFiletxt;
        private System.Windows.Forms.GroupBox TimeFrameGrp;
        private System.Windows.Forms.Label EndTimelbl;
        private System.Windows.Forms.Label StartTimelbl;
        private System.Windows.Forms.Button ReprecoessQueuebtn;
        private System.Windows.Forms.Label Successtxt;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.GroupBox VersionBox;
        private System.Windows.Forms.RadioButton OldVersionBtn;
        private System.Windows.Forms.RadioButton NewVersionBtn;
        private System.Windows.Forms.ComboBox repoTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartTimetxt;
        private System.Windows.Forms.DateTimePicker EndTimetxt;
    }
}

