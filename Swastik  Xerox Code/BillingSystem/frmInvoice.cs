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
        DataTable dt_grid = new DataTable();
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

            lbl_date.Text = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();
            dt_grid.Columns.Add("RowNumber", typeof(int));
            dt_grid.Columns.Add("ID", typeof(int));
            dt_grid.Columns.Add("Description", typeof(string));
            dt_grid.Columns.Add("Quantity", typeof(decimal));
            dt_grid.Columns.Add("UnitPrice", typeof(decimal));
            dt_grid.Columns.Add("LineAmount", typeof(decimal));

            this.Height = DataAccess.gbl_client_height;
            this.Width = DataAccess.gbl_client_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            DataTable _dtChallanNumber = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'InvoiceNumber')");
            invoicenumber = _dtChallanNumber.Rows[0]["fld_value"].ToString();

            intinvoicenumber = Convert.ToInt64(invoicenumber.ToString().Trim()) + 1;
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            string query_1 = "select ProductId, ProductName from Product order by ProductName asc";
            DataTable dt_1 = new DataTable();
            dt_1 = _datalayer.bindDataTable(query_1);

            foreach (DataRow row in dt_1.Rows) // Loop over the rows.
            {
                MyCollection.Add(row["ProductName"].ToString());
            }

            DataRow dr_1;
            dr_1 = dt_1.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Option" };
            dt_1.Rows.InsertAt(dr_1, 0);

            cmb_description.AutoCompleteCustomSource = MyCollection;
            cmb_description.ValueMember = "ProductId";
            cmb_description.DisplayMember = "ProductName";
            cmb_description.DataSource = dt_1;

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
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
            string query_1 = "select CustomerId, CustomerName from Customer order by CustomerName asc";
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
            txt_quantity.Text = txt_unit_price.Text = "";
            ep1.Clear();
            cmb_description.Focus();
        }

        private void frmInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dgv_master.SelectedRows.Count > 0)
                    ResetData();
                else
                    this.Close();
            }
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgv_master.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            cmb_description.Text = dgv_master.Rows[e.RowIndex].Cells["description"].Value.ToString();
            txt_quantity.Text = dgv_master.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_unit_price.Text = dgv_master.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            btnSave.Text = "Update";
            btnCancel.Visible = true;
        }

        void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    ID = Convert.ToInt32(dgv_master.CurrentRow.Cells["ID"].Value.ToString());
                    cmb_description.Text = dgv_master.CurrentRow.Cells["description"].Value.ToString();
                    txt_quantity.Text = dgv_master.CurrentRow.Cells["Quantity"].Value.ToString();
                    txt_unit_price.Text = dgv_master.CurrentRow.Cells["UnitPrice"].Value.ToString();
                    cmb_description.Focus();
                }
            }
            catch (Exception)
            {
                //errorLog.ErrorLogFile(ex);
            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["ID"].Visible = false;
            dgv_master.Columns["RowNumber"].HeaderText = "Sr. No.";
            dgv_master.Columns["description"].HeaderText = "Item Description";
            dgv_master.Columns["Quantity"].HeaderText = "Quantity";
            dgv_master.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgv_master.Columns["LineAmount"].HeaderText = "Amount";

            foreach (DataGridViewRow row in dgv_master.Rows)
            {
                row.Height = 24;
            }

            for (int i = 0; i < dgv_master.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dgv_master.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(247, 251, 252);
                }
            }

            dgv_master.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_master.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            dgv_master.EnableHeadersVisualStyles = false;
            dgv_master.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_master.ColumnHeadersHeight = 34;
            dgv_master.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dgv_master.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_master.SelectedRows)
            {
                dgv_master.Rows.RemoveAt(item.Index);
            }
        }

        private void cmb_description_KeyDown(object sender, KeyEventArgs e)
        {
            cmb_description.DroppedDown = false;
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
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

            if (dgv_master.Rows.Count <= 0)
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
            invoiceDataTable.Columns.Add("CustomerAddress1");
            invoiceDataTable.Columns.Add("CustomerCity");
            invoiceDataTable.Columns.Add("CustomerPhone");
            invoiceDataTable.Columns.Add("TotalAmount");
            invoiceDataTable.Columns.Add("AmountinWord");
            invoiceDataTable.Columns.Add("MasterCompanyName");
            invoiceDataTable.Columns.Add("MasterCompanyAddress1");
            invoiceDataTable.Columns.Add("MasterCompanyAddress2");
            invoiceDataTable.Columns.Add("MasterCompanyPhone");
            invoiceDataTable.Columns.Add("MasterCompanyEmail");

            DataRow ivoiceDataRow = null;

            string final_message = string.Empty;
            string query = "insert into Invoice (InvoiceNo, CustomerID, InvoiceDate, InvoiceAmount) values ('" + txt_invoice_no.Text.ToString() + "', " + cmbCustomer.SelectedValue.ToString() + ", '" + _datalayer.DateFormat(lbl_date.Text.Trim()) + "', " + double.Parse(txt_SubTotal.Text) + ")";
            string message = _datalayer.OprationWithScope(query);
            if (message != "Error")
            {
                foreach (DataGridViewRow dr in dgv_master.Rows)
                {
                    ivoiceDataRow = invoiceDataTable.NewRow();
                    ivoiceDataRow["Date"] = lbl_date.Text.Trim();
                    ivoiceDataRow["InvoiceNumber"] = txt_invoice_no.Text.Trim();
                    ivoiceDataRow["CustomerName"] = cmbCustomer.Text;
                    ivoiceDataRow["CustomerAddress1"] = lbl_address.Text;
                    ivoiceDataRow["CustomerCity"] = lbl_city.Text.Trim();
                    ivoiceDataRow["CustomerPhone"] = lbl_phone_no.Text.Trim();
                    ivoiceDataRow["TotalAmount"] = string.Format("{0:#,##0.00}", double.Parse(txt_SubTotal.Text));
                    ivoiceDataRow["AmountinWord"] = lbl_rupeesword.Text.ToString();

                    ivoiceDataRow["Description"] = dr.Cells["description"].Value;
                    ivoiceDataRow["LineAmount"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["LineAmount"].Value.ToString()));
                    ivoiceDataRow["MasterCompanyName"] = companyName;
                    ivoiceDataRow["MasterCompanyAddress1"] = companyAddress1;
                    ivoiceDataRow["MasterCompanyAddress2"] = companyAddress2;
                    ivoiceDataRow["MasterCompanyPhone"] = companyPhone;
                    ivoiceDataRow["MasterCompanyEmail"] = companyEmail;
                    invoiceDataTable.Rows.Add(ivoiceDataRow);

                    query = "insert into InvoiceDetails (InvoiceId, ProductID, Quantity, Price, Amount) values (" + message + ", " + dr.Cells["ID"].Value + ", " + double.Parse(dr.Cells["Quantity"].Value.ToString()) + ", " + double.Parse(dr.Cells["UnitPrice"].Value.ToString()) + ", " + double.Parse(dr.Cells["LineAmount"].Value.ToString()) + ")";
                    final_message = _datalayer.Opration(query);
                }
                string pay_amount = txt_pay_amount.Text.Trim().ToString() == "" ? "0" : txt_pay_amount.Text.Trim().ToString();
                string debit_amount = txt_debit_amount.Text.Trim().ToString() == "" ? "0" : txt_debit_amount.Text.Trim().ToString();
                query = "insert into Transactions (CustomerID, InvoiceId, CreaditAmount, DebitAmount, TransactionDate) values (" + cmbCustomer.SelectedValue.ToString() + ", " + message + ", " + double.Parse(pay_amount.ToString()) + ", " + double.Parse(debit_amount.ToString()) + ", '" + _datalayer.DateFormat(lbl_date.Text.Trim()) + "')";
                final_message = _datalayer.Opration(query);
            }

            if (final_message == "Success")
            {
                string query_challan = "update [Default] set fld_value = '" + intinvoicenumber.ToString() + "' where (fld_default_name = 'InvoiceNumber')";
                _datalayer.Opration(query_challan);

                invoiceDataSet.Tables.Add(invoiceDataTable);
                CloseOpenForm.HideAllForms();
                frmView _frmfrmView = new frmView(invoiceDataSet);
                _frmfrmView.Show();
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
                {
                    ep1.Clear();
                    ep1.SetError(txt_quantity, "Please Enter Quantity.");
                    txt_quantity.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_unit_price.Text.Trim()))
                {
                    ep1.Clear();
                    ep1.SetError(txt_unit_price, "Please Enter Unit Price.");
                    txt_unit_price.Focus();
                    return;
                }

                decimal quantity = 0;
                decimal unitPrice = 0;

                quantity = Convert.ToDecimal(txt_quantity.Text.Trim().ToString());
                unitPrice = Convert.ToDecimal(txt_unit_price.Text.Trim().ToString());

                txt_quantity.Text = string.Format("{0:#,##0.00}", quantity);
                txt_unit_price.Text = string.Format("{0:#,##0.00}", unitPrice);

                decimal amount = Math.Round(quantity * unitPrice, 2);

                bool ifExist = false;
                if (btnSave.Text.ToString() == "&Add")
                {
                    DataTable dt_demand = (DataTable)dgv_master.DataSource;
                    if (dt_demand != null)
                    {
                        foreach (DataRow dr in dt_demand.Rows)
                        {
                            if (dr["ID"].ToString() == cmb_description.SelectedValue.ToString())
                            {
                                ifExist = true;
                            }
                        }
                    }
                    if (!ifExist)
                    {
                        dt_grid.Rows.Add(dt_grid.Rows.Count + 1, cmb_description.SelectedValue.ToString(), cmb_description.Text, txt_quantity.Text, txt_unit_price.Text, Convert.ToDecimal(string.Format("{0:#,##0.00}", amount)));
                        dgv_master.DataSource = null;

                        dgv_master.DataSource = dt_grid;
                    }
                    else
                    {
                        MessageBox.Show("This item already exists in list. Please select other item");
                        ep1.Clear();
                        cmb_description.Focus();
                    }
                }

                //foreach (DataGridViewColumn c in dgv_master.Columns)
                //{
                //    c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
                //}

                //dgv_master.Columns[0].Width = 5;
                //dgv_master.Columns[1].Width = 500;
                //dgv_master.Columns[2].Width = 150;
                //dgv_master.Columns[3].Width = 150;
                //dgv_master.Columns[4].Width = 150;
                //dgv_master.Columns[0].Visible = false;

                ep1.Clear();
                Calculation();
                ResetData();
                btnCancel.Visible = false;
                CalculationPaymentAmount();
                cmb_description.Focus();
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("btnSave_Click", ex.Message.ToString());
            }
        }

        public void Calculation()
        {
            decimal subTotal = 0;
            for (int i = 0; i < dgv_master.Rows.Count; ++i)
            {
                subTotal += Convert.ToDecimal(dgv_master.Rows[i].Cells[5].Value);
            }
            txt_SubTotal.Text = string.Format("{0:#,##0.00}", subTotal);
            string[] total = subTotal.ToString().Split('.');
            lbl_rupeesword.Text = "Amount in Word : " + DataAccess.NumbersToWords(Convert.ToInt32(total[0]));
            CalculationPaymentAmount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID != 0)
                {
                    DataRow[] drr = dt_grid.Select("ID=' " + ID + " ' ");
                    for (int i = 0; i < drr.Length; i++)
                        dt_grid.Rows.Remove(drr[i]);
                    dt_grid.AcceptChanges();
                    dgv_master.DataSource = dt_grid;

                    MessageBox.Show("Record Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
            ResetData();
            Calculation();
            btnCancel.Visible = false;
            btnSave.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetData();
            btnCancel.Visible = false;
            btnSave.Visible = true;
        }

        private void cmbCustomer_Keydown(object sender, KeyEventArgs e)
        {
            cmbCustomer.DroppedDown = false; 
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue.ToString() != "0")
            {
                string query = "SELECT um.CustomerID, um.CustomerName, um.Address, um.City, um.PhoneNumber FROM Customer AS um where um.CustomerID = " + cmbCustomer.SelectedValue.ToString();
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    lbl_address.Text = customerData.Rows[0]["Address"].ToString();
                    lbl_city.Text = customerData.Rows[0]["City"].ToString();
                    lbl_phone_no.Text = customerData.Rows[0]["PhoneNumber"].ToString();

                    lbl_h_city.Visible = lbl_h_phone.Visible = lbl_city.Visible = lbl_phone_no.Visible = true;
                }
                else
                {
                    lbl_h_city.Visible = lbl_h_phone.Visible = lbl_city.Visible = lbl_phone_no.Visible = true;
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

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pay_amount_TextChanged(object sender, EventArgs e)
        {
            CalculationPaymentAmount();
        }

        public void CalculationPaymentAmount()
        {
            decimal DebitAmount = 0, SubTotal = 0, PayAmount = 0;
            if (txt_SubTotal.Text.ToString() == "")
                SubTotal = 0;
            else
                SubTotal = Convert.ToDecimal(txt_SubTotal.Text.ToString());

            if (txt_pay_amount.Text.ToString() == "")
                PayAmount = 0;
            else
                PayAmount = Convert.ToDecimal(txt_pay_amount.Text.ToString());

            DebitAmount = SubTotal - PayAmount;
            txt_debit_amount.Text = DebitAmount.ToString();
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_unit_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_pay_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_pay_amount_KeyPress(object sender, KeyPressEventArgs e)
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
