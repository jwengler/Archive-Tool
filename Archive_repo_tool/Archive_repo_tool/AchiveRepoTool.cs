using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;


namespace Archive_repo_tool
{
    public partial class AchiveRepoTool : MetroForm
    {
        //Global variables
        private String openingFilePath = string.Empty;
        private bool fileStatus = false;
        private string inputPath = string.Empty;
        //create an instane of the GUI
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
            //TODO: could have a button for different PI Server versions 
            //clear inputs
            //ArchFiletxt.Text = string.Empty;
            txtInputFile.Text = string.Empty;
            txtReprocessedFile.Text = string.Empty;
            //mtrBtnBrowseRepo.Enabled = false;
            ReprecoessQueuebtn.Enabled = false;
            StartTimetxt.Format = DateTimePickerFormat.Custom;
            EndTimetxt.Format = DateTimePickerFormat.Custom;
            if (RepoTool.piVersion() == "false") // PI Data Archive is not installed.
            {
                MetroFramework.MetroMessageBox.Show(this, "Data Archive is NOT Installed.", "OSIsoft Reprocessing Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                piVersion.Text = RepoTool.piVersion();
            }
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
                switch (metroTabControl1.SelectedIndex)
                {
                    case 0: // Archive
                        RepoTool.SetRepoType(1);
                        StartTimetxt.Enabled = false;
                        EndTimetxt.Enabled = false;
                        success = true;
                        break;
                    case 1: // Event queue
                        RepoTool.SetRepoType(2);
                        StartTimetxt.Enabled = true;
                        EndTimetxt.Enabled = true;
                        success = true;
                        break;
                    default: // Buffer queue
                        RepoTool.SetRepoType(3);
                        StartTimetxt.Enabled = true;
                        EndTimetxt.Enabled = true;
                        success = true;
                        break;
                }
            }
            else
            {
                success = false;
            }                
            return success;        
        }


        /// <summary>
        /// Send the Corrupt file path on to the Reprocessing.cs
        /// </summary>
        /// <returns> Whether the reading of the path completed successfully. </returns>
        private bool ReadCorruptQueuePath()
        {
            string path = string.Empty;
            
            path = txtInputFile.Text; //Get the contents of the textbox

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
                    catch (Exception e)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid File Selected, Please Select Valid Archive File", "Reprocessing Tool");
                        //Queuefiletxt.Clear();
                        return false;
                    }
                    //ReprecoessQueuebtn.Enabled = true;

