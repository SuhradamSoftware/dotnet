using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Properties;
using System.IO;

namespace BillingSystem
{
    public partial class frmSetting : Form
    {
        DataTable dt = new DataTable();
        public frmSetting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// For Edit record.
        /// </summary>
        void FillData()
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_invoice.Text.Trim()))
            {
                ep1.Clear();
                ep1.SetError(txt_invoice, "Please Enter Serial No.");
                txt_invoice.Focus();
                return;
            }

            if (txt_desc.Text != "")
            {
                File.AppendAllText((Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\Description.txt", "," + txt_desc.Text.ToString());
            }
            Settings.Default.InvoiceNumber = Convert.ToInt64(txt_invoice.Text.Trim());
            Settings.Default.Save();

            MessageBox.Show("Setting Save Successfully");
            this.Close();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            txt_invoice.Text = Settings.Default.InvoiceNumber.ToString();
        }

        private void frmSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                    this.Close();
            }
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
