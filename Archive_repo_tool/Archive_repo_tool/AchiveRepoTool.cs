using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive_repo_tool
{
    public partial class AchiveRepoTool : Form
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
            ArchFiletxt.Text = string.Empty;
            Queuefiletxt.Text = string.Empty;

            StartTimetxt.Text = "01-Jan-1900 HH:MM:SS";
            EndTimetxt.Text = "01-Jan-1900 HH:MM:SS";


            //output controls
            Successtxt.Text = string.Empty;


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
                RepoTool.SetCorrupt(path);

            return okay;
        }
        /// <summary>
        /// Send the destination path/new archive path on to the backend
        /// </summary>
        /// <returns></returns>
        private bool ReadDestinationArchvePath()
        {
            bool okay = true;
            string path = string.Empty;
            //Get the contents of the textbox

            path = ArchFiletxt.Text;

            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            else
                RepoTool.SetArchive(path);

            return okay;
        }
        /// <summary>
        /// Read the start time of the input archive file
        /// </summary>
        /// <returns></returns>
        private bool ReadStart()
        {

            DateTime StartTime;

            bool goodNumber = DateTime.TryParse(StartTimetxt.Text, out StartTime); //make sure its a valid number
            if (goodNumber) //true or false
            {

                RepoTool.SetStart(StartTimetxt.Text); //send start time to the backend 
            }
            if (!goodNumber)
                MessageBox.Show("Invalid Start Time Date", "Error"); //if there is an error generate this message box


            return goodNumber;
        }
        /// <summary>
        /// Read the end time of the input archive file
        /// </summary>
        /// <returns></returns>
        private bool ReadEnd()
        {

            DateTime EndTime;

            bool goodNumber = DateTime.TryParse(EndTimetxt.Text, out EndTime); //make sure its a valid number
            if (goodNumber) //true or false
            {

                RepoTool.SetEnd(EndTimetxt.Text); //send endtime
            }
            if (!goodNumber)
                MessageBox.Show("Invalid End Time Date", "Error"); //if there is an error generate this message box


            return goodNumber;
        }
        /// <summary>
        /// This method checks all inputs to make sure that they are valid
        /// </summary>
        /// <returns></returns>
        private bool ReadInputRepo()
        {
            bool ok;
            if (ReadCorruptQueuePath() && ReadDestinationArchvePath() && ReadStart() && ReadEnd())
            {
                ok = true;
            }
            else
            {
                ok = false;
                MessageBox.Show("Please Fill All Fields in accurately", "Error"); //if there is an error generate this message box

            }
            return ok;
        }
        /// <summary>
        /// Does the reprocessing in the backend after the inputs are all checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReprecoessQueuebtn_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputRepo(); //make sure that all of the inputs are valid

            if (ok)
            {
                RepoTool.DatToArc();
                RepoTool.Archive_Reprocess();
                DisplayResults(); //calculate and display results
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
        private void LoadNewFile() //www.dreamincode.net/forums/topic/241079-browsing-for-a-file-using-openfiledialog
        {
            OpenFileDialog ofd = new OpenFileDialog();
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
        //Need to add code for the radio button. Need to figure out how to parse the buffer GUID from the file path. 
    }
}
