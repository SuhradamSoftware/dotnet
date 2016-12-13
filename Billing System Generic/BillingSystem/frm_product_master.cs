using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Drawing.Drawing2D;
using BillingSystem.Properties;

namespace BillingSystem
{
    public partial class frm_Product_master : Form
    {
        DataLayer _datalayer = new DataLayer();
        private bool deleteDisable = false;
        public frm_Product_master()
        {
            InitializeComponent();
        }

        private void frm_user_master_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            Reset();
        }

        public void SetFormLocation()
        {
            this.Height = DataAccess.gbl_client_height;
            this.Width = DataAccess.gbl_client_width;

            tlp_main.Height = DataAccess.gbl_client_height;
            tlp_main.Width = DataAccess.gbl_client_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        public void Reset()
        {
            BindGrid();

            txt_ProductDescription.Text = txt_name.Text = "";

            btn_save.Text = "Save";
            deleteDisable = false;
            ep1.Clear();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.ProductID, um.ProductName, um.ProductDescription FROM Product AS um where um.IsDeleted = 0";

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
                 
                    btn_save.Text = "Update";
                    deleteDisable = true;
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


           

            string query = string.Empty;
            if (btn_save.Text == "Save")
                query = "insert into Product (ProductName, ProductDescription, CreatedByID) values ('" + txt_name.Text.Trim() + "','" + txt_ProductDescription.Text.Trim() + "'," + DataAccess.gbl_longUserID + ")";
            else
                query = "update Product set ProductName = '" + txt_name.Text.Trim() + "', ProductDescription = '" + txt_ProductDescription.Text.Trim() + "',UpdatedByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where ProductID = " + lbl_id.Text.Trim();
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_id.Text = dgv_master.CurrentRow.Cells["ProductID"].Value.ToString();
            DeleteRecord();
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void dgv_master_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Here you can do whatever you want with the cell
                    this.dgv_master.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dgv_master.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(dgv_master, relativeMousePosition);
                }
            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["ProductID"].Visible = false;
            dgv_master.Columns["ProductName"].HeaderText = "Product Name";
            dgv_master.Columns["ProductDescription"].HeaderText = "ProductDescription";

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_user_master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dgv_master.SelectedRows.Count > 0)
                    Reset();
                else
                    this.Close();
            }

            if (e.KeyCode == Keys.Enter)
                if (dgv_master.SelectedRows.Count > 0)
                    dgv_master_CellDoubleClick(dgv_master, new DataGridViewCellEventArgs(0, dgv_master.CurrentRow.Index));
        }

        private void txt_pin_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_fax_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_mobile_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_phone_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Search...")
            {
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%' OR ProductDescription LIKE '%{0}%'", txt_search.Text);
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
            if (e.KeyData == Keys.Enter && (e.KeyData == Keys.LShiftKey || e.KeyData == Keys.LShiftKey))
            {
                txt_ProductDescription.Text = txt_ProductDescription.Text + "\n";
            }
            else if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

    }
}
