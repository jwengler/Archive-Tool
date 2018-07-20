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
    class CheckSymptoms
    {
        private HashSet<string> months = new HashSet<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                                             "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        /// <summary>
        /// Checks symptoms of a corrupt buffer queue (Version 3.4.375.38). Returns whether the archive must be reprocessed.
        /// </summary>
        /// <returns></returns>
        public Boolean CheckSymptoms()
        {
            //TODO: add version check for 3.4.375.38
        }

        /// <summary>
        /// Checks to see if the server session is "Registered" uing pibufss -cfg
        /// </summary>
        /// <returns></returns>
        public Boolean CheckRegisteredServerSession()
        {
            string command = "pibufss -cfg > out.txt";
            int exitCode = runCommands(command);
            try
            {
                using (var fileStream = File.OpenRead(strOutputLogFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 1024))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Contains("Registered"))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public Boolean CheckRegisteredBufferSession()
        {
            string command = "piartool -bfs > out.txt";
            string output = runCommand(command);
            try
            {
                using (var fileStream = File.OpenRead(strOutputLogFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 1024))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Contains("RegistrationTime"))
                        {
                            string m = line.substring(28, 3);
                            if (months.Contains(m)) // valid time for buffer queue registered
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                return false;
            }
            return false;
        }

    
    }
}
