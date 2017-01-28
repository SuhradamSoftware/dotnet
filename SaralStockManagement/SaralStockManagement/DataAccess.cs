using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaralStockManagement
{
    class DataAccess
    {
        public static Int64 gbl_longUserID = 1;
        public static int gbl_longUserTypeID = 0;
        public static string gbl_userName = "";
        public static string gbl_Name = "";
        public static int gbl_height = 0;
        public static int gbl_width = 0;
        public static int gbl_client_height = 0;
        public static int gbl_client_width = 0;
      //static string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\Setting.dll";
      //  public static string con_string = "Data Source=" + path + "; password=Hello123#";
        public static string in_con_string = "";
        public static string db_type = "Legal";
        public static int tlp_main_x = 0;
        public static int tlp_main_y = 0;
    }
}
