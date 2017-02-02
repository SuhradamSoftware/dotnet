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
    public partial class frm_point : Form
    {
        DataLayer _datalayer = new DataLayer();
        In_DataLayer _indatalayer = new In_DataLayer();
        public frm_point()
        {
            InitializeComponent();
        }

        private void frm_party_master_Load(object sender, EventArgs e)
        {
            frmMain mf = this.ParentForm as frmMain;
            mf.tlp_mdi.Visible = false;

            Master_Reset();
            SetFormLocation();
            cmb_employee.Focus();
        }

        private void frm_party_master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dgv_master.SelectedRows.Count > 0)
                    Master_Reset();
                else
                    this.Close();
            }
        }

        public void SetFormLocation()
        {
            this.Height = DataAccess.gbl_client_height;
            this.Width = DataAccess.gbl_client_width;

            tlp_main.Height = DataAccess.gbl_client_height;
            tlp_main.Width = DataAccess.gbl_client_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        public void Master_Reset()
        {
            lbl_product_id.Text = lbl_id.Text = "0";
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

            AutoCompleteStringCollection product_Collection_ = new AutoCompleteStringCollection();
            string product_query = "select fld_product_id, fld_product_name from tbl_product order by fld_product_name asc";
            DataTable product_Data = new DataTable();
            product_Data = _datalayer.bindDataTable(product_query);

            DataRow p_dr;
            p_dr = product_Data.NewRow();
            p_dr.ItemArray = new object[] { 0, "Select Product" };
            product_Data.Rows.InsertAt(p_dr, 0);

            cmb_product_name.AutoCompleteCustomSource = product_Collection_;
            cmb_product_name.ValueMember = "fld_product_id";
            cmb_product_name.DisplayMember = "fld_product_name";
            cmb_product_name.DataSource = product_Data;

            foreach (DataRow row in product_Data.Rows) // Loop over the rows.
            {
                product_Collection_.Add(row["fld_product_name"].ToString());
            }

            ep1.Clear();
            BindGrid();
            cmb_employee.Focus();
        }

        public void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_master.CurrentRow.Cells["fld_point_id"].Value.ToString();
                    cmb_employee.SelectedValue = lbl_product_id.Text.ToString();
                    cmb_product_name.SelectedValue = dgv_master.CurrentRow.Cells["fld_product_id"].Value.ToString();
                    txt_qty.Text = dgv_master.CurrentRow.Cells["fld_product_qty"].Value.ToString();
                    lbl_total_point.Text = dgv_master.CurrentRow.Cells["fld_point"].Value.ToString();

                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Point Fill Data", ex.Message.ToString());
            }
        }

        public void BindGrid()
        {
            DataTable _dt = new DataTable();
            string query = "select e.fld_employee_id, e.fld_employee_name, sum(fld_point) as fld_total_point from tbl_employee as e inner join tbl_point as p on e.fld_employee_id = p.fld_employee_id group by e.fld_employee_id, e.fld_employee_name  order by e.fld_employee_name asc";
            _dt = _datalayer.bindDataTable(query);
            if (_dt.Rows.Count > 0)
            {
                dgv_master.DataSource = _dt;
            }
            else
                dgv_master.DataSource = null;
        }

        public void DeleteRecord()
        {
            try
            {
                string value = "";
                if (Box.InputBox("Varification", "Password:", ref value) == DialogResult.OK)
                {
                    DataTable _dtRightsPassword = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'RightsPassword')");
                    string password = _dtRightsPassword.Rows[0]["fld_value"].ToString();
                    if (value.ToString() == password)
                    {
                        if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string query = string.Empty;
                            query = "delete from Transactions where TransactionId = " + lbl_id.Text.Trim();
                            string message = _datalayer.Opration(query);
                            if (message == "Success")
                            {
                                MessageBox.Show("Data Delete Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Master_Reset();
                            }
                            else
                            {
                                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password, Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Point delete Data", ex.Message.ToString());
            }
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbl_product_id.Text == "0")
            {
                lbl_product_id.Text = dgv_master.CurrentRow.Cells["fld_employee_id"].Value.ToString();
                cmb_employee.SelectedValue = lbl_product_id.Text.ToString();
                DataSet _ds = new DataSet();
                string query = string.Empty;

                query = "SELECT pro.fld_product_id, p.fld_point_id, p.fld_product_qty, p.fld_point, pro.fld_product_name FROM tbl_product as pro inner join tbl_point as p on pro.fld_product_id = p.fld_product_id where p.fld_employee_id = " + cmb_employee.SelectedValue.ToString() + " order by pro.fld_product_name asc";

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
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (lbl_product_id.Text == "0")
            {
                dgv_master.Columns["fld_employee_id"].Visible = false;
                dgv_master.Columns["fld_employee_name"].HeaderText = "Employee Name";
                dgv_master.Columns["fld_total_point"].HeaderText = "Total Point";
            }
            else
            {
                dgv_master.Columns["fld_product_id"].Visible = false;
                dgv_master.Columns["fld_point_id"].Visible = false;
                dgv_master.Columns["fld_product_name"].HeaderText = "Product Name";
                dgv_master.Columns["fld_product_qty"].HeaderText = "Product Quantity";
                dgv_master.Columns["fld_point"].HeaderText = "Product Point";
            }

            foreach (DataGridViewRow row in dgv_master.Rows)
            {
                row.Height = 24;
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
                            (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_employee_name LIKE '%{0}%' OR convert(fld_total_point, 'System.String') LIKE '%{0}%'", txt_search.Text);
                        }
                        else
                        {
                            (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_product_name LIKE '%{0}%' OR convert(fld_product_qty, 'System.String') LIKE '%{0}%' OR convert(fld_point, 'System.String') LIKE '%{0}%'", txt_search.Text);
                        }
                    }
                }
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

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void cmb_employee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cmb_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_product_name.SelectedValue.ToString() == "0")
            {
                lbl_point.Text = "0.00";
            }
            else
            {
                string product_query = "select fld_point from tbl_product where fld_product_id = " + cmb_product_name.SelectedValue.ToString();
                DataTable product_Data = new DataTable();
                product_Data = _datalayer.bindDataTable(product_query);
                if (product_Data.Rows.Count > 0)
                    lbl_point.Text = product_Data.Rows[0]["fld_point"].ToString();
            }
            Calculation();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_id.Text = dgv_master.CurrentRow.Cells["fld_point_id"].Value.ToString();
            DeleteRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmb_employee.SelectedValue.ToString() == "0")
            {
                ep1.Clear();
                ep1.SetError(cmb_employee, "Please select employee.");
                cmb_employee.Focus();
                return;
            }
            if (cmb_product_name.SelectedValue.ToString() == "0")
            {
                ep1.Clear();
                ep1.SetError(cmb_product_name, "Please select product.");
                cmb_product_name.Focus();
                return;
            }
            string query = string.Empty;
            string message = string.Empty;
            if (btnSave.Text == "Save")
            {
                query = "insert into tbl_point (fld_employee_id, fld_product_id, fld_product_qty, fld_point) values (" + cmb_employee.SelectedValue.ToString() + ", " + cmb_product_name.SelectedValue.ToString() + ", " + txt_qty.Text.Trim().ToString() + ", " + lbl_total_point.Text.ToString() + ")";
                message = _datalayer.Opration(query);
            }
            else
            {
                query = "update tbl_point set fld_employee_id = " + cmb_employee.SelectedValue.ToString() + ", fld_product_id = " + cmb_product_name.SelectedValue.ToString() + ", fld_product_qty = " + txt_qty.Text.Trim().ToString() + ", fld_point = " + lbl_total_point.Text.Trim() + " where fld_point_id = " + lbl_id.Text.Trim();
                message = _datalayer.Opration(query);
            }

            if (message == "Success")
            {
                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Master_Reset();
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_product_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        public void Calculation()
        {
            decimal quantity = 0, point = 0, total_point = 0;

            if (string.IsNullOrEmpty(txt_qty.Text))
                quantity = 0;
            else
                quantity = Convert.ToDecimal(txt_qty.Text.Trim().ToString());

            if (string.IsNullOrEmpty(lbl_point.Text))
                point = 0;
            else
                point = Convert.ToDecimal(lbl_point.Text.Trim().ToString());

            total_point = quantity * point;
            lbl_total_point.Text = total_point.ToString();
        }

        private void cmb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
