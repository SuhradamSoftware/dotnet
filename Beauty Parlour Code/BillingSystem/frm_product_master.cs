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
            frmMain mf = this.ParentForm as frmMain;
            mf.tlp_mdi.Visible = false;

            SetFormLocation();
            Reset();
            cmb_product.Focus();
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
            lbl_product_id.Text = lbl_pr_id.Text = "0";
            BindGrid();

            AutoCompleteStringCollection product_Collection_ = new AutoCompleteStringCollection();
            string product_query = "select fld_product_id, fld_product_name from tbl_product order by fld_product_name asc";
            DataTable product_Data = new DataTable();
            product_Data = _datalayer.bindDataTable(product_query);

            DataRow p_dr;
            p_dr = product_Data.NewRow();
            p_dr.ItemArray = new object[] { 0, "Select Product" };
            product_Data.Rows.InsertAt(p_dr, 0);

            cmb_product.AutoCompleteCustomSource = product_Collection_;
            cmb_product.ValueMember = "fld_product_id";
            cmb_product.DisplayMember = "fld_product_name";
            cmb_product.DataSource = product_Data;

            foreach (DataRow row in product_Data.Rows) // Loop over the rows.
            {
                product_Collection_.Add(row["fld_product_name"].ToString());
            }

            txt_qty.Text = txt_rate.Text = txt_point.Text = "";

            btn_save.Text = "Save";
            deleteDisable = false;
            ep1.Clear();
            cmb_product.Focus();
        }

        public void BindGrid()
        {
            dgv_master.DataSource = null;
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT fld_product_id, fld_product_name, fld_rate, fld_point FROM tbl_product order by fld_product_name asc";
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
                    lbl_id.Text = dgv_master.CurrentRow.Cells["fld_stock_id"].Value.ToString();
                    cmb_product.SelectedValue = lbl_product_id.Text.ToString();
                    txt_qty.Text = dgv_master.CurrentRow.Cells["fld_inward"].Value.ToString();
                    txt_rate.Text = dgv_master.CurrentRow.Cells["fld_rate"].Value.ToString();
                    txt_point.Text = dgv_master.CurrentRow.Cells["fld_point"].Value.ToString();
                    lbl_total_rate.Text = dgv_master.CurrentRow.Cells["fld_total_rate"].Value.ToString();

                    btn_save.Text = "Update";
                    deleteDisable = true;
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Product Fill Data", ex.Message.ToString());
            }
        }

        public void DeleteRecord()
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Empty;
                    query = "delete tbl_product_stock where fld_stock_id = " + lbl_id.Text.Trim();
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
                _datalayer.ErrorLog("Product delete Data", ex.Message.ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_product.SelectedValue.ToString() == "0")
                {
                    ep1.Clear();
                    ep1.SetError(cmb_product, "Please select product.");
                    cmb_product.Focus();
                    return;
                }

                if (txt_qty.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_qty, "Please enter product quantity.");
                    txt_qty.Focus();
                    return;
                }

                if (txt_rate.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_rate, "Please enter product rate.");
                    txt_rate.Focus();
                    return;
                }

                if (txt_point.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_point, "Please enter product point.");
                    txt_point.Focus();
                    return;
                }

                string query = string.Empty;
                string final_message = string.Empty;
                if (btn_save.Text == "Save")
                {
                    query = "insert into tbl_product_stock (fld_product_id, fld_rate, fld_point, fld_inward, fld_outward) values (" + cmb_product.SelectedValue.ToString() + "," + txt_rate.Text.Trim() + "," + txt_point.Text.Trim() + "," + txt_qty.Text.Trim() + ", 0.00)";
                    final_message = _datalayer.Opration(query);

                    query = "update tbl_product set fld_rate = " + txt_rate.Text.Trim() + ", fld_point = " + txt_point.Text.Trim() + " where fld_product_id = " + lbl_pr_id.Text.Trim();
                    final_message = _datalayer.Opration(query);
                }
                else
                {
                    query = "update tbl_product_stock set fld_product_id = " + cmb_product.SelectedValue.ToString() + ", fld_rate = " + txt_rate.Text.Trim() + ", fld_point = " + txt_point.Text.Trim() + ", fld_inward = " + txt_qty.Text.Trim() + " where fld_stock_id = " + lbl_id.Text.Trim();
                    final_message = _datalayer.Opration(query);

                    query = "update tbl_product set fld_rate = " + txt_rate.Text.Trim() + ", fld_point = " + txt_point.Text.Trim() + " where fld_product_id = " + lbl_pr_id.Text.Trim();
                    final_message = _datalayer.Opration(query);
                }
                if (final_message == "Success")
                {
                    MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Product save", ex.Message.ToString());
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
            lbl_id.Text = dgv_master.CurrentRow.Cells["fld_stock_id"].Value.ToString();
            DeleteRecord();
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbl_product_id.Text == "0")
            {
                lbl_product_id.Text = dgv_master.CurrentRow.Cells["fld_product_id"].Value.ToString();
                DataSet _ds = new DataSet();
                string query = string.Empty;

                query = "SELECT fld_stock_id, fld_date, fld_point, fld_inward, fld_rate, (fld_inward * fld_rate) as fld_total_rate FROM tbl_product_stock where fld_product_id = " + lbl_product_id.Text.Trim() + " order by fld_date desc";

                _ds = _datalayer.bindDataSet(query);

                if (_ds.Tables.Count > 0)
                {
                    dgv_master.DataSource = _ds.Tables[0];
                }
            }
            else
            {
                FillData();
            }
        }

        private void dgv_master_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lbl_product_id.Text != "0")
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
            else
            {
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
                        this.contextMenuStrip2.Show(dgv_master, relativeMousePosition);
                    }
                }
            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (lbl_product_id.Text == "0")
            {
                dgv_master.Columns["fld_product_id"].Visible = false;
                dgv_master.Columns["fld_product_name"].HeaderText = "Product Name";
                dgv_master.Columns["fld_rate"].HeaderText = "Rate";
                dgv_master.Columns["fld_point"].HeaderText = "Point";
            }
            else
            {
                dgv_master.Columns["fld_stock_id"].Visible = false;
                dgv_master.Columns["fld_date"].HeaderText = "Date";
                dgv_master.Columns["fld_date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_master.Columns["fld_point"].HeaderText = "Point";
                dgv_master.Columns["fld_inward"].HeaderText = "Quantity";
                dgv_master.Columns["fld_rate"].HeaderText = "Rate";
                dgv_master.Columns["fld_total_rate"].HeaderText = "Total Rate";
            }

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
        }

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Search...")
            {
                if (dgv_master.DataSource != null)
                {
                    if (dgv_master.RowCount > 0)
                    {
                        if (lbl_product_id.Text == "0")
                        {
                            (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_product_name LIKE '%{0}%' OR convert(fld_rate, 'System.String') LIKE '%{0}%' OR convert(fld_point, 'System.String') LIKE '%{0}%'", txt_search.Text);
                        }
                        else
                        {
                            (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("convert(fld_date, 'System.String') LIKE '%{0}%' OR convert(fld_inward, 'System.String') LIKE '%{0}%' OR convert(fld_rate, 'System.String') LIKE '%{0}%' OR convert(fld_point, 'System.String') LIKE '%{0}%' OR convert(fld_total_rate, 'System.String') LIKE '%{0}%'", txt_search.Text);
                        }
                        dgv_master.Refresh();
                    }
                }
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

        private void txt_product_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_rate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_point_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_point_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_product.SelectedValue.ToString() != "0")
            {
                lbl_pr_id.Text = cmb_product.SelectedValue.ToString();
                DataTable _dt = new DataTable();
                string query = string.Empty;

                query = "SELECT fld_rate, fld_point FROM tbl_product where fld_product_id = " + lbl_pr_id.Text.ToString();
                _dt = _datalayer.bindDataTable(query);

                if (_dt.Rows.Count > 0)
                {
                    txt_rate.Text = _dt.Rows[0]["fld_rate"].ToString();
                    txt_point.Text = _dt.Rows[0]["fld_point"].ToString();
                }
                btn_p_save.Enabled = false;
            }
            else
            {
                lbl_pr_id.Text = "0";
                txt_rate.Text = txt_point.Text = "";
                btn_p_save.Enabled = true;
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

        private void btn_p_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure add this record ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cmb_product.Text.ToString() == "" || cmb_product.Text.ToString() == "Select Product")
                {
                    ep1.Clear();
                    ep1.SetError(cmb_product, "Please enter product name.");
                    cmb_product.Focus();
                    return;
                }

                string query = string.Empty;
                if (btn_p_save.Text == "Add")
                    query = "insert into tbl_product (fld_product_name) values ('" + cmb_product.Text.Trim() + "')";
                else
                    query = "update tbl_product set fld_product_name = '" + cmb_product.Text.Trim() + "' where fld_product_id = " + lbl_p_id.Text.Trim();
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
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            CalculateRate();
        }

        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            CalculateRate();
        }

        public void CalculateRate()
        {
            decimal quantity = 0, rate = 0, total_rate = 0;

            if (string.IsNullOrEmpty(txt_qty.Text))
                quantity = 0;
            else
                quantity = Convert.ToDecimal(txt_qty.Text.Trim().ToString());

            if (string.IsNullOrEmpty(txt_rate.Text))
                rate = 0;
            else
                rate = Convert.ToDecimal(txt_rate.Text.Trim().ToString());

            total_rate = quantity * rate;
            lbl_total_rate.Text = total_rate.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Empty;
                    query = "delete tbl_product where fld_product_id = " + dgv_master.CurrentRow.Cells["fld_product_id"].Value.ToString();
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
                _datalayer.ErrorLog("Product delete Data", ex.Message.ToString());
            }
        }
    }
}
