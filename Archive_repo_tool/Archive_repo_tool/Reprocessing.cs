using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        public string GetCorrupt()
        {
            return corrupt_file_path;
        }

        public void SetCorrupt(string value)
        {

            if (!string.IsNullOrEmpty(value))
                corrupt_file_path = value;
        }

        public string GetArchive()
        {
            return archive_file_path;
        }

        public void SetArchive(string value)
        {

            if (!string.IsNullOrEmpty(value))
                archive_file_path = value;
        }

        public string GetStart()
        {
            return start_time;
        }

        public void SetStart(string value)
        {

            if (!string.IsNullOrEmpty(value))
               start_time = value;
        }

        public string GetEnd()
        {
            return end_time;
        }

        public void SetEnd(string value)
        {

            if (!string.IsNullOrEmpty(value))
                end_time = value;
        }

        public void Archive_Reprocess()
        {
            if (corrupt_file_path.Contains(".dat"))
            {
                string command = "piarchss -evq -evqpath " + corrupt_file_path + " -of " + archive_file_path;
                BIGexitCode = runCommands(command);
            }
            else if (corrupt_file_path.Contains(".arc"))
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

        public void DeleteTempArc()
        {
            string command = "/ C  del /f C:\\Temp.arc";
            BIGexitCode = runCommands(command);
        }

        public string SuccessorFail()
        {
            if (BIGexitCode == 0)
            {
                return "success";
            }
            else
                return "failure";
        }
        
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
