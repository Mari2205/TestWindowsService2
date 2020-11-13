using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestWindowsService2
{
    public static class Library
    {
        public static void WriteErrorLog(Exception exception)
        {
            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                streamWriter.WriteLine(DateTime.Now.ToString() + ": " + exception.Source.ToString().Trim() + "; " + exception.Message.ToString().Trim());
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch
            {
            }
        }

        public static void WriteErrorLog(string message)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                streamWriter.WriteLine(DateTime.Now.ToString() + ": " + message);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch
            {
            }
        }
    }
}
