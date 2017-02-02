using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Security.Cryptography;

namespace BillingSystem
{
    public partial class frmMain : Form
    {
        DataLayer _datalayer = new DataLayer();
        string companyName = "";
        string companyAddress1 = "";
        string companyAddress2 = "";
        string companyPhone = "";
        string companyEmail = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuInvoice_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frmInvoice>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmInvoice _frmInvoice = new frmInvoice();
                _frmInvoice.MdiParent = this;
                _frmInvoice.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_master _frmSettinge = new frm_master();
                _frmSettinge.MdiParent = this;
                _frmSettinge.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StartBackUp();

            string guid = Guid.NewGuid().ToString();
            DataAccess.gbl_height = Screen.PrimaryScreen.WorkingArea.Height;
            DataAccess.gbl_width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = DataAccess.gbl_height;
            this.Width = DataAccess.gbl_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            tlp_footer.Width = DataAccess.gbl_width;

            int main_height = tlp_main.Height + tlp_footer.Height + 8;
            int main_width = Screen.PrimaryScreen.WorkingArea.Width;

            DataAccess.gbl_client_height = DataAccess.gbl_height - main_height;
            DataAccess.gbl_client_width = DataAccess.gbl_width - 6;

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
            string[]  Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();
            labelCompany.Text = companyName;
            //lblCompanyPhone.Text = "PH : " + companyPhone;
            this.Text = companyName + " Billing System";
        }

        public void StartBackUp()
        {
            string sourceFile = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string check_path = System.IO.Path.Combine(sourceFile, "Setting.dll");
            Int64 backup_time = 0;
            if (File.Exists(check_path))
            {
                DataTable _dtBackUp = _datalayer.bindDataTable("SELECT fld_value FROM [Default] where (fld_default_name = 'BackUp')");
                if (_dtBackUp.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(_dtBackUp.Rows[0]["fld_value"].ToString()))
                    {
                        DataTable _dtBackUpTime = _datalayer.bindDataTable("SELECT fld_value FROM [Default] where (fld_default_name = 'BackUpTime')");
                        if (_dtBackUpTime.Rows.Count > 0)
                        {
                            backup_time = Convert.ToInt64(_dtBackUpTime.Rows[0]["fld_value"].ToString());
                        }
                    }
                }
            }

            if (backup_time != 0)
            {
                var timer = new System.Threading.Timer(c => ThreadProcess(), null, TimeSpan.Zero, TimeSpan.FromMinutes(backup_time));
            }
        }

        static void ThreadProcess()
        {
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    BackUp();
                }
            ));
            backgroundThread.Start();
        }

        static void BackUp()
        {
            try
            {
                string sourceFile = System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Setting.dll");

                string[] drives = System.IO.Directory.GetLogicalDrives();
                foreach (string str in drives)
                {
                    DataLayer _datalayer = new DataLayer();
                    DataTable _dtBackUpMain = _datalayer.bindDataTable("SELECT fld_value FROM [Default] where (fld_default_name = 'FolderMain')");
                    string path = str + _dtBackUpMain.Rows[0]["fld_value"].ToString();
                    if (!Directory.Exists(path))
                    {
                        if (str == "D:\\" || str == "E:\\")
                            Directory.CreateDirectory(path);
                    }

                    if (Directory.Exists(path))
                    {
                        DataTable _dtBackUpSub = _datalayer.bindDataTable("SELECT fld_value FROM [Default] where (fld_default_name = 'FolderSub')");
                        string Inner_Path = path + @"\" + _dtBackUpSub.Rows[0]["fld_value"].ToString();
                        if (!Directory.Exists(Inner_Path))
                        {
                            if (str == "D:\\" || str == "E:\\")
                                Directory.CreateDirectory(Inner_Path);
                        }

                        if (Directory.Exists(Inner_Path))
                        {
                            string DateDirectory = Inner_Path + @"\" + DateTime.Now.ToString("dd-MM-yyyy");
                            if (!Directory.Exists(DateDirectory))
                            {
                                Directory.CreateDirectory(DateDirectory);
                            }

                            if (Directory.Exists(DateDirectory))
                            {
                                string destinationFile = DateDirectory + @"\" + DateTime.Now.ToString("HH-mm-ss");
                                Encrypt(destinationFile, sourceFile);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog("BackUp", ex.Message.ToString());
            }
        }

        //Encrypt Database
        static void Encrypt(string inputFilePath, string outputfilePath)
        {
            try
            {
                string EncryptionKey = "QWP9OASLK0ZXM0N4TGB99DF7EI6KCG";
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (FileStream fsOutput = new FileStream(inputFilePath, FileMode.Create))
                    {
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsInput = new FileStream(outputfilePath, FileMode.Open))
                            {
                                int data;
                                while ((data = fsInput.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog("Encrypt", ex.Message.ToString());
            }
        }

        static void ErrorLog(string reson, string errorMessage)
        {
            try
            {
                string path = @"Error_Thread.txt";
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

        private void MenuCustomer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_customer_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_customer_master formInvoice = new frm_customer_master();
                formInvoice.MdiParent = this;
                formInvoice.Show();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_Product_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_Product_master formInvoice = new frm_Product_master();
                formInvoice.MdiParent = this;
                formInvoice.Show();
            }
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_transaction>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_transaction formtransaction = new frm_transaction();
                formtransaction.MdiParent = this;
                formtransaction.Show();
            }
        }

        public static void SetFolderPermission(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();
            var currentUserIdentity = WindowsIdentity.GetCurrent();
            var fileSystemRule = new FileSystemAccessRule(currentUserIdentity.Name,
                                                          FileSystemRights.Read,
                                                          InheritanceFlags.ObjectInherit |
                                                          InheritanceFlags.ContainerInherit,
                                                          PropagationFlags.None,
                                                          AccessControlType.Allow);

            directorySecurity.AddAccessRule(fileSystemRule);

        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
