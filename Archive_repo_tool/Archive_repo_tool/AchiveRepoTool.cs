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
        //create an instane of BMICalculator
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

        private bool ReadStart()
        {

            DateTime StartTime;

            bool goodNumber = DateTime.TryParse(StartTimetxt.Text, out StartTime); //make sure its a valid number
            if (goodNumber) //true or false
            {

                RepoTool.SetStart(StartTimetxt.Text); //send weight to BMI object
            }
            if (!goodNumber)
                MessageBox.Show("Invalid Start Time Date", "Error"); //if there is an error generate this message box


            return goodNumber;
        }

        private bool ReadEnd()
        {

            DateTime EndTime;

            bool goodNumber = DateTime.TryParse(StartTimetxt.Text, out EndTime); //make sure its a valid number
            if (goodNumber) //true or false
            {

                RepoTool.SetStart(EndTimetxt.Text); //send weight to BMI object
            }
            if (!goodNumber)
                MessageBox.Show("Invalid End Time Date", "Error"); //if there is an error generate this message box


            return goodNumber;
        }

        private bool ReadInputRepo()
        {
            bool ok;
            if (ReadCorruptQueuePath() && ReadDestinationArchvePath() && ReadStart() && ReadEnd())
            {
                ok = true;
            }
            else
                ok = false;
            MessageBox.Show("Please Fill All Fields in accurately", "Error"); //if there is an error generate this message box
            return ok;
        }

        private void ReprecoessQueuebtn_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputRepo(); //make sure that all of the inputs are valid

            if (ok)
            {
                DisplayResults(); //calculate and display results
            }
        }

        private void DisplayResults()
        {
            Successtxt.Text = RepoTool.SuccessorFail();
        }
    }
}
