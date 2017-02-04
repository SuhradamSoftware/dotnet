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
    public partial class frmGBSProduct : Form
    {
        DataLayer _datalayer = new DataLayer();
        private bool deleteDisable = false;
        public frmGBSProduct()
        {
            InitializeComponent();
        }

        private void frmGBSProduct_Load(object sender, EventArgs e)
        {
            FillDropdown();
            Reset();
        }

        public void Reset()
        {
            BindGrid();

            txt_ProductName.Text = txt_code.Text = txt_price.Text = txt_Description.Text = "";
            cmb_Category.Text = "";
            btn_save.Text = "SAVE";
            deleteDisable = false;
            btn_delete.Visible = false;
            ep1.Clear();
        }

        public void FillDropdown()
        {
            cmb_Category.Items.Insert(0, "Select...");
            cmb_Category.SelectedIndex = 0;

            AutoCompleteStringCollection categoryCollection = new AutoCompleteStringCollection();
            string dropdownSQL = "select CategoryId, CategoryName from Category where IsDeleted = 0 order by CategoryName asc";
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            cmb_Category.AutoCompleteCustomSource = categoryCollection;
            cmb_Category.ValueMember = "CategoryId";
            cmb_Category.DisplayMember = "CategoryName";
            cmb_Category.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                categoryCollection.Add(row["CategoryName"].ToString());
            }

        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.ProductID,ProductCode, um.ProductName, um.ProductDescription,C.CategoryName, um.Price,um.ProductStock FROM Product AS um ";
            query = query + " INNER JOIN Category C ON C.CategoryID = um.CategoryID";
            query = query + " where um.IsDeleted = 0";

            _ds = _datalayer.bindDataSet(query);

            if (_ds.Tables.Count > 0)
            {
                dgv_master.DataSource = _ds.Tables[0];
            }
        }

        public void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_master.CurrentRow.Cells["ProductID"].Value.ToString();
                    txt_code.Text = dgv_master.CurrentRow.Cells["ProductCode"].Value.ToString();
                    txt_ProductName.Text = dgv_master.CurrentRow.Cells["ProductName"].Value.ToString();
                    txt_Description.Text = dgv_master.CurrentRow.Cells["ProductDescription"].Value.ToString();
                    txt_price.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());
                    txt_Stock.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["ProductStock"].Value.ToString());
                    if (string.IsNullOrEmpty(dgv_master.CurrentRow.Cells["CategoryName"].Value.ToString()) == false)
                    {
                        int comboIndex = cmb_Category.FindString(dgv_master.CurrentRow.Cells["CategoryName"].Value.ToString());
                        if (comboIndex > 0)
                        {
                            cmb_Category.SelectedIndex = comboIndex;
                        }
                    }
                    btn_save.Text = "UPDATE";
                    deleteDisable = true;
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
            int categoryID = 0;

            if (txt_code.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_code, "Please enter Item code.");
                txt_code.Focus();
                return;
            }

            if (txt_ProductName.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_ProductName, "Please enter Item Name.");
                txt_ProductName.Focus();
                return;
            }

            if (cmb_Category.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(cmb_Category, "Please select Category.");
                cmb_Category.Focus();
                return;
            }

            if (txt_price.Text.ToString() == "")
            {
                txt_price.Text = "0.00";
            }

            if (CreateCategory(cmb_Category.Text.Trim(), ref categoryID) == false)
            {
                return;
            }

            string query = string.Empty;
            if (btn_save.Text == "SAVE")
                query = "INSERT INTO Product (ProductCode, ProductName, ProductDescription, Price, CategoryID, CreatedByID) values ('" + txt_code.Text.Trim() + "','" + txt_ProductName.Text.Trim() + "','" + txt_Description.Text.Trim() + "'," + txt_price.Text.Trim() + "," + categoryID + "," + DataAccess.gbl_longUserID + ")";
            else
                query = "UPDATE Product SET ProductCode = '" + txt_code.Text.Trim() + "', ProductName = '" + txt_ProductName.Text.Trim() + "', ProductDescription = '" + txt_Description.Text.Trim() + "', CategoryID = " + categoryID + ", Price = " + txt_price.Text.Trim() + ",UpdatedByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where ProductID = " + lbl_id.Text.Trim();
            string message = _datalayer.Opration(query);

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

        public bool CreateCategory(string categoryName, ref int categoryID)
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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (deleteDisable)
                DeleteRecord();
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["ProductID"].Visible = false;
            dgv_master.Columns["ProductDescription"].Visible = false;
            dgv_master.Columns["ProductName"].HeaderText = "Item Name";
            dgv_master.Columns["ProductCode"].HeaderText = "Code";
            dgv_master.Columns["CategoryName"].HeaderText = "Category";
            dgv_master.Columns["Price"].HeaderText = "Price";
            dgv_master.Columns["ProductStock"].HeaderText = "Stock";

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

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_ProductDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_Description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Search...")
            {
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductCode LIKE '%{0}%' OR ProductName LIKE '%{0}%' OR ProductDescription LIKE '%{0}%' OR CategoryName LIKE '%{0}%'", txt_search.Text);
                dgv_master.Refresh();
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search...")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search...";
                txt_search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

    }

}
