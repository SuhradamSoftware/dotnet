using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmSaralPurchase : Form
    {
        DataLayer _datalayer = new DataLayer();
        int comboIndex = 0;
        public frmSaralPurchase()
        {
            InitializeComponent();
        }

        private void frmSaralProduct_Load(object sender, EventArgs e)
        {
            try
            {
                //this.Height = Screen.PrimaryScreen.WorkingArea.Height - 120;
                //this.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
                //this.Location = new Point(DataAccess.tlp_main_x + 10, DataAccess.tlp_main_y + 10);

                //this.Height = DataAccess.gbl_client_height;
                //this.Width = DataAccess.gbl_client_width;

                //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                FillDropdown();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some issue occurs.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillDropdown()
        {
            cmb_Party.Items.Insert(0, " ");
            cmb_Party.SelectedIndex = 0;

            cmb_brand.Items.Insert(0, " ");
            cmb_brand.SelectedIndex = 0;

            cmb_Category.Items.Insert(0, " ");
            cmb_Category.SelectedIndex = 0;

            cmb_ItemNo.Items.Insert(0, " ");
            cmb_ItemNo.SelectedIndex = 0;

            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            string dropdownSQL = "select PartyId, PartyName from Party where IsDeleted = 0 order by PartyName asc";
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            cmb_Party.AutoCompleteCustomSource = myCollection;
            cmb_Party.ValueMember = "PartyId";
            cmb_Party.DisplayMember = "PartyName";
            cmb_Party.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                myCollection.Add(row["PartyName"].ToString());
            }


            AutoCompleteStringCollection brandCollection = new AutoCompleteStringCollection();
            dropdownSQL = "select ProductCompanyId, CompanyName from ProductCompany where IsDeleted = 0 order by CompanyName asc";
            customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            cmb_brand.AutoCompleteCustomSource = brandCollection;
            cmb_brand.ValueMember = "ProductCompanyId";
            cmb_brand.DisplayMember = "CompanyName";
            cmb_brand.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                brandCollection.Add(row["CompanyName"].ToString());
            }


            AutoCompleteStringCollection productCollection = new AutoCompleteStringCollection();
            dropdownSQL = "select ProductId, ProductCode from Product where IsDeleted = 0 order by ProductCode asc";
            customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            cmb_ItemNo.AutoCompleteCustomSource = productCollection;
            cmb_ItemNo.ValueMember = "ProductId";
            cmb_ItemNo.DisplayMember = "ProductCode";
            cmb_ItemNo.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                productCollection.Add(row["ProductCode"].ToString());
            }

            AutoCompleteStringCollection categoryCollection = new AutoCompleteStringCollection();
            dropdownSQL = "select CategoryId, CategoryName from Category where IsDeleted = 0 order by CategoryName asc";
            customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            cmb_Category.AutoCompleteCustomSource = categoryCollection;
            cmb_Category.ValueMember = "CategoryId";
            cmb_Category.DisplayMember = "CategoryName";
            cmb_Category.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                categoryCollection.Add(row["CategoryName"].ToString());
            }

            

            this.cmb_ItemNo.SelectedIndexChanged += new System.EventHandler(cmb_ItemNo_SelectedIndexChanged);
        }

        public void Reset()
        {
            BindGrid();
            txt_product.Text = txt_product.Text = txt_qty.Text = txt_sale_price.Text = txt_PurchasePrice.Text =  "";
            cmb_Party.Text = "";
            cmb_brand.Text = "";
            cmb_Category.Text = "";
            cmb_ItemNo.Text = "";
            cmb_Party.SelectedIndex = 0;
            cmb_brand.SelectedIndex = 0;
            cmb_Category.SelectedIndex = 0;
            cmb_ItemNo.SelectedIndex = 0;
            txt_expiryDate.Refresh();
            txt_expiryDate.Checked = false;
            btn_save.Text = "SAVE";
            btn_delete.Visible = false;
            ep1.Clear();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "Select PC.PurchaseID,PC.PurChaseDate,P.ProductCode,P.ProductName, C.CategoryName,PRC.CompanyName, PC.Quantity ";
            query = query + " From Purchase PC INNER JOIN Product P ON P.ProductID = PC.ProductID";
            query = query + " LEFT JOIN Category C ON C.CategoryID = P.CategoryID";
            query = query + " LEFT JOIN ProductCompany PRC ON PC.ProductCompanyID = PRC.ProductCompanyID";
            _ds = _datalayer.bindDataSet(query);

            if (_ds.Tables.Count > 0)
            {
                dgv_master.DataSource = _ds.Tables[0];
            }

            this.dgv_master.Columns["CategoryName"].ValueType = typeof(String);
            this.dgv_master.Columns["CompanyName"].ValueType = typeof(String);
            this.dgv_master.Columns["PurChaseDate"].ValueType = typeof(DateTime);
        }

        public void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_master.CurrentRow.Cells["ProductID"].Value.ToString();
                    txt_product.Text = dgv_master.CurrentRow.Cells["ProductName"].Value.ToString();
                    txt_Details.Text = dgv_master.CurrentRow.Cells["ProductDescription"].Value.ToString();
                    cmb_brand.SelectedValue = dgv_master.CurrentRow.Cells["ProductCompany"].Value.ToString();
                    txt_sale_price.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());
                    txt_qty.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());
                    cmb_ItemNo.SelectedValue = dgv_master.CurrentRow.Cells["ProductID"].Value.ToString();
                    btn_save.Text = "UPDATE";
                    btn_delete.Visible = true;
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Fill Data", ex.Message.ToString());
            }
        }

        public void DeleteRecord()
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Empty;
                    query = "update Product set IsDeleted = 1, DeletedByID = " + DataAccess.gbl_longUserID + ", DeletedDate = GETDATE() where ProductID = " + lbl_id.Text.Trim();
                    string message = _datalayer.Opration(query);
                    if (message == "Success")
                    {
                        MessageBox.Show("Data Delete Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Fill Data", ex.Message.ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;
            int? categoryID = null;
            int? partyID = null;
            int? productCompanyID = null;
            int productID = 0;
            try
            {

                if (ValidateData() == false)
                {
                    return;
                }

                if (CreateProductCompany(cmb_brand.Text.Trim(), ref productCompanyID) == false)
                {
                    return;
                }

                if (CreateParty(cmb_Party.Text.Trim(), ref partyID) == false)
                {
                    return;
                }

                if (CreateCategory(cmb_Category.Text.Trim(), ref categoryID) == false)
                {
                    return;
                }

                if (CreateUpdateProduct(cmb_ItemNo.Text.Trim(), categoryID, ref productID) == false)
                {
                    return;
                }

                DateTime? expiryDate =null;

                if(txt_expiryDate.Checked)
                {
                    expiryDate = txt_expiryDate.Value;
                }

                if (btn_save.Text == "SAVE")
                {
                    query = "INSERT INTO Purchase (ProductID, PartyID, ProductCompanyID, Quantity,Rate,ExpiryDate,PurchaseDate,PurchaseDetails, CreatedByID) ";
                    query = query + " values (" + productID + "," + partyID + "," + productCompanyID + "," + txt_qty.Text.Trim() + "," + txt_PurchasePrice.Text.Trim() + ",'" + expiryDate + "','" + DateTime.Now + "','" + txt_Details.Text.Trim() + "'," + DataAccess.gbl_longUserID + ")";
                }
                else
                {
                    //   query = "UPDATE Product SET ProductName = '" + txt_name.Text.Trim() + "', ProductDescription = '" + txt_ProductDescription.Text.Trim() + "', ProductCompany = '" + txt_company.Text.Trim() + "', Price = " + txt_price.Text.Trim() + ",UpdatedByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where ProductID = " + lbl_id.Text.Trim();
                }
                 message = _datalayer.Opration(query);

                if (message == "Success")
                {
                    MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to create Purchase record...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        public bool ValidateData()
        {
            bool returnValue = true;

            if (string.IsNullOrEmpty(txt_PurchasePrice.Text.Trim()))
            {
                txt_PurchasePrice.Text = "0.00";
            }

            if (string.IsNullOrEmpty(txt_sale_price.Text.Trim()))
            {
                txt_sale_price.Text = "0.00";
            }

            if (cmb_ItemNo.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(cmb_ItemNo, "Please select Item Code.");
                cmb_ItemNo.Focus();
                MessageBox.Show("Please select Item Code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                returnValue = false;
            }
            else if (txt_product.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_product, "Please enter Item Name.");
                txt_product.Focus();
                MessageBox.Show("Please enter Item Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                returnValue = false;
            }
            else if (cmb_Category.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(cmb_ItemNo, "Please select Category.");
                cmb_Category.Focus();
                MessageBox.Show("Please select Category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                returnValue = false;
            }
            else if (string.IsNullOrEmpty(txt_qty.Text.Trim()))
            {
                txt_qty.Text = "0.00";
                ep1.Clear();
                ep1.SetError(txt_qty, "Please enter Quantity.");
                txt_qty.Focus();
                MessageBox.Show("Please enter Quantity", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                returnValue = false;
            }

            return returnValue;
        }

        public bool CreateProductCompany(string companyName, ref int? productCompanyID)
        {
            bool returnValue = true;
            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;

            if (companyName != "")
            {
                query = "SELECT ProductCompanyID FROM ProductCompany where CompanyName = '" + companyName + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count <= 0)
                {
                    query = "INSERT INTO ProductCompany (CompanyName, CreatedByID) values ('" + companyName + "'," + DataAccess.gbl_longUserID + ")";
                    message = _datalayer.Opration(query);

                    if (message != "Success")
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert Brand record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        returnValue = false;
                    }

                    query = "SELECT ProductCompanyID FROM ProductCompany where CompanyName = '" + companyName + "'";
                    customerData = _datalayer.bindDataSet(query);
                    if (customerData.Tables[0].Rows.Count > 0)
                    {
                        productCompanyID = Convert.ToInt32(customerData.Tables[0].Rows[0]["ProductCompanyID"].ToString());
                    }
                }
                else
                {
                    productCompanyID = Convert.ToInt32(customerData.Tables[0].Rows[0]["ProductCompanyID"].ToString());
                }
            }

            return returnValue;
        }

        public bool CreateParty(string partyName, ref int? partyID)
        {
            bool returnValue = true;
            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;

            if (partyName != "")
            {
                query = "SELECT PartyID FROM Party where PartyName = '" + partyName + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count <= 0)
                {
                    query = "INSERT INTO Party (PartyName, CreatedByID) values ('" + partyName + "'," + DataAccess.gbl_longUserID + ")";
                    message = _datalayer.Opration(query);

                    if (message != "Success")
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert Party record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        returnValue = false;
                    }
                    query = "SELECT PartyID FROM Party where PartyName = '" + partyName + "'";
                    customerData = _datalayer.bindDataSet(query);
                    if (customerData.Tables[0].Rows.Count > 0)
                    {
                        partyID = Convert.ToInt32(customerData.Tables[0].Rows[0]["PartyID"].ToString());
                    }
                }
                else
                {
                    partyID = Convert.ToInt32(customerData.Tables[0].Rows[0]["PartyID"].ToString());
                }
            }

            return returnValue;
        }

        public bool CreateCategory(string categoryName, ref int? categoryID)
        {
            bool returnValue = true;
            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;

            if (categoryName != "")
            {
                query = "SELECT CategoryID FROM Category where CategoryName = '" + categoryName + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count <= 0)
                {
                    query = "INSERT INTO Category (CategoryName, CreatedByID) values ('" + categoryName + "'," + DataAccess.gbl_longUserID + ")";
                    message = _datalayer.Opration(query);

                    if (message != "Success")
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert Category record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        returnValue = false;
                    }

                    query = "SELECT CategoryID FROM Category where CategoryName = '" + categoryName + "'";
                    customerData = _datalayer.bindDataSet(query);
                    if (customerData.Tables[0].Rows.Count > 0)
                    {
                        categoryID = Convert.ToInt32(customerData.Tables[0].Rows[0]["CategoryID"].ToString());
                    }
                }
                else
                {
                    categoryID = Convert.ToInt32(customerData.Tables[0].Rows[0]["CategoryID"].ToString());
                }
            }

            return returnValue;
        }

        public bool CreateUpdateProduct(string productCode, int? categoryID, ref int productID)
        {
            bool returnValue = true;
            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;

            if (productCode != "")
            {
                query = "SELECT ProductID FROM Product where ProductCode = '" + productCode + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count <= 0)
                {
                    query = "INSERT INTO Product (ProductCode,ProductName, CategoryID, Price, CreatedByID) values ('" + productCode + "','" + txt_product.Text.Trim() + "'," + categoryID + "," + txt_PurchasePrice.Text.Trim() + "," + DataAccess.gbl_longUserID + ")";
                    message = _datalayer.Opration(query);

                    if (message != "Success")
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert Product record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        returnValue = false;
                    }

                    query = "SELECT ProductID FROM Product where ProductCode = '" + productCode + "'";
                    customerData = _datalayer.bindDataSet(query);
                    if (customerData.Tables[0].Rows.Count > 0)
                    {
                        productID = Convert.ToInt32(customerData.Tables[0].Rows[0]["ProductID"].ToString());
                    }
                }
                else
                {
                    productID = Convert.ToInt32(customerData.Tables[0].Rows[0]["ProductID"].ToString());

                    query = "UPDATE Product SET ProductCode = '" + productCode + "', ProductName = '" + txt_product.Text.Trim() + "', CategoryID = " + categoryID + ", Price = " + txt_PurchasePrice.Text.Trim() + ",UpdatedByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where ProductID = " + productID;
                    message = _datalayer.Opration(query);
                    if (message != "Success")
                    {
                        MessageBox.Show("Sorry!!! there are some issue to update Product record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        returnValue = false;
                    }
                }
            }

            return returnValue;
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

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cmb_ItemNo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmb_ItemNo.SelectedValue.ToString() != "0")
            {
                string query = "SELECT P.ProductName, C.CategoryID, P.Price, C.CategoryName FROM Product P LEFT JOIN Category C ON P.CategoryID = C.CategoryID WHERE ProductCode = '" + cmb_ItemNo.Text.ToString() + "'";
                DataTable customerData = new DataTable();
                customerData = _datalayer.bindDataTable(query);
                if (customerData.Rows.Count > 0)
                {
                    txt_product.Text = customerData.Rows[0]["ProductName"].ToString();
                    txt_sale_price.Text = string.Format("{0:#,##0.00}", customerData.Rows[0]["Price"].ToString());
                    if (string.IsNullOrEmpty(customerData.Rows[0]["CategoryName"].ToString()) == false)
                    {
                        comboIndex = cmb_Category.FindString(customerData.Rows[0]["CategoryName"].ToString());
                        if (comboIndex > 0)
                        {
                            cmb_Category.SelectedIndex = comboIndex;
                        }
                    }
                }
            }
            else
            {
                txt_product.Text = "";
                txt_sale_price.Text = "0.00";
                cmb_Category.Text = "";

            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["PurchaseID"].Visible = false;
            dgv_master.Columns["PurChaseDate"].HeaderText = "Date";
            dgv_master.Columns["ProductCode"].HeaderText = "Code";
            dgv_master.Columns["ProductName"].HeaderText = "ItemName";
            dgv_master.Columns["CategoryName"].HeaderText = "Category";
            dgv_master.Columns["CompanyName"].HeaderText = "Brand";

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
    }
}
