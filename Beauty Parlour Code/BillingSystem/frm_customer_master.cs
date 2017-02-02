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
    public partial class frm_customer_master : Form
    {
        DataLayer _datalayer = new DataLayer();
        private bool deleteDisable = false;
        public frm_customer_master()
        {
            InitializeComponent();
        }

        private void frm_user_master_Load(object sender, EventArgs e)
        {
            frmMain mf = this.ParentForm as frmMain;
            mf.tlp_mdi.Visible = false;
            SetFormLocation();
            Reset();
            txt_name.Focus();
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
            btn_save.Text = "Save";
            BindGrid();
            txt_name.Text = txt_address.Text = txt_phone_no.Text = "";
            deleteDisable = false;
            ep1.Clear();
            txt_name.Focus();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.fld_customer_id, um.fld_customer_name, um.fld_phone_number, um.fld_address FROM tbl_customer AS um Order By um.fld_customer_name asc";

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
                    lbl_id.Text = dgv_master.CurrentRow.Cells["fld_customer_id"].Value.ToString();
                    txt_name.Text = dgv_master.CurrentRow.Cells["fld_customer_name"].Value.ToString();
                    txt_address.Text = dgv_master.CurrentRow.Cells["fld_address"].Value.ToString();
                    txt_phone_no.Text = dgv_master.CurrentRow.Cells["fld_phone_number"].Value.ToString();
                    txt_name.Focus();
                    btn_save.Text = "Update";
                    deleteDisable = true;
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Customer Fill Data", ex.Message.ToString());
            }
        }

        public void DeleteRecord()
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Empty;
                    query = "delete tbl_customer where fld_customer_id = " + lbl_id.Text.Trim();
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
                _datalayer.ErrorLog("Customer Delete Record", ex.Message.ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_name, "Please enter customer name.");
                    txt_name.Focus();
                    return;
                }

                string query = string.Empty;
                string message = string.Empty;
                if (btn_save.Text == "Save")
                {
                    query = "insert into tbl_customer (fld_customer_name,fld_address, fld_phone_number) values ('" + txt_name.Text.Trim() + "','" + txt_address.Text.Trim() + "','" + txt_phone_no.Text.Trim() + "')";
                    message = _datalayer.Opration(query);
                }
                else
                {
                    query = "update tbl_customer set fld_customer_name = '" + txt_name.Text.Trim() + "', fld_address = '" + txt_address.Text.Trim() + "', fld_phone_number = '" + txt_phone_no.Text.Trim() + "' where fld_customer_id = " + lbl_id.Text.Trim();
                    message = _datalayer.Opration(query);
                }

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
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Customer save/update record", ex.Message.ToString());
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
            lbl_id.Text = dgv_master.CurrentRow.Cells["fld_customer_id"].Value.ToString();
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
            dgv_master.Columns["fld_customer_id"].Visible = false;
            dgv_master.Columns["fld_customer_name"].HeaderText = "Customer Name";
            dgv_master.Columns["fld_address"].HeaderText = "Address";
            dgv_master.Columns["fld_phone_number"].HeaderText = "Phone No";

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
                if (dgv_master.RowCount > 0)
                {
                    (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_customer_name LIKE '%{0}%' OR fld_address LIKE '%{0}%' OR fld_phone_number LIKE '%{0}%'", txt_search.Text);
                    dgv_master.Refresh();
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

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_phone_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && (e.KeyData == Keys.LShiftKey || e.KeyData == Keys.LShiftKey))
            {
                txt_address.Text = txt_address.Text + "\n";
            }
            else if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
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

        private void txt_phone_no_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
