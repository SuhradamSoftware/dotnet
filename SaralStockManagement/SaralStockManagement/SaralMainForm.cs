using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaralStockManagement
{
    public partial class SaralMainForm : Form
    {
        public SaralMainForm()
        {
            InitializeComponent();
        }

        private void SaralMainForm_Load(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            DataAccess.gbl_height = Screen.PrimaryScreen.WorkingArea.Height;
            DataAccess.gbl_width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = DataAccess.gbl_height;
            this.Width = DataAccess.gbl_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            DataAccess.tlp_main_x = button1.Location.X;
            DataAccess.tlp_main_y = button1.Location.Y;

            int main_height = tlp_header.Height + 16;
            int main_width = Screen.PrimaryScreen.WorkingArea.Width;
            tlp_header.Width = Screen.PrimaryScreen.WorkingArea.Width;
            tlp_footer.Width = Screen.PrimaryScreen.WorkingArea.Width;


            DataAccess.gbl_client_height = DataAccess.gbl_height - main_height;
          
          
        }

        private void menu_purchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmSaralPurchase>().Any())
            {
                frmSaralPurchase _frm_Purchase = new frmSaralPurchase();
                // _frm_Employee.MdiParent = this;
              //  _frm_Purchase.MdiParent = this;
                _frm_Purchase.Show();
            }
        }

        private void lbl_invoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmSaralBill>().Any())
            {
                frmSaralBill _frm_SaralBill = new frmSaralBill();
                // _frm_Employee.MdiParent = this;
                //  _frm_Purchase.MdiParent = this;
                _frm_SaralBill.Show();
            }
        }

        private void mnu_product_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmSaralProduct>().Any())
            {
                frmSaralProduct _frm_SaralProduct = new frmSaralProduct();
                // _frm_Employee.MdiParent = this;
                //  _frm_Purchase.MdiParent = this;
                _frm_SaralProduct.Show();
            }
        }

        private void lbl_report_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<frmSaralReport>().Any())
            {
                frmSaralReport _frm_SaralReport = new frmSaralReport();
                // _frm_Employee.MdiParent = this;
                //  _frm_Purchase.MdiParent = this;
                _frm_SaralReport.Show();
            }
        }

   
    }
}
