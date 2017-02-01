using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Transactions;

namespace BillingSystem
{
    public class DataAccess
    {
        public static Int64 gbl_longUserID = 1;
        public static int gbl_longUserTypeID = 0;
        public static string gbl_userName = "";
        public static string gbl_Name = "";
        public static int gbl_height = 0;
        public static int gbl_width = 0;
        public static int gbl_client_height = 0;
        public static int gbl_client_width = 0;
        static string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\BillingSystem.sdf";
        //static string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\Setting.dll";
        public static string con_string = "Data Source=" + path + "; password=Hello123#";
        public static string in_con_string = "";
        public static string db_type = "Legal";
        public static int tlp_main_x = 0;
        public static int tlp_main_y = 0;
    }

    public class DataLayer
    {
        public DataSet bindDataSet(string query)
        {
            DataSet _dataSet = new DataSet();
            SqlCeConnection con = new SqlCeConnection(DataAccess.con_string);
            con.Open();
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
                sda.Fill(_dataSet);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                ErrorLog("Bind data set", ex.Message.ToString());
            }
            return _dataSet;
        }

        public DataTable bindDataTable(string query)
        {
            DataTable _dataTable = new DataTable();
            SqlCeConnection con = new SqlCeConnection(DataAccess.con_string);
            con.Open();
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
                sda.Fill(_dataTable);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                ErrorLog("Bind data table", ex.Message.ToString());
            }
            return _dataTable;
        }

        public string Opration(string query)
        {
            string message = string.Empty;
            using (TransactionScope transScope = new TransactionScope())
            {
                SqlCeConnection con = new SqlCeConnection(DataAccess.con_string);
                con.Open();
                try
                {
                    SqlCeCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    message = "Success";
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    con.Close();
                    ErrorLog("opration", ex.Message.ToString());
                    message = "Error";
                }
            }
            return message;
        }
        public string OprationWithScope(string query)
        {
            string message = string.Empty;
            using (TransactionScope transScope = new TransactionScope())
            {
                SqlCeConnection con = new SqlCeConnection(DataAccess.con_string);
                con.Open();
                try
                {
                    SqlCeCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    var newId = cmd.ExecuteScalar();
                    message = newId.ToString();
                    con.Close();
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    con.Close();
                    ErrorLog("opration", ex.Message.ToString());
                    message = "Error";
                }
            }
            return message;
        }

        public void ErrorLog(string reson, string errorMessage)
        {
            try
            {
                string path = @"Error_Log.txt";
                if (!File.Exists(path))
                {
                    FileStream fs_creat = new FileStream(path, FileMode.Create);
                    fs_creat.Close();
                }

                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter str = new StreamWriter(fs);
                str.BaseStream.Seek(0, SeekOrigin.End);
                str.Write("Reson : " + reson + Environment.NewLine);
                str.WriteLine("Error Message : " + errorMessage);
                str.WriteLine("Date Time : " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                str.WriteLine("----------------------------------------------------------------");
                str.Flush();
                str.Close();
                fs.Close();
            }
            catch (Exception)
            {
                //con.Close();
            }
        }
        public string DateFormat(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;
            else
                return date.Split('/')[2] + "/" + date.Split('/')[1] + "/" + date.Split('/')[0] + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        public string OnlyDateFormat(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;
            else
                return date.Split('/')[2] + "/" + date.Split('/')[1] + "/" + date.Split('/')[0];
        }

        public string DateFormatTime(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;
            else
                return date.Split('/')[2] + "/" + date.Split('/')[1] + "/" + (Convert.ToInt16(date.Split('/')[0])).ToString() + " 00:00:00";
        }
    }

    public class In_DataLayer
    {
        public DataSet bindDataSet(string query)
        {
            DataSet _dataSet = new DataSet();
            SqlCeConnection con = new SqlCeConnection(DataAccess.in_con_string);
            con.Open();
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
                sda.Fill(_dataSet);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                ErrorLog("Bind data set", ex.Message.ToString());
            }
            return _dataSet;
        }

        public DataTable bindDataTable(string query)
        {
            DataTable _dataTable = new DataTable();
            SqlCeConnection con = new SqlCeConnection(DataAccess.in_con_string);
            con.Open();
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
                sda.Fill(_dataTable);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                ErrorLog("Bind data table", ex.Message.ToString());
            }
            return _dataTable;
        }

        public string Opration(string query)
        {
            string message = string.Empty;
            using (TransactionScope transScope = new TransactionScope())
            {
                SqlCeConnection con = new SqlCeConnection(DataAccess.in_con_string);
                con.Open();
                try
                {
                    SqlCeCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    message = "Success";
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    con.Close();
                    ErrorLog("opration", ex.Message.ToString());
                    message = "Error";
                }
            }
            return message;
        }
        public string OprationWithScope(string query)
        {
            string message = string.Empty;
            using (TransactionScope transScope = new TransactionScope())
            {
                SqlCeConnection con = new SqlCeConnection(DataAccess.in_con_string);
                con.Open();
                try
                {
                    SqlCeCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    var newId = cmd.ExecuteScalar();
                    message = newId.ToString();
                    con.Close();
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    con.Close();
                    ErrorLog("opration", ex.Message.ToString());
                    message = "Error";
                }
            }
            return message;
        }

        public void ErrorLog(string reson, string errorMessage)
        {
            try
            {
                string path = @"Error_Log.txt";
                if (!File.Exists(path))
                {
                    FileStream fs_creat = new FileStream(path, FileMode.Create);
                    fs_creat.Close();
                }

                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter str = new StreamWriter(fs);
                str.BaseStream.Seek(0, SeekOrigin.End);
                str.Write("Reson : " + reson + Environment.NewLine);
                str.WriteLine("Error Message : " + errorMessage);
                str.WriteLine("User : " + DataAccess.gbl_longUserID.ToString());
                str.WriteLine("Date Time : " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                str.WriteLine("----------------------------------------------------------------");
                str.Flush();
                str.Close();
                fs.Close();
            }
            catch (Exception)
            {
                //con.Close();
            }
        }
    }
}
