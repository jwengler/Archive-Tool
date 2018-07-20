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
        /// <summary>
        /// Checks symptoms of a corrupt buffer queue (Version 3.4.375.38). Returns whether the archive must be reprocessed.
        /// </summary>
        /// <returns></returns>
        public Boolean CheckSymptoms()
        {

        }

        /// <summary>
        /// Checks to see if the server session is "Registered" uing pibufss -cfg
        /// </summary>
        /// <returns></returns>
        public Boolean CheckRegistered()
        {
            //TODO: add version check for 3.4.375.38
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
    }
}