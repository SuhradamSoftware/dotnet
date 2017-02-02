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
            frmMain mf = this.ParentForm as frmMain;
            mf.tlp_mdi.Visible = false;

            string invoicenumber = "";

            lbl_date.Text = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();

            dt_grid.Columns.Add("RowNumber", typeof(int));
            dt_grid.Columns.Add("fld_product_id", typeof(string));
            dt_grid.Columns.Add("fld_product_name", typeof(string));
            dt_grid.Columns.Add("fld_amount", typeof(decimal));
            dt_grid.Columns.Add("fld_discount", typeof(decimal));
            dt_grid.Columns.Add("fld_total_amount", typeof(decimal));

            this.Height = DataAccess.gbl_client_height;
            this.Width = DataAccess.gbl_client_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            DataTable _dtChallanNumber = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'InvoiceNumber')");
            invoicenumber = _dtChallanNumber.Rows[0]["fld_value"].ToString();
            intinvoicenumber = Convert.ToInt64(invoicenumber.ToString().Trim()) + 1;
            

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
            string[] Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();

            txt_invoice_no.Text = Descs[5].ToString() + intinvoicenumber.ToString().PadLeft(5, '0').ToString();
            FillDropdown();
            ResetData();
            cmbCustomer.Focus();
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
            string query_1 = "select fld_customer_id, fld_customer_name from tbl_customer order by fld_customer_name asc";
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(query_1);

            DataRow dr_1;
            dr_1 = customerData.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Customer" };
            customerData.Rows.InsertAt(dr_1, 0);

            cmbCustomer.AutoCompleteCustomSource = MyCollection;
            cmbCustomer.ValueMember = "fld_customer_id";
            cmbCustomer.DisplayMember = "fld_customer_name";
            cmbCustomer.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                MyCollection.Add(row["fld_customer_name"].ToString());
            }
        }

        public void ResetData()
        {
            AutoCompleteStringCollection product_Collection = new AutoCompleteStringCollection();
            string product_query = "select fld_product_id, fld_product_name from tbl_product order by fld_product_name asc";
            DataTable product_Data = new DataTable();
            product_Data = _datalayer.bindDataTable(product_query);

            DataRow p_dr;
            p_dr = product_Data.NewRow();
            p_dr.ItemArray = new object[] { 0, "Select Product" };
            product_Data.Rows.InsertAt(p_dr, 0);

            cmb_product.AutoCompleteCustomSource = product_Collection;
            cmb_product.ValueMember = "fld_product_id";
            cmb_product.DisplayMember = "fld_product_name";
            cmb_product.DataSource = product_Data;

            foreach (DataRow row in product_Data.Rows) // Loop over the rows.
            {
                product_Collection.Add(row["fld_product_name"].ToString());
            }

            AutoCompleteStringCollection cust_Collection = new AutoCompleteStringCollection();
            string cust_query = "select fld_employee_id, fld_employee_name from tbl_employee order by fld_employee_name asc";
            DataTable employeeData = new DataTable();
            employeeData = _datalayer.bindDataTable(cust_query);

            DataRow dr_1;
            dr_1 = employeeData.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Employee" };
            employeeData.Rows.InsertAt(dr_1, 0);

            cmb_employee.AutoCompleteCustomSource = cust_Collection;
            cmb_employee.ValueMember = "fld_employee_id";
            cmb_employee.DisplayMember = "fld_employee_name";
            cmb_employee.DataSource = employeeData;

            foreach (DataRow row in employeeData.Rows) // Loop over the rows.
            {
                cust_Collection.Add(row["fld_employee_name"].ToString());
            }

            btnSave.Text = "Add";
            txt_amount.Text = "";
            txt_discount.Text = "0";
            ep1.Clear();
            cmb_product.Focus();
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
            else if (e.Control && e.KeyCode == Keys.C)
            {
                cmbCustomer.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                cmbCustomer.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                cmb_product.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                txt_amount.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                txt_discount.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                Add();
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                txt_tax.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                txt_received_amount.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                cmb_employee.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                Print();
            }
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgv_master.Rows[e.RowIndex].Cells["RowNumber"].Value.ToString());
            cmb_product.SelectedValue = dgv_master.Rows[e.RowIndex].Cells["fld_product_id"].Value.ToString();
            txt_amount.Text = dgv_master.Rows[e.RowIndex].Cells["fld_amount"].Value.ToString();
            txt_discount.Text = dgv_master.Rows[e.RowIndex].Cells["fld_discount"].Value.ToString();
            btnSave.Text = "Update";
            btnCancel.Visible = true;
        }

        void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    cmb_product.SelectedValue = dgv_master.CurrentRow.Cells["fld_product_id"].Value.ToString();
                    txt_amount.Text = dgv_master.CurrentRow.Cells["fld_amount"].Value.ToString();
                    txt_discount.Text = dgv_master.CurrentRow.Cells["fld_discount"].Value.ToString();
                    cmb_product.Focus();
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("invoice fill", ex.Message.ToString());
            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["fld_product_id"].Visible = false;
            dgv_master.Columns["fld_product_name"].HeaderText = "Treatment";
            dgv_master.Columns["fld_amount"].HeaderText = "Amount";
            dgv_master.Columns["fld_discount"].HeaderText = "Discount";
            dgv_master.Columns["fld_total_amount"].HeaderText = "Total Amount";

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void Print()
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
            invoiceDataTable.Columns.Add("fld_invoice_no");
            invoiceDataTable.Columns.Add("fld_invoice_date");
            invoiceDataTable.Columns.Add("fld_customer_code");
            invoiceDataTable.Columns.Add("fld_customer_name");
            invoiceDataTable.Columns.Add("fld_customer_add1");
            invoiceDataTable.Columns.Add("fld_customer_city");
            invoiceDataTable.Columns.Add("fld_customer_mobile");
            invoiceDataTable.Columns.Add("fld_gross_total");
            invoiceDataTable.Columns.Add("fld_tax");
            invoiceDataTable.Columns.Add("fld_other_charges");
            invoiceDataTable.Columns.Add("fld_grand_total");
            invoiceDataTable.Columns.Add("fld_amount_word");

            invoiceDataTable.Columns.Add("fld_product_name");
            invoiceDataTable.Columns.Add("fld_amount");
            invoiceDataTable.Columns.Add("fld_discount");
            invoiceDataTable.Columns.Add("fld_sub_total");

            invoiceDataTable.Columns.Add("MasterCompanyName");
            invoiceDataTable.Columns.Add("MasterCompanyAddress1");
            invoiceDataTable.Columns.Add("MasterCompanyAddress2");
            invoiceDataTable.Columns.Add("MasterCompanyPhone");
            invoiceDataTable.Columns.Add("MasterCompanyEmail");

            DataRow ivoiceDataRow = null;

            string tax = string.Empty;
            if (string.IsNullOrEmpty(txt_tax.Text))
                tax = "";
            else
            {
                if (Convert.ToDecimal(txt_tax.Text.ToString()) > 0)
                    tax = "Tax " + txt_tax.Text.ToString() + "% : " + lbl_total_tax.Text.ToString();
            }

            string final_message = string.Empty;
            string query = "insert into tbl_invoice (fld_invoice_no, fld_customer_id, fld_invoice_date, fld_invoice_amount, fld_tax) values ('" + txt_invoice_no.Text.ToString() + "', " + cmbCustomer.SelectedValue.ToString() + ", '" + _datalayer.DateFormat(lbl_date.Text.Trim()) + "', " + double.Parse(txt_total.Text.ToString()) + ", " + double.Parse(txt_tax.Text.ToString()) + ")";
            string message = _datalayer.OprationWithScope(query);
            if (message != "Error")
            {
                foreach (DataGridViewRow dr in dgv_master.Rows)
                {
                    ivoiceDataRow = invoiceDataTable.NewRow();
                    ivoiceDataRow["fld_invoice_no"] = txt_invoice_no.Text.Trim();
                    ivoiceDataRow["fld_invoice_date"] = lbl_date.Text.Trim();
                    ivoiceDataRow["fld_customer_name"] = cmbCustomer.Text;
                    ivoiceDataRow["fld_customer_add1"] = lbl_address.Text;
                    ivoiceDataRow["fld_customer_mobile"] = lbl_phone_no.Text.Trim();
                    ivoiceDataRow["fld_gross_total"] = string.Format("{0:#,##0.00}", double.Parse(txt_total.Text));
                    ivoiceDataRow["fld_tax"] = tax;
                    ivoiceDataRow["fld_grand_total"] = string.Format("{0:#,##0.00}", double.Parse(txt_grand_total.Text));
                    ivoiceDataRow["fld_amount_word"] = lbl_rupeesword.Text;

                    ivoiceDataRow["fld_product_name"] = dr.Cells["fld_product_name"].Value;
                    ivoiceDataRow["fld_amount"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["fld_amount"].Value.ToString()));
                    ivoiceDataRow["fld_discount"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["fld_discount"].Value.ToString()));
                    ivoiceDataRow["fld_sub_total"] = string.Format("{0:#,##0.00}", double.Parse(dr.Cells["fld_total_amount"].Value.ToString()));

                    ivoiceDataRow["MasterCompanyName"] = companyName;
                    ivoiceDataRow["MasterCompanyAddress1"] = companyAddress1;
                    ivoiceDataRow["MasterCompanyAddress2"] = companyAddress2;
                    ivoiceDataRow["MasterCompanyPhone"] = companyPhone;
                    ivoiceDataRow["MasterCompanyEmail"] = companyEmail;
                    invoiceDataTable.Rows.Add(ivoiceDataRow);

                    query = "insert into tbl_invoice_details (fld_invoice_id, fld_product_id, fld_amount, fld_discount, fld_gross_amount) values (" + message + ", '" + dr.Cells["fld_product_id"].Value + "', " + double.Parse(dr.Cells["fld_amount"].Value.ToString()) + ", " + double.Parse(dr.Cells["fld_discount"].Value.ToString()) + ", " + (double.Parse(dr.Cells["fld_amount"].Value.ToString()) - double.Parse(dr.Cells["fld_discount"].Value.ToString())).ToString() + ")";
                    final_message = _datalayer.Opration(query);

                    if (cmb_employee.SelectedValue.ToString() != "0")
                    {
                        string point = string.Empty;
                        string product_query = "select fld_point from tbl_product where fld_product_id = " + dr.Cells["fld_product_id"].Value;
                        DataTable product_Data = new DataTable();
                        product_Data = _datalayer.bindDataTable(product_query);
                        if (product_Data.Rows.Count > 0)
                            point = product_Data.Rows[0]["fld_point"].ToString();

                        query = "insert into tbl_point (fld_employee_id, fld_product_id, fld_product_qty, fld_point) values (" + cmb_employee.SelectedValue.ToString() + ", " + dr.Cells["fld_product_id"].Value + ", 1," + point + ")";
                        final_message = _datalayer.Opration(query);
                    }
                }
            }

            if (final_message == "Success")
            {
                string query_challan = "update tbl_default set fld_value = '" + intinvoicenumber.ToString() + "' where (fld_default_name = 'InvoiceNumber')";
                _datalayer.Opration(query_challan);

                invoiceDataSet.Tables.Add(invoiceDataTable);
                frmMain mf = this.ParentForm as frmMain;
                mf.BindGrid();
                mf.tlp_mdi.Visible = true;
                this.Close();
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
                Add();
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("invoice save", ex.Message.ToString());
            }
        }

        public void Add()
        {
            if (cmb_product.SelectedValue.ToString() == "0")
            {
                ep1.Clear();
                ep1.SetError(cmb_product, "Please enter product name.");
                cmb_product.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
            {
                ep1.Clear();
                ep1.SetError(txt_amount, "Please Enter Amount.");
                txt_amount.Focus();
                return;
            }

            decimal amount = 0;
            decimal discount = 0;

            amount = Convert.ToDecimal(txt_amount.Text.Trim().ToString());
            discount = Convert.ToDecimal(txt_discount.Text.Trim().ToString() == "" ? "0" : txt_discount.Text.Trim().ToString());

            txt_amount.Text = string.Format("{0:#,##0.00}", amount);
            txt_discount.Text = string.Format("{0:#,##0.00}", discount);

            decimal total_amount = Math.Round(amount - discount, 2);

            bool ifExist = false;
            if (btnSave.Text.ToString().Contains("Add"))
            {
                DataTable dt_demand = (DataTable)dgv_master.DataSource;
                if (dt_demand != null)
                {
                    foreach (DataRow dr in dt_demand.Rows)
                    {
                        if (dr["fld_product_id"].ToString() == cmb_product.SelectedValue.ToString())
                        {
                            ifExist = true;
                        }
                    }
                }
                if (!ifExist)
                {
                    dt_grid.Rows.Add(dt_grid.Rows.Count + 1, cmb_product.SelectedValue.ToString(), cmb_product.Text.ToString(), Convert.ToDecimal(string.Format("{0:#,##0.00}", amount)), Convert.ToDecimal(string.Format("{0:#,##0.00}", discount)), Convert.ToDecimal(string.Format("{0:#,##0.00}", total_amount)));
                    dgv_master.DataSource = null;
                    dgv_master.DataSource = dt_grid;
                }
                else
                {
                    MessageBox.Show("This item already exists in list. Please select other item");
                    ep1.Clear();
                    cmb_product.Focus();
                }
            }
            else
            {
                for (int i = dt_grid.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dt_grid.Rows[i];
                    if (dr["RowNumber"].ToString() == ID.ToString())
                    {
                        dr.Delete();
                    }
                }
                dt_grid.AcceptChanges();

                dt_grid.Rows.Add(ID, cmb_product.SelectedValue.ToString(), cmb_product.Text.ToString(), Convert.ToDecimal(string.Format("{0:#,##0.00}", amount)), Convert.ToDecimal(string.Format("{0:#,##0.00}", discount)), Convert.ToDecimal(string.Format("{0:#,##0.00}", total_amount)));
                dgv_master.DataSource = null;
                dgv_master.DataSource = dt_grid;
            }

            ep1.Clear();
            Calculation();
            ResetData();
            btnCancel.Visible = false;
            CalculationPaymentAmount();
            cmb_product.Focus();
        }

        public void Calculation()
        {
            decimal subTotal = 0;
            for (int i = 0; i < dgv_master.Rows.Count; ++i)
            {
                subTotal += Convert.ToDecimal(dgv_master.Rows[i].Cells[5].Value);
            }
            txt_total.Text = string.Format("{0:#,##0.00}", subTotal);
            CalculationPaymentAmount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID != 0)
                {
                    DataRow[] drr = dt_grid.Select("RowNumber=' " + ID + " ' ");
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
                string query = "SELECT um.fld_customer_id, um.fld_customer_name, um.fld_address, um.fld_phone_number FROM tbl_customer AS um where um.fld_customer_id = " + cmbCustomer.SelectedValue.ToString();
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    lbl_address.Text = customerData.Rows[0]["fld_address"].ToString();
                    lbl_phone_no.Text = customerData.Rows[0]["fld_phone_number"].ToString();

                    lbl_h_address.Visible = lbl_h_phone.Visible = lbl_address.Visible = lbl_phone_no.Visible = true;
                }
                else
                {
                    lbl_h_address.Visible = lbl_h_phone.Visible = lbl_address.Visible = lbl_phone_no.Visible = true;
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
            if (MessageBox.Show("Are you sure to close ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain mf = this.ParentForm as frmMain;
                mf.BindGrid();
                mf.tlp_mdi.Visible = true;
                this.Close();
            }
        }

        private void txt_pay_amount_TextChanged(object sender, EventArgs e)
        {
            CalculationPaymentAmount();
        }

        public void CalculationPaymentAmount()
        {
            decimal total_amount = 0, tax = 0, total_tax = 0, grand_total = 0;
            if (txt_total.Text.ToString() == "")
                total_amount = 0;
            else
                total_amount = Convert.ToDecimal(txt_total.Text.ToString());

            if (txt_tax.Text.ToString() == "")
                tax = 0;
            else
                tax = Convert.ToDecimal(txt_tax.Text.ToString());

            total_tax = (total_amount * tax) / 100;
            lbl_total_tax.Text = total_tax.ToString();
            grand_total = total_amount + total_tax;
            txt_grand_total.Text = grand_total.ToString();
            string[] total = grand_total.ToString().Split('.');
            lbl_rupeesword.Text = DataAccess.NumbersToWords(Convert.ToInt32(total[0]));
            CalculationRefundAmount();
        }

        public void CalculationRefundAmount()
        {
            decimal grand_total = 0, received_amount = 0, refund_amount = 0;

            if (txt_grand_total.Text.ToString() == "")
                grand_total = 0;
            else
                grand_total = Convert.ToDecimal(txt_grand_total.Text.ToString());

            if (txt_received_amount.Text.ToString() == "")
                received_amount = 0;
            else
                received_amount = Convert.ToDecimal(txt_received_amount.Text.ToString());

            refund_amount = received_amount - grand_total;
            txt_refund_amount.Text = refund_amount.ToString();
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

        private void txt_received_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_received_amount_TextChanged(object sender, EventArgs e)
        {
            CalculationRefundAmount();
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_received_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_treatment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_tax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
