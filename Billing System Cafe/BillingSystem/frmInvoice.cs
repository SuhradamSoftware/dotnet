using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingSystem.Properties;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace BillingSystem
{
    public partial class frmInvoice : Form
    {
        DataTable dt = new DataTable();
        int ID = 0;
        Int64 intinvoicenumber = 1;
        string companyName = "";
        string companyAddress1 = "";
        string companyAddress2 = "";
        string companyPhone = "";
        string companyEmail = "";
        DataLayer _datalayer = new DataLayer();

        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            string invoicenumber = "";
            
            lbl_date.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            dt.Columns.Add("RowNumber", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Quantity", typeof(decimal));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("LineAmount", typeof(decimal));

            this.Height = DataAccess.gbl_client_height;
            this.Width = DataAccess.gbl_client_width;

            //tlp_main.Height = DataAccess.gbl_client_height;
            //tlp_main.Width = DataAccess.gbl_client_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            if (System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\InvoiceNumber.txt"))
            {
                invoicenumber = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "InvoiceNumber.txt");
            }
            if (invoicenumber == "")
            {
                invoicenumber = "1";
            }
            intinvoicenumber = Convert.ToInt64(invoicenumber.ToString().Trim()) + 1;
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            string query_1 = "select ProductId, ProductName from Product where IsDeleted = 0 order by ProductName asc";
            DataTable ProductIdData = new DataTable();
            ProductIdData = _datalayer.bindDataTable(query_1);

            foreach (DataRow row in ProductIdData.Rows) // Loop over the rows.
            {
                MyCollection.Add(row["ProductName"].ToString());
            }
 
            DataRow dr_1;
            dr_1 = ProductIdData.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Description" };
            ProductIdData.Rows.InsertAt(dr_1, 0);

            cmb_description.AutoCompleteCustomSource = MyCollection;
            cmb_description.ValueMember = "ProductId";
            cmb_description.DisplayMember = "ProductName";
            cmb_description.DataSource = ProductIdData;

            string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)).ToString() + @"\Details.txt";
            string text = File.ReadAllText(path);
            string[] Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();

            txt_invoice_no.Text = Descs[5].ToString() + intinvoicenumber.ToString().PadLeft(5, '0').ToString();
            FillDropdown();
        }

        private void txt_mobile_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void FillDropdown()
        {
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            string query_1 = "select CustomerId, CustomerName from Customer where IsDeleted = 0 order by CustomerName asc";
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(query_1);

            DataRow dr_1;
            dr_1 = customerData.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Customer" };
            customerData.Rows.InsertAt(dr_1, 0);

            cmbCustomer.AutoCompleteCustomSource = MyCollection;
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                MyCollection.Add(row["CustomerName"].ToString());
            }
        }
        public void ResetData()
        {
            cmb_description.SelectedIndex = -1;
            txt_amount.Text = "0.00";
            txt_UnitPrice.Text = "";
            txt_Quntity.Text = "";
            ep1.Clear();
            cmb_description.Focus();
        }

        private void frmInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dg_invoice.SelectedRows.Count > 0)
                    ResetData();
                else
                    this.Close();
            }

            if (e.KeyCode == Keys.Enter)
                if (dg_invoice.SelectedRows.Count > 0)
                    dg_invoice_CellDoubleClick(dg_invoice, new DataGridViewCellEventArgs(0, dg_invoice.CurrentRow.Index));
        }

        private void dg_invoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dg_invoice.Rows[e.RowIndex].Cells["RowNumber"].Value.ToString());
            cmb_description.Text = dg_invoice.Rows[e.RowIndex].Cells["description"].Value.ToString();
            txt_Quntity.Text = dg_invoice.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_UnitPrice.Text = dg_invoice.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            txt_amount.Text = dg_invoice.Rows[e.RowIndex].Cells["LineAmount"].Value.ToString();
            btnDelete.Visible = true;
            btnCancel.Visible = true;
            btnSave.Visible = false;
        }

        void FillData()
        {
            try
            {
                if (dg_invoice.SelectedRows.Count > 0)
                {
                    cmb_description.Text = dg_invoice.CurrentRow.Cells["description"].Value.ToString();
                    txt_amount.Text = dg_invoice.CurrentRow.Cells["amount"].Value.ToString();

                  

                    cmb_description.Focus();
                }
            }
            catch (Exception)
            {
                //errorLog.ErrorLogFile(ex);
            }
        }


        private void dg_invoice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dg_invoice.Columns["description"].Width = 493;
            dg_invoice.Columns["description"].HeaderText = "Item Description";

            dg_invoice.Columns["amount"].Width = 140;
            dg_invoice.Columns["amount"].HeaderText = "Amount";

            dg_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCellStyle _cellstyle = new DataGridViewCellStyle();
            _cellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_invoice.ColumnHeadersDefaultCellStyle = _cellstyle;

            dg_invoice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dg_invoice.EnableHeadersVisualStyles = false;


            dg_invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dg_invoice.ColumnHeadersHeight = 30;

            dg_invoice.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            dg_invoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dg_invoice.ClearSelection();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_invoice.SelectedRows)
            {
                dg_invoice.Rows.RemoveAt(item.Index);
            }
        }

        private void cmb_description_KeyDown(object sender, KeyEventArgs e)
        {
            cmb_description.DroppedDown = false;
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCustomer.Text))
            {
                ep1.Clear();
                ep1.SetError(cmbCustomer, "Please Enter Customer Name.");
                cmbCustomer.Focus();
                return;
            }

            if (dg_invoice.Rows.Count <= 0)
            {
                ep1.Clear();
                ep1.SetError(cmbCustomer, "Please Enter atleast one line item.");
                cmbCustomer.Focus();
                return;
            }

            DataSet invoiceDataSet = new DataSet();
            DataTable invoiceDataTable = new DataTable();
            invoiceDataTable.Columns.Add("CustomerName");
            invoiceDataTable.Columns.Add("Date");
            invoiceDataTable.Columns.Add("InvoiceNumber");
            invoiceDataTable.Columns.Add("Description");
            invoiceDataTable.Columns.Add("LineAmount");
            invoiceDataTable.Columns.Add("Quantity");
            invoiceDataTable.Columns.Add("UnitPrice");
            invoiceDataTable.Columns.Add("DepartmentName");
            invoiceDataTable.Columns.Add("CustomerAddress1");
            invoiceDataTable.Columns.Add("CustomerCity");
            invoiceDataTable.Columns.Add("CustomerCode");
            invoiceDataTable.Columns.Add("Document");
            invoiceDataTable.Columns.Add("CustomerPhone");
            invoiceDataTable.Columns.Add("TotalAmount");
            invoiceDataTable.Columns.Add("AmountinWord");
            invoiceDataTable.Columns.Add("MasterCompanyName");
            invoiceDataTable.Columns.Add("MasterCompanyAddress1");
            invoiceDataTable.Columns.Add("MasterCompanyAddress2");
            invoiceDataTable.Columns.Add("MasterCompanyPhone");
            invoiceDataTable.Columns.Add("MasterCompanyEmail");

            DataRow ivoiceDataRow = null;
            foreach (DataGridViewRow dr in dg_invoice.Rows)
            {
                ivoiceDataRow = invoiceDataTable.NewRow();
                ivoiceDataRow["Date"] = lbl_date.Text.Trim();
                ivoiceDataRow["InvoiceNumber"] = txt_invoice_no.Text.Trim();
                ivoiceDataRow["CustomerName"] = cmbCustomer.Text;
                ivoiceDataRow["CustomerAddress1"] = txt_CustomerAddress.Text.Trim();
                ivoiceDataRow["CustomerCity"] = txt_Cust_City.Text.Trim();
                ivoiceDataRow["CustomerCode"] = label_CodeType.Text.Trim();
                ivoiceDataRow["Document"] = label_DocumentType.Text.Trim();
                ivoiceDataRow["CustomerPhone"] = txt_Cust_Phone.Text.Trim();
                ivoiceDataRow["TotalAmount"] = string.Format("{0:#,##0.00}", double.Parse(txt_SubTotal.Text));
               
                ivoiceDataRow["Description"] = dr.Cells["description"].Value;
                ivoiceDataRow["LineAmount"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["LineAmount"].Value.ToString()));
                ivoiceDataRow["Quantity"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["Quantity"].Value.ToString()));
                ivoiceDataRow["UnitPrice"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["UnitPrice"].Value.ToString()));
                ivoiceDataRow["MasterCompanyName"] = companyName;
                ivoiceDataRow["MasterCompanyAddress1"] = companyAddress1;
                ivoiceDataRow["MasterCompanyAddress2"] = companyAddress2;
                ivoiceDataRow["MasterCompanyPhone"] = companyPhone;
                ivoiceDataRow["MasterCompanyEmail"] = companyEmail;
                invoiceDataTable.Rows.Add(ivoiceDataRow);
            }

            if (System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\InvoiceNumber.txt"))
            {
                System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "InvoiceNumber.txt", intinvoicenumber.ToString());
            }

            invoiceDataSet.Tables.Add(invoiceDataTable);
            CloseOpenForm.HideAllForms();
            frmView _frmfrmView = new frmView(invoiceDataSet);
            _frmfrmView.Show();
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateLineAmount()
        {
            decimal quantity = 0;
            decimal unitPrice = 0;

            decimal.TryParse(txt_Quntity.Text.ToString(), out quantity);
            decimal.TryParse(txt_UnitPrice.Text.ToString(), out unitPrice);

            if (string.IsNullOrEmpty(txt_Quntity.Text.Trim()))
            {
                txt_Quntity.Text = "0.00";
            }
            if (string.IsNullOrEmpty(txt_UnitPrice.Text.Trim()))
            {
                txt_UnitPrice.Text = "0.00";
            }

            //txt_UnitPrice.Text = string.Format("{0:#,##0.00}", unitPrice);
            //txt_Quntity.Text = string.Format("{0:#,##0.00}", quantity);

            decimal amount = Math.Round(quantity * unitPrice, 2);
            txt_amount.Text = string.Format("{0:#,##0.00}", amount);
        }

        private void txt_Quntity_TextChanged(object sender, EventArgs e)
        {
            CalculateLineAmount();
        }
      
        private void txt_Quntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateLineAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_description.Text.Trim()))
                {
                    ep1.Clear();
                    ep1.SetError(cmb_description, "Please Enter Description.");
                    cmb_description.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                {
                    ep1.Clear();
                    ep1.SetError(txt_amount, "Please Enter Amount.");
                    txt_amount.Focus();
                    return;
                }

                dt.Rows.Add(dt.Rows.Count + 1, cmb_description.Text, Convert.ToDecimal(txt_Quntity.Text), Convert.ToDecimal(txt_UnitPrice.Text), Convert.ToDecimal(txt_amount.Text));
                dg_invoice.DataSource = null;
               
                dg_invoice.DataSource = dt;

                foreach (DataGridViewColumn c in dg_invoice.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
                }

                dg_invoice.Columns[0].Width = 5;
                dg_invoice.Columns[1].Width = 500;
                dg_invoice.Columns[2].Width = 150;
                dg_invoice.Columns[3].Width = 200;
                dg_invoice.Columns[4].Width = 100;
                dg_invoice.Columns[0].Visible = false;

                ep1.Clear();
                Calculation();
                ResetData();
                btnDelete.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception)
            {
                //errorLog.ErrorLogFile(ex);
            }
        }

        public void Calculation()
        {
            decimal subTotal = 0;
            for (int i = 0; i < dg_invoice.Rows.Count; ++i)
            {
                subTotal += Convert.ToDecimal(dg_invoice.Rows[i].Cells[4].Value);
            }
            txt_SubTotal.Text = string.Format("{0:#,##0.00}", subTotal);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID != 0)
                {
                    DataRow[] drr = dt.Select("RowNumber=' " + ID + " ' ");
                    for (int i = 0; i < drr.Length; i++)
                        dt.Rows.Remove(drr[i]);
                    dt.AcceptChanges();
                    dg_invoice.DataSource = dt;
 
                    MessageBox.Show("Record Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");  
                }
            }
            ResetData();
            Calculation();
            btnDelete.Visible = false;
            btnCancel.Visible = false;
            btnSave.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetData();
            btnDelete.Visible = false;
            btnCancel.Visible = false;
            btnSave.Visible = true;
        }

        private void cmbCustomer_Keydown(object sender, KeyEventArgs e)
        {
            cmbCustomer.DroppedDown = false;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue.ToString() != "0")
            {
                string query = "SELECT um.CustomerID, um.CustomerName, um.Address, um.City, um.PhoneNumber,DocumentType, PhoneNumber, DocumentPath,CustomerCode,DocumentNumber FROM Customer AS um where um.CustomerID = " + cmbCustomer.SelectedValue.ToString();
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    txt_CustomerAddress.Text = customerData.Rows[0]["Address"].ToString();
                    txt_Cust_City.Text = customerData.Rows[0]["City"].ToString();
                    txt_Cust_Phone.Text = customerData.Rows[0]["PhoneNumber"].ToString();
                    label_CodeType.Text = customerData.Rows[0]["CustomerCode"].ToString();
                    label_DocumentType.Text = customerData.Rows[0]["DocumentType"].ToString() + "  " + customerData.Rows[0]["DocumentNumber"].ToString();
                    pictureBox1.ImageLocation = "C:\\SuhradamSoft\\BillingSystemCafe\\" + customerData.Rows[0]["DocumentPath"].ToString();
                }
            }
        }


        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
