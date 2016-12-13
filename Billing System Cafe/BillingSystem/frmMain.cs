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

namespace BillingSystem
{
    public partial class frmMain : Form
    {
        string companyName = "";
        string companyAddress1 = "";
        string companyAddress2 = "";
        string companyPhone = "";
        string companyEmail = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (!Application.OpenForms.OfType<frmSetting>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmSetting _frmSettinge = new frmSetting();
                _frmSettinge.MdiParent = this;
                _frmSettinge.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            string guid = Guid.NewGuid().ToString();
            DataAccess.gbl_height = Screen.PrimaryScreen.WorkingArea.Height;
            DataAccess.gbl_width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = DataAccess.gbl_height;
            this.Width = DataAccess.gbl_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            tlp_footer.Width = DataAccess.gbl_width;

            int main_height = panel3.Height + menuStrip1.Height + tlp_footer.Height + 8;
            int main_width = Screen.PrimaryScreen.WorkingArea.Width;

            DataAccess.gbl_client_height = DataAccess.gbl_height - main_height;
            DataAccess.gbl_client_width = DataAccess.gbl_width - 6;

            string path = System.AppDomain.CurrentDomain.BaseDirectory;

            if (System.IO.File.Exists(path + "\\Details.txt"))
            {
                SetAccessRights(path + "\\Details.txt");
            }

            if (System.IO.File.Exists(path + "\\InvoiceNumber.txt"))
            {
                SetAccessRights(path + "\\InvoiceNumber.txt");
            }

            if (System.IO.File.Exists(path + "\\BillingSystem.sdf"))
            {
                SetAccessRights(path + "\\BillingSystem.sdf");
            }

            if (System.IO.File.Exists(path + "\\Setting.dll"))
            {
                SetAccessRights(path + "\\Setting.dll");
            }

            if (System.IO.Directory.Exists("C:\\SuhradamSoft\\BillingSystemCafe") == false)
            {
                System.IO.Directory.CreateDirectory("C:\\SuhradamSoft\\BillingSystemCafe");
            }

            SetFolderPermission("C:\\SuhradamSoft\\BillingSystemCafe");

            path = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\Details.txt";
            string text = File.ReadAllText(path);
            string[]  Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();
            labelCompany.Text = companyName;
            lblCompanyAddress.Text = companyAddress1 + companyAddress2;
            lblCompanyPhone.Text = "PH : " + companyPhone;
            this.Text = companyName + " Billing System";
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

        private void SetAccessRights(string file)
        {
            FileSecurity fileSecurity = File.GetAccessControl(file);
            AuthorizationRuleCollection rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));

            foreach (FileSystemAccessRule rule in rules)
            {
                string name = rule.IdentityReference.Value;

                if (rule.FileSystemRights != FileSystemRights.FullControl)
                {
                    FileSecurity newFileSecurity = File.GetAccessControl(file);
                    FileSystemAccessRule newRule = new FileSystemAccessRule(name, FileSystemRights.FullControl, AccessControlType.Allow);
                    newFileSecurity.AddAccessRule(newRule);
                    File.SetAccessControl(file, newFileSecurity);
                }
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
            if (!Application.OpenForms.OfType<frm_Tax_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_Tax_master formTax = new frm_Tax_master();
                formTax.MdiParent = this;
                formTax.Show();
            }
        }
    }
}