                    return true;
                }
                return true;
            }
        }


        /// <summary>
        /// Send the destination path/new archive path on to the backend
        /// </summary>
        /// <returns></returns>
        private bool ReadDestinationArchivePath()
        {
            bool okay;
            string inputArcName = string.Empty;
            string outputPath = string.Empty;
            string inputAnnoFile = string.Empty; //To check input annotation file
            string ouputAnnoFile = string.Empty;
            string ouputArcFile = string.Empty;
            string outputAnnoPath = string.Empty;
            string outputArcPath = string.Empty;

            //Get the contents of the textbox
            inputPath = RepoTool.GetCorrupt();
            //Get the output file path
            outputPath = txtReprocessedFile.Text;

            //archiveName = path.Substring(path.LastIndexOf('\\'), (path.LastIndexOf('.')-1)- path.LastIndexOf('\\')+1);
            inputArcName = inputPath.Substring(inputPath.LastIndexOf('\\') + 1);
            if (inputArcName.Contains(".arc"))
            {
                inputAnnoFile = inputArcName + ".ann";
                ouputAnnoFile = inputArcName.Substring(0, inputArcName.LastIndexOf(".arc")) + "_reprocessed.arc.ann";
                ouputArcFile = inputArcName.Substring(0, inputArcName.LastIndexOf(".arc")) + "_reprocessed.arc";
            }
            else
            {
                inputAnnoFile = inputArcName + ".ann";
                ouputAnnoFile = inputArcName + "_reprocessed.ann";
                ouputArcFile = inputArcName + "_reprocessed";
            }

            openingFilePath = inputPath; // delete this later
            inputPath = inputPath.Substring(0, inputPath.LastIndexOf('\\'));
            inputAnnoFile = inputPath + "\\" + inputAnnoFile;
            inputPath = inputPath + "\\" + inputArcName;
            RepoTool.setRepoFilename(inputArcName.Substring(0, inputArcName.LastIndexOf(".arc")));
            outputArcPath = outputPath + "\\" + ouputArcFile;
            outputAnnoPath = outputPath + "\\" + ouputAnnoFile;

            //Checking whether the reprocessing annotation and archive file exists
            if (!File.Exists(inputAnnoFile))
            {
                MetroFramework.MetroMessageBox.Show(this, "Missing Annotation file!", "Reprocessing Tool | Warning");
                fileStatus = false;
                return fileStatus;
                //System.Windows.Forms.Application.Exit();
            }
            else if (File.Exists(outputArcPath))
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete existing archive file <<" + inputArcName + ">>", "Reprocessing Tool | Warning");
                //System.Windows.Forms.Application.Exit();
                okay = false;
                return okay;
            }
            else if (File.Exists(outputAnnoPath))
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete existing annotation file <<" + ouputAnnoFile + ">>", "Reprocessing Tool | Warning");
                //System.Windows.Forms.Application.Exit();
                okay = false;
                return okay;
            }
            else
            {
                //txtReprocessedFile.Text = inputPath;
                RepoTool.SetOutputArchive(outputArcPath);

                if (string.IsNullOrEmpty(ouputArcFile))
                {
                    return false;
                }
                else
                {
                    return true;
                    //if (ArchFiletxt.Text != Queuefiletxt.Text)
                    //{
                    //    RepoTool.SetArchive(path);
                    //}
                    //else
                    //    MessageBox.Show("Destination Archive path cannot match Corrupt Filename!", "Error"); //if there is an error generate this message box
                }
            }
            //return okay;
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
            if (RepoTool.GetEnd() != "Primary")
            {
                RepoTool.SetEnd(endTimeString); //send start time to the backend 
            }
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
                    MetroFramework.MetroMessageBox.Show(this, "All Corrupt Buffer files in this folder will be reprocessed!");
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
            if ((e.Error != null) || !(RepoTool.readLogfile()))
            {
                //MetroFramework.MetroMessageBox.Show(this, "Failed Reprocessing - Check logs");
                //metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
                //metroLabel1.Text = "Failed Reprocessing - Check Logs";
                mtrlblRepoFailed.Visible = true;
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Do you want to open log file?", "Reprocessing Tool | Failed Reprocessing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Process.Start(RepoTool.setLogFilePath());
                }
            }
            else
            {
                metroLabel1.Visible = true;
            }

            //Queuefiletxt.Clear();

            //ReprecoessQueuebtn.Enabled = true;
            //mtrBtnBrowseRepo.Enabled = true;
        }

        /// <summary>
        /// Does the reprocessing in the backend after the inputs are all checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reprocessQueueBtn_Click(object sender, EventArgs e)
        {
            metroLabel1.Visible = false;
            mtrlblRepoFailed.Visible = false;
            //1 = archive
            //2 = event queue
            //3 = buffer queue
            BackgroundWorker repoThread = new BackgroundWorker();
            repoThread.DoWork += new DoWorkEventHandler(RepoTool.reprocessArchive);
            repoThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_completed);

            if (metroTabControl1.SelectedIndex > -1)
            {
                if (metroTabControl1.SelectedIndex == 0)
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchivePath() && ReadStart() && ReadEnd())
                    {
                        RepoTool.setVersion(0); //Not a buffer queue
                        repoThread.RunWorkerAsync();
                        ReprecoessQueuebtn.Enabled = false;
                        metroLabel1.Visible = false;
                        metroProgressSpinner1.Visible = true;
                        metroProgressSpinner1.Spinning = true;
                        //RepoTool.reprocessArchive();
                        DisplayResults();
                    }
                    else
                    {
                        if (fileStatus == true)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please ensure fields are filled in correctly.");
                        }
                    }
                }
                else if (metroTabControl1.SelectedIndex == 1)
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchivePath() && ReadStart() && ReadEnd())
                    {
                        RepoTool.setVersion(0); //Not a buffer queue
                        RepoTool.DatToArc();
                        DisplayResults();
                    }
                    else
                    {
                        if (ReadDestinationArchivePath() == true)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please ensure fields are filled in correctly.");
                        }
                    }

                }
                else //buffer queue selected
                {
                    if (ReadCorruptQueuePath() && ReadDestinationArchivePath() && ReadStart() && ReadEnd() && ReadVersion())
                    {
                        RepoTool.DatToArc();

                        DisplayResults();
                    }
                    else
                    {
                        if (ReadDestinationArchivePath() == true)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please ensure fields are filled in correctly.");
                        }
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select what you are reprocessing!"); //RepoType not selected
            }

            //ReprecoessQueuebtn.Enabled = false;
        }


        /// <summary>
        /// Display the success or unsuccessful operation (still needs work)
        /// </summary>
        private void DisplayResults()
        {
            Successtxt.Text = RepoTool.SuccessorFail();
        }


        /// <summary>
        /// Browse button to display a list of files - for input and output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            LoadNewFile();
            txtReprocessedFile.Text = String.Empty;
            //mtrBtnBrowseRepo.Enabled = false;
            metroLabel1.Visible = false;
            mtrlblRepoFailed.Visible = false;
        }


        //ADD FILE TYPES//
        private void LoadNewFile() //www.dreamincode.net/forums/topic/241079-browsing-for-a-file-using-openfiledialog
        {

            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true, // Allow user to select multiple files
                Filter = "Archive Files|*.arc|Queues|*.dat|All Files|*.*"
            };
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = ofd.FileName;
                //ListViewItem arcList = new ListViewItem();
                //arcList.SubItems.Add(userSelectedFilePath);
                //ArchiveListView.Items.Add(arcList);
            }
        }


        public string userSelectedFilePath
        {
            get
            {
                return txtInputFile.Text;
            }
            set
            {
                txtInputFile.Text = value;
            }
        }


        private void repoTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadRepoType();
        }


        private void NewVersionBtn_CheckedChanged(object sender, EventArgs e)
        {
            ReadVersion();
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
            //Enabling timer for blinking text
            myTimer.Start();
            myTimer.Enabled = true;
            mtrBtnOutput.Enabled = false;
            mtrlblRepoFailed.Visible = false;
        }


        private void queueFileTxt_Click(object sender, EventArgs e)
        {
            txtInputFile.SelectAll();
        }


        private void txtReprocessedFile_Click(object sender, EventArgs e)
        {
            txtReprocessedFile.SelectAll();
        }


        private void myTimer_Tick(object sender, EventArgs e)
        {
            Random frmRand = new Random();
            int A = frmRand.Next(0, 255);
            int B = frmRand.Next(0, 255);
            int C = frmRand.Next(0, 255);
            int D = frmRand.Next(0, 255);
            lblWarning.ForeColor = Color.FromArgb(A, B, C, D);
        }


        private void MtrBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(openingFilePath);
        }


        private void Browsebtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInputFile.Text))
            {
                mtrBtnOutput.Enabled = true;
            }
            mtrBtnOutput.Enabled = false;
        }


        private void Browsebtn_MouseDown(object sender, MouseEventArgs e)
        {
            txtInputFile.Clear();
            txtReprocessedFile.Clear();

        }


        private string getBrowserPath()
        {
            string inputPath = RepoTool.GetCorrupt();
            inputPath = inputPath.Substring(0, inputPath.LastIndexOf('\\'));
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.SelectedPath = inputPath;
            string repoPath = string.Empty;
            if (browser.ShowDialog() == DialogResult.OK)
            {
                repoPath = browser.SelectedPath;
            }
            return repoPath;
        }


        private void mtrBtnOutput_Click(object sender, EventArgs e)
        {
            metroLabel1.Visible = false;
            mtrlblRepoFailed.Visible = false;
            txtReprocessedFile.Text = getBrowserPath();
            RepoTool.SetOutputPath(txtReprocessedFile.Text);
        }


        private void mtrBtnOutput_MouseUp(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReprocessedFile.Text))
            {
                ReprecoessQueuebtn.Enabled = true;
            }
            else
            {
                ReprecoessQueuebtn.Enabled = false;
            }
        }


        private void ArchFilelbl_Click(object sender, EventArgs e)
        {

        }


        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
