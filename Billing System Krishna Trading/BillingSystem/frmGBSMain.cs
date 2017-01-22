using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BillingSystem
{
    public partial class frmGBSMain : Form
    {
        DataLayer _datalayer = new DataLayer();
        string companyName = "";
        string companyAddress1 = "";
        string companyAddress2 = "";
        string companyPhone = "";
        string companyEmail = "";
        public frmGBSMain()
        {
            InitializeComponent();
        }
      

       
        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxIcon_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void linkProductMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmGBSProduct>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmGBSProduct formGBSProduct = new frmGBSProduct();
                formGBSProduct.MdiParent = this;
                formGBSProduct.Show();
            }
        }

        private void linkBillMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmGBSInvoice>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmGBSInvoice formGBSInvoice = new frmGBSInvoice();
                formGBSInvoice.MdiParent = this;
                formGBSInvoice.Show();
            }
        }

        private void linkCustomerMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmGBSCustomer>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmGBSCustomer formGBSCustomer = new frmGBSCustomer();
                formGBSCustomer.MdiParent = this;
                formGBSCustomer.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmGBSSetting>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmGBSSetting formGBSSetting = new frmGBSSetting();
                formGBSSetting.MdiParent = this;
                formGBSSetting.Show();
            }
        }

        private void frmGBSMain_Load(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            DataAccess.gbl_height = Screen.PrimaryScreen.WorkingArea.Height;
            DataAccess.gbl_width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = DataAccess.gbl_height;
            this.Width = DataAccess.gbl_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            int main_height = menutitlepanel.Height + 16;
            int main_width = Screen.PrimaryScreen.WorkingArea.Width;

            DataAccess.gbl_client_height = DataAccess.gbl_height - main_height;
            DataAccess.gbl_client_width = DataAccess.gbl_width - 6;

            string path = System.AppDomain.CurrentDomain.BaseDirectory;

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
            string[] Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();
            labelCompany.Text = companyName;
            this.Text = companyName + " Billing System";
            menutitlepanel.Width = Screen.PrimaryScreen.WorkingArea.Width - 502;
            tlp_footer.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }

     
    }
}
