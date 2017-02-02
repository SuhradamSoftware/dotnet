using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SetRights
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                RightsProvider provider = new RightsProvider();
                string sourceFile = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                string path_1 = System.IO.Path.Combine(sourceFile, "Setting.dll");
                provider.SetAccessRights(path_1);
                string path_2 = System.IO.Path.Combine(sourceFile, "Error_Log.txt");
                provider.SetAccessRights(path_2);
                string path_4 = System.IO.Path.Combine(sourceFile, "localLogFile.bat");
                provider.SetAccessRights(path_4);
                string path_7 = System.IO.Path.Combine(sourceFile, "StockGenerator.bat");
                provider.SetAccessRights(path_7);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
