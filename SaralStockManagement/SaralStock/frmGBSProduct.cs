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
            Reset();
        }

        public void Reset()
        {
            BindGrid();

            txt_ProductDescription.Text = txt_name.Text = txt_price.Text = txt_company.Text = "";

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
                    txt_name.Text = dgv_master.CurrentRow.Cells["ProductName"].Value.ToString();
                    txt_ProductDescription.Text = dgv_master.CurrentRow.Cells["ProductDescription"].Value.ToString();
                    txt_company.Text = dgv_master.CurrentRow.Cells["ProductCompany"].Value.ToString();
                    txt_price.Text = string.Format("{0:#,##0.00}", dgv_master.CurrentRow.Cells["Price"].Value.ToString());

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
            if (txt_name.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_name, "Please enter Product name.");
                txt_name.Focus();
                return;
            }

            if (txt_ProductDescription.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_ProductDescription, "Please enter Product Description.");
                txt_ProductDescription.Focus();
                return;
            }

            if (txt_price.Text.ToString() == "")
            {
                txt_price.Text = "0.00";
            }

            string query = string.Empty;
            if (btn_save.Text == "SAVE")
                query = "INSERT INTO Product (ProductName, ProductDescription, ProductCompany, Price, CreatedByID) values ('" + txt_name.Text.Trim() + "','" + txt_ProductDescription.Text.Trim() + "','" + txt_company.Text.Trim() + "'," + txt_price.Text.Trim() + "," + DataAccess.gbl_longUserID + ")";
            else
                query = "UPDATE Product SET ProductName = '" + txt_name.Text.Trim() + "', ProductDescription = '" + txt_ProductDescription.Text.Trim() + "', ProductCompany = '" + txt_company.Text.Trim() + "', Price = " + txt_price.Text.Trim() + ",UpdatedByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where ProductID = " + lbl_id.Text.Trim();
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
            dgv_master.Columns["ProductName"].HeaderText = "Product Name";
            dgv_master.Columns["ProductDescription"].HeaderText = "Description";
            dgv_master.Columns["ProductCompany"].HeaderText = "Company";
            dgv_master.Columns["Price"].HeaderText = "Price";

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

      private void txt_company_KeyDown(object sender, KeyEventArgs e)
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
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%' OR ProductDescription LIKE '%{0}%' OR ProductCompany LIKE '%{0}%'", txt_search.Text);
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

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        } 

    }
       
}
