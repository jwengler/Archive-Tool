using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive_repo_tool
{
    class Reprocessing
    {
        private string corrupt_file_path = string.Empty;
        private string archive_file_path = string.Empty;
        private string start_time = string.Empty;
        private string end_time = string.Empty;
        private int version;
        private DateTime archiveStart;
        private DateTime archiveEnd;
        private int BIGexitCode;
        private string GUID = string.Empty;
        private int repoType = 1;
        private string userDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        

        //MultiThreading So GUI Doesnt freeze while archive is reprocessing
      
        /// <summary>
        /// Get corrupt file path
        /// </summary>
        /// <returns></returns>
        public int GetRepoType()
        {
            return repoType;
        }
        /// <summary>
        /// Sets the Reprocessing Type
        /// 1 = Archive
        /// 2 = Event queue
        /// 3 = Buffer queue
        /// <param name="value"></param>
        public void SetRepoType(int type)
        {
            repoType = type;
        }

        /// <summary>
        /// Get corrupt file path
        /// </summary>
        /// <returns></returns>
        public string GetCorrupt()
        {
            return corrupt_file_path;
        }
        /// <summary>
        /// Set that path into a local variable 
        /// </summary>
        /// <param name="value"></param>
        public void SetCorrupt(string value)
        {

            if (!string.IsNullOrEmpty(value))
                corrupt_file_path = value;
        }
        /// <summary>
        /// Get the destination archive/new archive file path
        /// </summary>
        /// <returns></returns>
        public string GetArchive()
        {
            return archive_file_path;
        }
        /// <summary>
        /// Set the destination archive/new archive file path into a local variable 
        /// </summary>
        /// <param name="value"></param>
        public void SetArchive(string value)
        {

            if (!string.IsNullOrEmpty(value))
                archive_file_path = value;
        }
        /// <summary>
        /// Get the start time of the archive from the GUI
        /// </summary>
        /// <returns></returns>
        public string GetStart()
        {
            return start_time;
        }
        /// <summary>
        /// Set the start time into a local variable 
        /// </summary>
        /// <param name="value"></param>
        public void SetStart(string value)
        {

            if (!string.IsNullOrEmpty(value))
               start_time = value;
        }
        /// <summary>
        /// Get the end time from the GUI
        /// </summary>
        /// <returns></returns>
        public string GetEnd()
        {
            return end_time;
        }
        /// <summary>
        /// Set the end time
        /// </summary>
        /// <param name="value"></param>
        public void SetEnd(string value)
        {

            if (!string.IsNullOrEmpty(value))
                end_time = value;
        }
        /// <summary>
        /// Get the buffer version
        /// </summary>
        /// <returns></returns>
        public int getVersion()
        {
            return version;
        }
        /// <summary>
        /// set the  buffer version
        /// </summary>
        /// <param name="value"></param>
        public void setVersion(int value)
        {
                version = value;
        }
        /// <summary>
        /// Get Archive Start and End Time 
        /// </summary>
        public void parseArchiveStartEnd()
        {
            string version;
            string command = "pidiag -ahd " + "\""+ corrupt_file_path + "\"";
            version = runCommandadm(command);          
                start_time = version.Substring(version.IndexOf("Start Time:") + 12, version.IndexOf("End Time:") - version.IndexOf("Start Time:") - 23);

                end_time = version.Substring(version.IndexOf("End Time:") + 10, version.IndexOf("Backup Time:") - version.IndexOf("End Time:") - 18);

                if (end_time == "Current Time")
                    end_time = "Primary";           
        }
        /// <summary>
        /// Reprocess the Buffer queue file into a temporary arc file located on the C:\ drive 
        /// </summary>
        public void DatToArc()
        {
            if (corrupt_file_path.Contains(".dat"))
            {
                //Buffer < 4.3 and event queues step 1
                if (version == 1)
                {
                    string command = "piarchss -evq -evqpath " + "\"" + corrupt_file_path + "\"" + " -of "+ userDesktopPath  + "\\Temp.arc" + " >" + userDesktopPath + "\\DatToArcLog.txt";
                   // Archive_Reprocess(); //reprocess temp archive into destination archive
                    BIGexitCode = runCommands(command);
                }
            
                //Parse GUID
                //[‎10/‎5/‎2017 3:58 PM]  Harry Markley:  
                //Buffer > 4.3 first step
                else if (version == 2 || version == 0)
                {
                    string strRegex = @"[A-F0-9]{8}(?:-[A-F0-9]{4}){3}-[A-F0-9]{12}";
                    string input = Path.GetFileName(corrupt_file_path);
                    string truncatedPath = corrupt_file_path;
                    Match Match = Regex.Match(input, strRegex, RegexOptions.IgnoreCase);
                    if (Match.Success)
                    {
                        GUID = Match.Value;
                    }
                    else
                    {
                        MessageBox.Show("Cant find buffer queue guid in filename!", "Error"); //if there is an error generate this message box
                    }
                    truncatedPath = corrupt_file_path.Substring(0, corrupt_file_path.Length-52);
                    string command = "piarchss -evq -evqpath " + "\"" + truncatedPath + "\\" + "\"" + " -bufss "+GUID+" -of " + userDesktopPath + "\\Temp.arc" + " >" + userDesktopPath+ "\\DatToArcLog.txt";
                    BIGexitCode = runCommands(command);
                    //Archive_Reprocess();

                }
            }
        }
        /// <summary>
        /// Reprocess either the corrupted archive or the temporary archive created i the DATtoARC method 
        /// </summary>
        public void Archive_Reprocess(object sender, DoWorkEventArgs e)
        {
           
            //Corrupt Archive
           if (corrupt_file_path.Contains(".arc"))
            {
                string command = "piarchss -if " + "\"" + corrupt_file_path + "\"" + " -of " + "\"" + archive_file_path + "\"" + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"" + " >" + userDesktopPath + "\\Reprocess.txt";
                BIGexitCode = runCommands(command);                
            }
           //Buffer and Event Queue second step 
            else
            {
                string command = "piarchss -if "+userDesktopPath + "\\Temp.arc -of " + "\"" + archive_file_path + "\"" + "\\Temp.arc" + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"" + " >" + userDesktopPath + "\\Reprocess.txt";
                BIGexitCode = runCommands(command);
                DeleteTempArc();
            }
        }
        /// <summary>
        /// Delete the temporary archive that was created in the DAT to ARC method 
        /// </summary>
        public void DeleteTempArc()
        {
            string command = "/ C  del /f " +userDesktopPath + "\\Temp.arc";
            BIGexitCode = runCommands(command);
        }
        /// <summary>
        /// Print out wether the operation was successful or not
        /// </summary>
        /// <returns></returns>
        public string SuccessorFail()
        {
            if (BIGexitCode == 0)
            {
                return "success";
            }
            else
                return "failure";
        }
        /// <summary>
        /// Get PI Server Version
        /// </summary>
        /// <returns></returns>
        public string piVersion()
        {
            string version;
            string command = "pidiag -v";
            try
            {
                version = runCommandadm(command);
                version = version.Substring(version.IndexOf("Version:"), version.IndexOf("\r\nProgram:") - version.IndexOf("Version:"));
                version = "Installed Data Archive " + version;
            }
            catch(Exception ex)
            {

                version = "false";

            }
           
            return version;
        }
        /// <summary>
        /// Create a command line with the %piserver%\adm directory already navigated to
        /// </summary>
        /// <param name="commandToRun"></param>
        /// <returns></returns>
        public int runCommands(string commandToRun) //bin folder
        {
            string commandOutput = "Command Didnt Run";
            int exitCode = -1;
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.Arguments = "/user:\"Administrator\"";
            processStartInfo.Verb = "runas"; //Run CMD as Admin
            processStartInfo.CreateNoWindow = true;
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"cd /d %piserver%\bin");
                process.StandardInput.WriteLine(commandToRun);
                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()
                commandOutput = process.StandardOutput.ReadToEnd();
                exitCode = process.ExitCode;
            }
            return exitCode;

        }
        public string runCommandadm(string commandToRun) //adm folder
        {
            string commandOutput = "Command Didnt Run";
            int exitCode = -1;
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.Verb = "runas"; //Run CMD as Admin
            processStartInfo.CreateNoWindow = true;
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"cd /d %piserver%\adm");
                process.StandardInput.WriteLine(commandToRun);
                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()
                commandOutput = process.StandardOutput.ReadToEnd();                
                exitCode = process.ExitCode;
            }
            return commandOutput;

        }

    }
}
