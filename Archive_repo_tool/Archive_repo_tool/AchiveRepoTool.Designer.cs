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
            this.EndTimetxt = new System.Windows.Forms.TextBox();
            this.StartTimetxt = new System.Windows.Forms.TextBox();
            this.EndTimelbl = new System.Windows.Forms.Label();
            this.StartTimelbl = new System.Windows.Forms.Label();
            this.ReprecoessQueuebtn = new System.Windows.Forms.Button();
            this.Successtxt = new System.Windows.Forms.Label();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.VersionBox = new System.Windows.Forms.GroupBox();
            this.NewVersionBtn = new System.Windows.Forms.RadioButton();
            this.OldVersionBtn = new System.Windows.Forms.RadioButton();
            this.TimeFrameGrp.SuspendLayout();
            this.VersionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inputs
            // 
            this.Inputs.AutoSize = true;
            this.Inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputs.Location = new System.Drawing.Point(13, 13);
            this.Inputs.Name = "Inputs";
            this.Inputs.Size = new System.Drawing.Size(81, 29);
            this.Inputs.TabIndex = 0;
            this.Inputs.Text = "Inputs";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(15, 42);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(145, 13);
            this.warning.TabIndex = 1;
            this.warning.Text = "Remember to take a backup!";
            // 
            // QueueFilelbl
            // 
            this.QueueFilelbl.AutoSize = true;
            this.QueueFilelbl.Location = new System.Drawing.Point(18, 75);
            this.QueueFilelbl.Name = "QueueFilelbl";
            this.QueueFilelbl.Size = new System.Drawing.Size(100, 13);
            this.QueueFilelbl.TabIndex = 2;
            this.QueueFilelbl.Text = "Corrupted File Path:";
            // 
            // Queuefiletxt
            // 
            this.Queuefiletxt.Location = new System.Drawing.Point(124, 72);
            this.Queuefiletxt.Name = "Queuefiletxt";
            this.Queuefiletxt.Size = new System.Drawing.Size(253, 20);
            this.Queuefiletxt.TabIndex = 3;
            // 
            // ArchFilelbl
            // 
            this.ArchFilelbl.AutoSize = true;
            this.ArchFilelbl.Location = new System.Drawing.Point(18, 110);
            this.ArchFilelbl.Name = "ArchFilelbl";
            this.ArchFilelbl.Size = new System.Drawing.Size(146, 13);
            this.ArchFilelbl.TabIndex = 4;
            this.ArchFilelbl.Text = "Destination Archive File Path:";
            // 
            // ArchFiletxt
            // 
            this.ArchFiletxt.Location = new System.Drawing.Point(163, 107);
            this.ArchFiletxt.Name = "ArchFiletxt";
            this.ArchFiletxt.Size = new System.Drawing.Size(302, 20);
            this.ArchFiletxt.TabIndex = 5;
            // 
            // TimeFrameGrp
            // 
            this.TimeFrameGrp.Controls.Add(this.EndTimetxt);
            this.TimeFrameGrp.Controls.Add(this.StartTimetxt);
            this.TimeFrameGrp.Controls.Add(this.EndTimelbl);
            this.TimeFrameGrp.Controls.Add(this.StartTimelbl);
            this.TimeFrameGrp.Location = new System.Drawing.Point(21, 153);
            this.TimeFrameGrp.Name = "TimeFrameGrp";
            this.TimeFrameGrp.Size = new System.Drawing.Size(200, 115);
            this.TimeFrameGrp.TabIndex = 6;
            this.TimeFrameGrp.TabStop = false;
            this.TimeFrameGrp.Text = "Time of Target Archive";
            // 
            // EndTimetxt
            // 
            this.EndTimetxt.Location = new System.Drawing.Point(89, 56);
            this.EndTimetxt.Name = "EndTimetxt";
            this.EndTimetxt.Size = new System.Drawing.Size(100, 20);
            this.EndTimetxt.TabIndex = 3;
            // 
            // StartTimetxt
            // 
            this.StartTimetxt.Location = new System.Drawing.Point(89, 21);
            this.StartTimetxt.Name = "StartTimetxt";
            this.StartTimetxt.Size = new System.Drawing.Size(100, 20);
            this.StartTimetxt.TabIndex = 2;
            // 
            // EndTimelbl
            // 
            this.EndTimelbl.AutoSize = true;
            this.EndTimelbl.Location = new System.Drawing.Point(21, 64);
            this.EndTimelbl.Name = "EndTimelbl";
            this.EndTimelbl.Size = new System.Drawing.Size(55, 13);
            this.EndTimelbl.TabIndex = 1;
            this.EndTimelbl.Text = "End Time:";
            // 
            // StartTimelbl
            // 
            this.StartTimelbl.AutoSize = true;
            this.StartTimelbl.Location = new System.Drawing.Point(18, 29);
            this.StartTimelbl.Name = "StartTimelbl";
            this.StartTimelbl.Size = new System.Drawing.Size(58, 13);
            this.StartTimelbl.TabIndex = 0;
            this.StartTimelbl.Text = "Start Time:";
            // 
            // ReprecoessQueuebtn
            // 
            this.ReprecoessQueuebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReprecoessQueuebtn.Location = new System.Drawing.Point(42, 288);
            this.ReprecoessQueuebtn.Name = "ReprecoessQueuebtn";
            this.ReprecoessQueuebtn.Size = new System.Drawing.Size(151, 32);
            this.ReprecoessQueuebtn.TabIndex = 9;
            this.ReprecoessQueuebtn.Text = "Reprocess";
            this.ReprecoessQueuebtn.UseVisualStyleBackColor = false;
            this.ReprecoessQueuebtn.Click += new System.EventHandler(this.ReprecoessQueuebtn_Click);
            // 
            // Successtxt
            // 
            this.Successtxt.AutoSize = true;
            this.Successtxt.Location = new System.Drawing.Point(262, 298);
            this.Successtxt.Name = "Successtxt";
            this.Successtxt.Size = new System.Drawing.Size(0, 13);
            this.Successtxt.TabIndex = 11;
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(390, 65);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(75, 23);
            this.Browsebtn.TabIndex = 12;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // VersionBox
            // 
            this.VersionBox.Controls.Add(this.OldVersionBtn);
            this.VersionBox.Controls.Add(this.NewVersionBtn);
            this.VersionBox.Location = new System.Drawing.Point(265, 153);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(200, 115);
            this.VersionBox.TabIndex = 13;
            this.VersionBox.TabStop = false;
            this.VersionBox.Text = "Buffer Subsystem Version";
            // 
            // NewVersionBtn
            // 
            this.NewVersionBtn.AutoSize = true;
            this.NewVersionBtn.Location = new System.Drawing.Point(22, 29);
            this.NewVersionBtn.Name = "NewVersionBtn";
            this.NewVersionBtn.Size = new System.Drawing.Size(131, 17);
            this.NewVersionBtn.TabIndex = 0;
            this.NewVersionBtn.TabStop = true;
            this.NewVersionBtn.Text = "Versions 4.3 and Later";
            this.NewVersionBtn.UseVisualStyleBackColor = true;
            // 
            // OldVersionBtn
            // 
            this.OldVersionBtn.AutoSize = true;
            this.OldVersionBtn.Location = new System.Drawing.Point(22, 64);
            this.OldVersionBtn.Name = "OldVersionBtn";
            this.OldVersionBtn.Size = new System.Drawing.Size(117, 17);
            this.OldVersionBtn.TabIndex = 1;
            this.OldVersionBtn.TabStop = true;
            this.OldVersionBtn.Text = "Versions Before 4.3";
            this.OldVersionBtn.UseVisualStyleBackColor = true;
            // 
            // AchiveRepoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 351);
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
        private System.Windows.Forms.TextBox EndTimetxt;
        private System.Windows.Forms.TextBox StartTimetxt;
        private System.Windows.Forms.Label EndTimelbl;
        private System.Windows.Forms.Label StartTimelbl;
        private System.Windows.Forms.Button ReprecoessQueuebtn;
        private System.Windows.Forms.Label Successtxt;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.GroupBox VersionBox;
        private System.Windows.Forms.RadioButton OldVersionBtn;
        private System.Windows.Forms.RadioButton NewVersionBtn;
    }
}

