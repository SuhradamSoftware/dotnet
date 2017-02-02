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
    public partial class frmGBSInvoice : Form
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

        public frmGBSInvoice()
        {
            InitializeComponent();
        }

        private void frmGBSInvoice_Load(object sender, EventArgs e)
        {
            FillDetails();
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

        private void GetBillNumber()
        {
            string invoiceNumber = "";
            string invoicePrefix = "";
            DataSet nameValueData = new DataSet();
            string query = string.Empty;

            query = "SELECT BSNameKey, BSNameValue FROM BSNameValues ";

            nameValueData = _datalayer.bindDataSet(query);

            if (nameValueData.Tables.Count > 0)
            {
                for (int i = 0; i < nameValueData.Tables[0].Rows.Count; i++)
                {
                    if (nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString() == "BillNumber")
                    {
                        invoiceNumber = nameValueData.Tables[0].Rows[i]["BSNameValue"].ToString();
                    }
                    else if (nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString() == "BillPrefix")
                    {
                        invoicePrefix = nameValueData.Tables[0].Rows[i]["BSNameValue"].ToString();
                    }
                }
            }

            intinvoicenumber = Convert.ToInt64(invoiceNumber.ToString().Trim()) + 1;
            txt_invoice_no.Text = invoicePrefix + intinvoicenumber.ToString().PadLeft(5, '0').ToString();
        }

        private void FillCustomer()
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

        private void FillProduct()
        {
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
        }

        private void FillTax()
        {
            string query = "SELECT um.TaxDescription, um.TaxRate FROM Taxes AS um where um.IsDeleted = 0 order by TaxID";
            DataTable taxData = new DataTable();
            taxData = _datalayer.bindDataTable(query);
            int recordCount = 1;
            foreach (DataRow row in taxData.Rows) // Loop over the rows.
            {
                if (recordCount == 1)
                {
                    txt_Tax1.Text = string.Format("{0:#,##0.00}", row["TaxRate"].ToString());
                    label_Tax1.Text = row["TaxDescription"].ToString();
                }
                else if (recordCount == 2)
                {
                    txt_Tax2.Text = string.Format("{0:#,##0.00}", row["TaxRate"].ToString());
                    label_Tax2.Text = row["TaxDescription"].ToString();
                }
                else if (recordCount == 3)
                {
                    txt_Tax3.Text = string.Format("{0:#,##0.00}", row["TaxRate"].ToString());
                    label_Tax3.Text = row["TaxDescription"].ToString();
                }
                else
                {
                    break;
                }
                recordCount++;
            }
        }

        private void FillDetails()
        {
            lbl_date.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            dt.Columns.Add("RowNumber", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Quantity", typeof(decimal));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("LineAmount", typeof(decimal));

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
            string[] Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();

            FillCustomer();
            FillProduct();
            FillTax();
            GetBillNumber();
           
        }

        public void ResetData()
        {
            cmb_description.SelectedIndex = 0;
            txt_amount.Text = "0.00";
            txt_UnitPrice.Text = "";
            txt_Quntity.Text = "";
            ep1.Clear();
            cmb_description.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
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

        private void txt_Summary_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txt_Line_TextChanged(object sender, EventArgs e)
        {
            CalculateLineAmount();
        }

        private void cmb_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Quntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_UnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Cust_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

         private void txt_Cust_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
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

            decimal amount = Math.Round(quantity * unitPrice, 2);
            txt_amount.Text = string.Format("{0:#,##0.00}", amount);
        }

        private void Calculation()
        {
            decimal subTotal = 0;
            decimal tax1 = 0;
            decimal tax2 = 0;
            decimal tax3 = 0;
            decimal total_tax1 = 0;
            decimal total_tax2 = 0;
            decimal total_tax3 = 0;
            decimal otherCharges = 0;
            decimal discount = 0;
            decimal totalTax = 0;
            decimal totalAmount = 0;
            
            for (int i = 0; i < dg_invoice.Rows.Count; ++i)
                subTotal += Convert.ToDecimal(dg_invoice.Rows[i].Cells[4].Value);

            if (string.IsNullOrEmpty(txt_Tax1.Text.Trim()))
                tax1 = 0;
            else
                decimal.TryParse(txt_Tax1.Text.ToString(), out tax1);

            if (string.IsNullOrEmpty(txt_Tax2.Text.Trim()))
                tax2 = 0;
            else
                decimal.TryParse(txt_Tax2.Text.ToString(), out tax2);

            if (string.IsNullOrEmpty(txt_Tax3.Text.Trim()))
                tax3 = 0;
            else
                decimal.TryParse(txt_Tax3.Text.ToString(), out tax3);

            if (string.IsNullOrEmpty(txt_Other_Charge.Text.Trim()))
                otherCharges = 0;
            else
                decimal.TryParse(txt_Other_Charge.Text.ToString(), out otherCharges);

            if (string.IsNullOrEmpty(txt_discount.Text.Trim()))
                discount = 0;
            else
                decimal.TryParse(txt_discount.Text.ToString(), out discount);

            if (tax1 > 0)
            {
                total_tax1 = (subTotal * tax1) / 100;
                totalTax = totalTax + total_tax1;
            }

            if (tax2 > 0)
            {
                total_tax2 = (subTotal * tax2) / 100;
                totalTax = totalTax + total_tax2;
            }

            if (tax3 > 0)
            {
                total_tax3 = (subTotal * tax3) / 100;
                totalTax = totalTax + total_tax3;
            }

            txt_SubTotal.Text = string.Format("{0:#,##0.00}", subTotal);
            lbl_t_tax1.Text = string.Format("{0:#,##0.00}", total_tax1);
            lbl_t_tax2.Text = string.Format("{0:#,##0.00}", total_tax2);
            lbl_t_tax3.Text = string.Format("{0:#,##0.00}", total_tax3);
            lbl_total_tax.Text = string.Format("{0:#,##0.00}", totalTax);

            totalAmount = subTotal + otherCharges + totalTax - discount;

            txt_TotalAmount.Text = string.Format("{0:#,##0.00}", totalAmount);
            string[] total = totalAmount.ToString().Split('.');
            lbl_amount_in_word.Text = DataAccess.NumbersToWords(Convert.ToInt32(total[0]));
        }

        private void dg_invoice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dg_invoice.Columns["description"].Width = 493;
            dg_invoice.Columns["description"].HeaderText = "Item Description";

            dg_invoice.Columns["LineAmount"].Width = 140;
            dg_invoice.Columns["LineAmount"].HeaderText = "Amount";

            dg_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCellStyle _cellstyle = new DataGridViewCellStyle();
            _cellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_invoice.ColumnHeadersDefaultCellStyle = _cellstyle;

            dg_invoice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dg_invoice.EnableHeadersVisualStyles = false;


            dg_invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dg_invoice.ColumnHeadersHeight = 30;

            dg_invoice.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dg_invoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dg_invoice.ClearSelection();
        }

        private void cmb_descriptionKeydown(object sender, KeyEventArgs e)
        {
            cmb_description.DroppedDown = false;
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
                string query = "SELECT CustomerID, CustomerName, City, MobileNumber FROM Customer WHERE CustomerID = " + cmbCustomer.SelectedValue.ToString();
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    txt_Cust_City.Text = customerData.Rows[0]["City"].ToString();
                    txt_Cust_Phone.Text = customerData.Rows[0]["MobileNumber"].ToString();
                }

                btn_customeradd.Enabled = false;
            }
            else
                btn_customeradd.Enabled = true;

        }

        private void cmb_description_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_description.SelectedValue.ToString() != "0")
            {
                string query = "SELECT Price FROM Product WHERE ProductID = " + cmb_description.SelectedValue.ToString();
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    txt_UnitPrice.Text = customerData.Rows[0]["Price"].ToString();
                }
            }
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
            btn_save.Visible = false;
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

                    Calculation();
                    MessageBox.Show("Record Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
            ResetData();
            btnDelete.Visible = false;
            btnCancel.Visible = false;
            btn_save.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetData();
            btnDelete.Visible = false;
            btnCancel.Visible = false;
            btn_save.Visible = true;
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

            if (cmbCustomer.SelectedValue.ToString() == "0")
            {
                ep1.Clear();
                ep1.SetError(cmbCustomer, "Please Select Customer Name.");
                cmbCustomer.Focus();
                return;
            }

            if (dg_invoice.Rows.Count <= 0)
            {
                ep1.Clear();
                ep1.SetError(cmb_description, "Please Enter atleast one line item.");
                cmb_description.Focus();
                return;
            }

            Calculation();

            DataSet invoiceDataSet = new DataSet();
            DataTable invoiceDataTable = new DataTable();
            invoiceDataTable.Columns.Add("CustomerName");
            invoiceDataTable.Columns.Add("Date");
            invoiceDataTable.Columns.Add("InvoiceNumber");
            invoiceDataTable.Columns.Add("CompanyName");
            invoiceDataTable.Columns.Add("Description");
            invoiceDataTable.Columns.Add("LineAmount");
            invoiceDataTable.Columns.Add("Quantity");
            invoiceDataTable.Columns.Add("UnitPrice");
            invoiceDataTable.Columns.Add("DepartmentName");
            invoiceDataTable.Columns.Add("CustomerAddress1");
            invoiceDataTable.Columns.Add("DeliveryAddress");
            invoiceDataTable.Columns.Add("CustomerCity");
            invoiceDataTable.Columns.Add("CustomerState");
            invoiceDataTable.Columns.Add("CustomerZip");
            invoiceDataTable.Columns.Add("CustomerPhone");
            invoiceDataTable.Columns.Add("PanNumber");
            invoiceDataTable.Columns.Add("CSTNumber");
            invoiceDataTable.Columns.Add("TinNumber");
            invoiceDataTable.Columns.Add("SubTotal");
            invoiceDataTable.Columns.Add("Tax1");
            invoiceDataTable.Columns.Add("Tax2");
            invoiceDataTable.Columns.Add("Tax3");
            invoiceDataTable.Columns.Add("OtherCharges");
            invoiceDataTable.Columns.Add("TotalTax");
            invoiceDataTable.Columns.Add("Discount");
            invoiceDataTable.Columns.Add("TotalAmount");
            invoiceDataTable.Columns.Add("AmountinWord");
            invoiceDataTable.Columns.Add("MasterCompanyName");
            invoiceDataTable.Columns.Add("MasterCompanyAddress1");
            invoiceDataTable.Columns.Add("MasterCompanyAddress2");
            invoiceDataTable.Columns.Add("MasterCompanyPhone");
            invoiceDataTable.Columns.Add("MasterCompanyEmail");

            string address = string.Empty, pan_no = string.Empty, cst_no = string.Empty, tin_no = string.Empty, delivery_address = string.Empty;
            string query_add = "SELECT Address, PanNumber, CSTNumber, TinNumber FROM Customer WHERE CustomerID = " + cmbCustomer.SelectedValue.ToString();
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(query_add);
            if (customerData.Rows.Count > 0)
            {
                address = customerData.Rows[0]["Address"].ToString();
                pan_no = customerData.Rows[0]["PanNumber"].ToString() == "" ? "" : "Pan No. : " + customerData.Rows[0]["PanNumber"].ToString();
                cst_no = customerData.Rows[0]["CSTNumber"].ToString() == "" ? "" : "CST No. : " + customerData.Rows[0]["CSTNumber"].ToString();
                tin_no = customerData.Rows[0]["TinNumber"].ToString() == "" ? "" : "Tin No. : " + customerData.Rows[0]["TinNumber"].ToString();
            }

            string total_tax1 = string.Empty, total_tax2 = string.Empty, total_tax3 = string.Empty, otherCharges = string.Empty, discount = string.Empty, totalTax = string.Empty;

            if (string.IsNullOrEmpty(txt_Tax1.Text.Trim()))
                total_tax1 = "";
            else
            {
                if (Convert.ToDecimal(txt_Tax1.Text.ToString()) > 0)
                    total_tax1 = label_Tax1.Text + " " + txt_Tax1.Text.Trim() + "%  : " + lbl_t_tax1.Text;
            }

            if (string.IsNullOrEmpty(txt_Tax2.Text.Trim()))
                total_tax2 = "";
            else
            {
                if (Convert.ToDecimal(txt_Tax2.Text.ToString()) > 0)
                    total_tax2 = label_Tax2.Text + " " + txt_Tax2.Text.Trim() + "%  : " + lbl_t_tax2.Text;
            }

            if (string.IsNullOrEmpty(txt_Tax3.Text.Trim()))
                total_tax3 = "";
            else
            {
                if (Convert.ToDecimal(txt_Tax3.Text.ToString()) > 0)
                    total_tax3 = label_Tax3.Text + " " + txt_Tax3.Text.Trim() + "%  : " + lbl_t_tax3.Text;
            }

            if (string.IsNullOrEmpty(txt_Other_Charge.Text.Trim()))
                otherCharges = "";
            else
            {
                if (Convert.ToDecimal(txt_Other_Charge.Text.ToString()) > 0)
                    otherCharges = "Other Charges : " + txt_Other_Charge.Text.Trim();
            }

            if (string.IsNullOrEmpty(txt_discount.Text.Trim()))
                discount = "";
            else
            {
                if (Convert.ToDecimal(txt_discount.Text.ToString()) > 0)
                    discount = "Discount : " + txt_discount.Text.Trim();
            }

            if (string.IsNullOrEmpty(lbl_total_tax.Text.Trim()))
                totalTax = "";
            else
            {
                if (Convert.ToDecimal(lbl_total_tax.Text.ToString()) > 0)
                    totalTax = "Total Tax : " + lbl_total_tax.Text.Trim();
            }

            delivery_address = txt_Delivery.Text.Trim().ToString() == "" ? "" : "Delivery : " + txt_Delivery.Text.Trim().ToString();

            DataRow ivoiceDataRow = null;
            foreach (DataGridViewRow dr in dg_invoice.Rows)
            {
                ivoiceDataRow = invoiceDataTable.NewRow();
                ivoiceDataRow["Date"] = lbl_date.Text.Trim();
                ivoiceDataRow["InvoiceNumber"] = txt_invoice_no.Text.Trim();
                ivoiceDataRow["CustomerName"] = cmbCustomer.Text;
                ivoiceDataRow["CustomerAddress1"] = address;
                ivoiceDataRow["DeliveryAddress"] = delivery_address;
                ivoiceDataRow["CustomerCity"] = txt_Cust_City.Text.Trim();
                ivoiceDataRow["CustomerPhone"] = txt_Cust_Phone.Text.Trim();
                ivoiceDataRow["PanNumber"] = pan_no;
                ivoiceDataRow["CSTNumber"] = cst_no;
                ivoiceDataRow["TinNumber"] = tin_no;
                ivoiceDataRow["SubTotal"] = string.Format("{0:#,##0.00}", double.Parse(txt_SubTotal.Text));
                ivoiceDataRow["Tax1"] = total_tax1;
                ivoiceDataRow["Tax2"] = total_tax2;
                ivoiceDataRow["Tax3"] = total_tax3;
                ivoiceDataRow["OtherCharges"] = otherCharges;
                ivoiceDataRow["TotalTax"] = totalTax;
                ivoiceDataRow["Discount"] = discount;
                ivoiceDataRow["TotalAmount"] = string.Format("{0:#,##0.00}", double.Parse(txt_TotalAmount.Text));
                ivoiceDataRow["AmountinWord"] = lbl_amount_in_word.Text.ToString();

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

            string query = string.Empty;
            query = "UPDATE BSNameValues  SET BSNameValue = '" + intinvoicenumber.ToString() + "' WHERE BSNameKey = 'BillNumber'";
            string message = _datalayer.Opration(query);

            if (message != "Success")
            {
                MessageBox.Show("Sorry!!! there are some issue to upedat invoice number, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            invoiceDataSet.Tables.Add(invoiceDataTable);
            CloseOpenForm.HideAllForms();
            frmView _frmfrmView = new frmView(invoiceDataSet);
            _frmfrmView.Show();
        }

        private void btn_customeradd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(cmbCustomer, "Please enter customer name.");
                cmbCustomer.Focus();
                return;
            }

            if (txt_Cust_City.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_Cust_City, "Please enter city name.");
                txt_Cust_City.Focus();
                return;
            }
            if (txt_Cust_Phone.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_Cust_Phone, "Please enter mobile No.");
                txt_Cust_Phone.Focus();
                return;
            }
            if (txt_Delivery.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_Delivery, "Please enter address.");
                txt_Delivery.Focus();
                return;
            }

            string query = "INSERT INTO Customer (CustomerName, Address, City,  MobileNumber) values ('" + cmbCustomer.Text.Trim() + "','" + txt_Delivery.Text.Trim() + "', '" + txt_Cust_City.Text.ToString() + "','" + txt_Cust_Phone.Text.Trim() + "')";
            string message = _datalayer.Opration(query);
            if (message == "Success")
            {
                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cust_City.Text = txt_Cust_Phone.Text = txt_Delivery.Text = "";
                FillCustomer();
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Tax1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Tax2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Tax3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Other_Charge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Delivery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
