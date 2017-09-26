using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive_repo_tool
{
    class Reprocessing
    {
        private string corrupt_file_path = string.Empty;
        private string archive_file_path = string.Empty;
        private string start_time = string.Empty;
        private string end_time = string.Empty;


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

        public void DatToArc()
        {
            if (corrupt_file_path.Contains(".dat"))
            {
                //string strCmdText;
                //strCmdText = "/C piarchss.exe -evq -if " + corrupt_file_path + " -of C:\Temp.arc";

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/ C cd /d %piserver%\adm " +
                    "&piarchss.exe - evq -if " + corrupt_file_path + " - of C:\\Temp.arc";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                int exitCode = process.ExitCode; 
            }
          
        }

        public void Archive_Reprocess()
        {
            if (corrupt_file_path.Contains(".arc"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/ C cd /d %piserver%\adm " +
                    "&piarchss -if " + corrupt_file_path + " -of " + archive_file_path + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                int exitCode = process.ExitCode;

            }
            else
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/ C  cd /d %piserver%\adm " +
                    "&piarchss -if C:\\Temp.arc -of " + archive_file_path + " -ost \"" + start_time + "\" -oet \"" + end_time + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                int exitCode = process.ExitCode;
                DeleteTempArc();
            }


        }

        public void DeleteTempArc()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/ C  del /f C:\\Temp.arc";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            int exitCode = process.ExitCode;
        }


    }
}
