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
            OutputFiletxt.Text = string.Empty;



            //output controls
            Successtxt.Text = string.Empty;


        }




    }
}
