using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Archive_repo_tool
{
    class Reprocessing
    {
        private string corrupt_file_path = string.Empty;
        private string archive_file_path = string.Empty;
        private string start_time = string.Empty;
        private string end_time = string.Empty;
        private int BIGexitCode;
        private string GUID = string.Empty;

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
        /// Reprocess the Buffer queue file into a temporary arc file located on the C:\ drive 
        /// </summary>
        public void DatToArc()
        {
            if (corrupt_file_path.Contains(".dat"))
            {
                //if Version = 2 then this 
                string command = "piarchss -evq -evqpath " + corrupt_file_path + " -of C:\\Temp.arc";
                BIGexitCode = runCommands(command);
            }
            //if version = 1 then this
            //Parse GUID
            //[‎10/‎5/‎2017 3:58 PM]  Harry Markley:  
           /* string strRegex = @"[A-F0-9]{8}(?:-[A-F0-9]{4}){3}-[A-F0-9]{12}";
            string input = Path.GetFileName(corrupt_file_path);
            Match Match = Regex.Match(input, strRegex, RegexOptions.IgnoreCase);
            if (Match.Success)
            {
                GUID = Match.Value;
            }
            */
        }
        /// <summary>
        /// Reprocess either the corrupted archive or the temporary archive created i the DATtoARC method 
        /// </summary>
        public void Archive_Reprocess()
        {
           if (corrupt_file_path.Contains(".arc"))
            {
                string command = "piarchss -if " + corrupt_file_path + " -of " + archive_file_path + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"";
                BIGexitCode = runCommands(command);
                
            }
            else
            {
                string command = "piarchss -if C:\\Temp.arc -of " + archive_file_path + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"";
                BIGexitCode = runCommands(command);
                DeleteTempArc();
            }
        }
        /// <summary>
        /// Delete the temporary archive that was created in the DAT to ARC method 
        /// </summary>
        public void DeleteTempArc()
        {
            string command = "/ C  del /f C:\\Temp.arc";
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
        /// Create a command line with the %piserver%\adm directory already navigated to
        /// </summary>
        /// <param name="commandToRun"></param>
        /// <returns></returns>
        public int runCommands(string commandToRun)
        {
            string outputString = "Command Didnt Run";
            int exitCode = -1;
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"cd /d %piserver%\bin");
                process.StandardInput.WriteLine(commandToRun);
                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()
                outputString = process.StandardOutput.ReadToEnd();
                exitCode = process.ExitCode;
            }
            return exitCode;

        }

    }
}
