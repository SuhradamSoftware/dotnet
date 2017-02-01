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
        private bool deleteDisable = false;
        public frmSaralPurchase()
        {
            InitializeComponent();
        }

        private void frmSaralProduct_Load(object sender, EventArgs e)
        {
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height - 120;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
            //this.Location = new Point(DataAccess.tlp_main_x + 10, DataAccess.tlp_main_y + 10);

            //this.Height = DataAccess.gbl_client_height;
            //this.Width = DataAccess.gbl_client_width;

            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Reset();
            FillDropdown();
        }

        public void FillDropdown()
        {
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            string dropdownSQL = "select PartyId, PartyName from Party where IsDeleted = 0 order by PartyName asc";
            DataTable customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            DataRow dr_1;
            dr_1 = customerData.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Party" };
            customerData.Rows.InsertAt(dr_1, 0);

            cmb_Party.AutoCompleteCustomSource = myCollection;
            cmb_Party.ValueMember = "PartyId";
            cmb_Party.DisplayMember = "PartyName";
            cmb_Party.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                myCollection.Add(row["PartyName"].ToString());
            }


            AutoCompleteStringCollection brandCollection = new AutoCompleteStringCollection();
            dropdownSQL = "select ProductCompanyId, CompanyName from ProductCompanyId where IsDeleted = 0 order by CompanyName asc";
            customerData = new DataTable();
            customerData = _datalayer.bindDataTable(dropdownSQL);

            DataRow brandRow;
            brandRow = customerData.NewRow();
            brandRow.ItemArray = new object[] { 0, "Select Brand" };
            customerData.Rows.InsertAt(brandRow, 0);

            cmb_Party.AutoCompleteCustomSource = brandCollection;
            cmb_Party.ValueMember = "ProductCompanyId";
            cmb_Party.DisplayMember = "CompanyName";
            cmb_Party.DataSource = customerData;

            foreach (DataRow row in customerData.Rows) // Loop over the rows.
            {
                brandCollection.Add(row["CompanyName"].ToString());
            }

        }

        public void Reset()
        {
            BindGrid();
            txt_product.Text = txt_category.Text = txt_qty.Text = txt_sale_price.Text = txt_itemno.Text = txt_category.Text = "";
            cmb_Party.SelectedIndex = 0;
            cmb_brand.SelectedIndex = 0;
            txt_expiryDate.Refresh();
            btn_save.Text = "SAVE";
            deleteDisable = false;
            btn_delete.Visible = false;
            ep1.Clear();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.ProductID, um.ProductName, um.ProductDescription,um.ProductCompany, um.Price FROM Product AS um where um.IsDeleted = 0";

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
                    txt_product.Text = dgv_master.CurrentRow.Cells["ProductName"].Value.ToString();
                    txt_Details.Text = dgv_master.CurrentRow.Cells["ProductDescription"].Value.ToString();
                    cmb_brand.SelectedValue = dgv_master.CurrentRow.Cells["ProductCompany"].Value.ToString();
                    txt_sale_price.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());
                    txt_qty.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());
                    txt_itemno.Text = dgv_master.CurrentRow.Cells["ProductName"].Value.ToString();
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

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
