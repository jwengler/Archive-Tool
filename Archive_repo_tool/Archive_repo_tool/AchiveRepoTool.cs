﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Archive_repo_tool
{
    public partial class AchiveRepoTool : MetroForm
    {
        //create an instane of teh GUI
        private Reprocessing RepoTool = new Reprocessing();

        public AchiveRepoTool()
        {
            InitializeComponent();
            InitializeGUI(); //My Initialization
            
        }

        private void InitializeGUI()
        {
            this.Text = "Reprocessing Tool"; //This = the current class or MainForm

            //input controls
            //could have a button for different PI Server versions 
            //clear inputs
            //ArchFiletxt.Text = string.Empty;
            Queuefiletxt.Text = string.Empty;

            StartTimetxt.Format = DateTimePickerFormat.Custom;
            EndTimetxt.Format = DateTimePickerFormat.Custom;
            if (RepoTool.piVersion() == "false")
            {
                MetroFramework.MetroMessageBox.Show(this, "Data Archive is NOT Installed.","OSISoft Reprocessing Tool",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            piVersion.Text = RepoTool.piVersion();
            //output controls
            Successtxt.Text = string.Empty;
        }
        /// <summary>
        /// Checks to see which radio button for version is checked
        /// </summary>
        /// <returns></returns>
        private bool ReadRepoType()
        {
            bool success;
            if (metroTabControl1.SelectedIndex > -1)
            {                
                //1 = archive
                //2 = event queue
                //3 = buffer queue
                if (metroTabControl1.SelectedIndex == 0)
                {
                    RepoTool.SetRepoType(1);
                    StartTimetxt.Enabled = false;
                    EndTimetxt.Enabled = false;
                    success = true;
                }
                else if (metroTabControl1.SelectedIndex == 1)
                {
                    RepoTool.SetRepoType(2);
                    StartTimetxt.Enabled = true;
                    EndTimetxt.Enabled = true;
                    success = true;
                }
                else //buffer queue selected
                {
                    RepoTool.SetRepoType(3);
                    StartTimetxt.Enabled = true;
                    EndTimetxt.Enabled = true;
                    success = true;
                }
                return success;
            }
            else
            {
                success = false;
                return success;
            }      
        }
        /// <summary>
        /// Send the Corrupte file path on to the Reprocessing.cs
        /// </summary>
        /// <returns></returns>
        private bool ReadCorruptQueuePath()
        {
            bool okay = true;
            string path = string.Empty;
            //Get the contents of the textbox

            path = Queuefiletxt.Text;

            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            else
            {
                RepoTool.SetCorrupt(path);
                if (RepoTool.GetRepoType() == 1)
                {
                    try
                    {
                        RepoTool.parseArchiveStartEnd();
                        StartTimetxt.Value = Convert.ToDateTime(RepoTool.GetStart());
                        if (RepoTool.GetEnd() != "Primary")
                            EndTimetxt.Value = Convert.ToDateTime(RepoTool.GetEnd());
                    }
                    catch(Exception e)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid File Selected, Please Select Valid Archive File","Reprocessing Tool");
                        Queuefiletxt.Clear();         
                    }                    
                }
            }
            return okay;
        }
        /// <summary>
        /// Send the destination path/new archive path on to the backend
        /// </summary>
        /// <returns></returns>
        private bool ReadDestinationArchvePath()
        {
            bool okay = true;
            string archiveName = string.Empty;
            string path = string.Empty;
            //Get the contents of the textbox

            path = RepoTool.GetCorrupt();
            archiveName = path.Substring(path.LastIndexOf('\\'), (path.LastIndexOf('.')-1)- path.LastIndexOf('\\')+1);
            archiveName = archiveName + "_reprocessed.arc";
            path = path.Substring(0, path.LastIndexOf('\\'));
            path = path + archiveName;
            
            RepoTool.SetArchive(path);

            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            else
            {
                //if (ArchFiletxt.Text != Queuefiletxt.Text)
                //{
                //    RepoTool.SetArchive(path);
                //}
                //else
                //    MessageBox.Show("Destination Archive path cannot match Corrupt Filename!", "Error"); //if there is an error generate this message box
            }
            return okay;
        }
        /// <summary>
        /// Read the start time of the input archive file
        /// </summary>
        /// <returns></returns>
        private bool ReadStart()
        {
            String startTimeString = StartTimetxt.Value.ToString("dd-MMM-yyyy HH:mm:ss");         
            RepoTool.SetStart(startTimeString); //send start time to the backend 
            return true;
        }
        /// <summary>
        /// Read the end time of the input archive file
        /// </summary>
        /// <returns></returns>
        private bool ReadEnd()
        {
            String endTimeString = EndTimetxt.Value.ToString("dd-MMM-yyyy HH:mm:ss");
            if(RepoTool.GetEnd() != "Primary")
            RepoTool.SetEnd(endTimeString); //send start time to the backend 
            return true;
        }
        /// <summary>
        /// Checks to see which radio button for version is checked
        /// </summary>
        /// <returns></returns>
        private bool ReadVersion()
        {
            bool success;
            if (metroTabControl1.SelectedIndex == 2)
            {
                if (OldVersionBtn.Checked == true && NewVersionBtn.Checked == false) //Versions before 4.3 
                {
                    RepoTool.setVersion(1);                    
                    success = true;                    
                }
                else if (OldVersionBtn.Checked == false && NewVersionBtn.Checked == true) //Version 4.3 and later
                {
                    RepoTool.setVersion(2);
                    MessageBox.Show("All Corrupt Buffer files in this folder will be reprocessed!");
                    success = true;
                }
                else //no radio button selected
                {
                    RepoTool.setVersion(0);
                    success = true;
                }
                return success;
            }
            else return false;
        }
        private void worker_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressSpinner1.Spinning = false;
            metroProgressSpinner1.Visible = false;
            if (e.Error != null)
            {
                metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
                metroLabel1.Text = "Failed Reprocessing - Check Logs";                            
            }
            metroLabel1.Visible = true;

            ReprecoessQueuebtn.Enabled = true;
        }
        /// <summary>
        /// Does the reprocessing in the backend after the inputs are all checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReprecoessQueuebtn_Click(object sender, EventArgs e)
        {
            //1 = archive
            //2 = event queue
            //3 = buffer queue
            BackgroundWorker repoThread = new BackgroundWorker();
            repoThread.DoWork += new DoWorkEventHandler(RepoTool.Archive_Reprocess);
            repoThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_completed);

            if (metroTabControl1.SelectedIndex > -1)
            {
                if (metroTabControl1.SelectedIndex == 0)
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchvePath() && ReadStart() && ReadEnd())
                    {
                        RepoTool.setVersion(0); //Not a buffer queue
                        repoThread.RunWorkerAsync();
                        ReprecoessQueuebtn.Enabled = false;
                        metroLabel1.Visible = false;
                        metroProgressSpinner1.Visible = true;
                        metroProgressSpinner1.Spinning = true;
                        //RepoTool.Archive_Reprocess();
                        DisplayResults();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please ensure fields are filled in correctly.");
                    }
                }
                else if (metroTabControl1.SelectedIndex == 1)
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchvePath() && ReadStart() && ReadEnd())
                    {
                        RepoTool.setVersion(0); //Not a buffer queue
                        RepoTool.DatToArc();
                        DisplayResults();
                    }
                    else
                    {
                        MessageBox.Show("Please ensure fields are filled in correctly.");
                    }

                }
                else //buffer queue selected
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchvePath() && ReadStart() && ReadEnd() && ReadVersion())
                    {
                       RepoTool.DatToArc();
                    
                       DisplayResults();
                    }
                    else
                    {
                        MessageBox.Show("Please ensure fields are filled in correctly.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select what you are reprocessing!"); //RepoType not selected
            }
        }
        /// <summary>
        /// Display the success or unsuccessful operation (still needs work)
        /// </summary>
        private void DisplayResults()
        {
            Successtxt.Text = RepoTool.SuccessorFail();
        }

        /// <summary>
        /// This is the browse button that was added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }
        //ADD FILE TYPES//
        private void LoadNewFile() //www.dreamincode.net/forums/topic/241079-browsing-for-a-file-using-openfiledialog
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archive Files|*.arc|Queues|*.dat|All Files|*.*";
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
           
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = ofd.FileName;
            }
        }
        public string userSelectedFilePath
        {
            get
            {
                return Queuefiletxt.Text;
            }
            set
            {
                Queuefiletxt.Text = value;
            }
        }

        private void repoTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadRepoType();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewVersionBtn_CheckedChanged(object sender, EventArgs e)
        {
            ReadVersion();
        }

        private void StartTimetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void warning_Click(object sender, EventArgs e)
        {

        }

        private void Queuefiletxt_TextChanged(object sender, EventArgs e)
        {
            ReadCorruptQueuePath();
        }

        private void AchiveRepoTool_Load(object sender, EventArgs e)
        {
            //Init metro theme
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
       
        }

        private void archiveTab_Click(object sender, EventArgs e)
        {

        }

        private void Browsebtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Queuefiletxt_Click(object sender, EventArgs e)
        {
            Queuefiletxt.SelectAll();
        }

        private void ArchFiletxt_Click(object sender, EventArgs e)
        {

        }
    }
}
