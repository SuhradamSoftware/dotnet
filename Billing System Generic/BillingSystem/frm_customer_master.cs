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

            txt_State_name.Text = txt_name.Text = txt_Contact_Person.Text = txt_Department.Text =  txt_address.Text = txt_city.Text = txt_pin_code.Text = txt_mobile_no.Text = txt_phone_no.Text = txt_fax_no.Text = txt_email_id.Text = "";

            btn_save.Text = "Save";
            deleteDisable = false;
            ep1.Clear();
            lbl_user_name.Visible = txt_State_name.Visible = true;
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.CustomerID, um.State, um.CustomerName,um.DepartmentName,um.ContactPerson, um.Address, um.City, um.PostalCode, um.MobileNumber, um.PhoneNumber, um.FaxNumber, um.EmailAddress FROM Customer AS um where um.IsDeleted = 0";

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
                    lbl_id.Text = dgv_master.CurrentRow.Cells["CustomerID"].Value.ToString();
                    txt_State_name.Text = dgv_master.CurrentRow.Cells["State"].Value.ToString();
                    txt_name.Text = dgv_master.CurrentRow.Cells["CustomerName"].Value.ToString();
                    txt_Department.Text = dgv_master.CurrentRow.Cells["DepartmentName"].Value.ToString();
                    txt_Contact_Person.Text = dgv_master.CurrentRow.Cells["ContactPerson"].Value.ToString();
                    txt_address.Text = dgv_master.CurrentRow.Cells["Address"].Value.ToString();
                    txt_city.Text = dgv_master.CurrentRow.Cells["City"].Value.ToString();
                    txt_pin_code.Text = dgv_master.CurrentRow.Cells["PostalCode"].Value.ToString();
                    txt_mobile_no.Text = dgv_master.CurrentRow.Cells["MobileNumber"].Value.ToString();
                    txt_phone_no.Text = dgv_master.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                    txt_fax_no.Text = dgv_master.CurrentRow.Cells["FaxNumber"].Value.ToString();
                    txt_email_id.Text = dgv_master.CurrentRow.Cells["EmailAddress"].Value.ToString();

                    txt_State_name.Focus();
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
                    query = "update Customer set IsDeleted = 1, DeletedByID = " + DataAccess.gbl_longUserID + ", DeletedDate = GETDATE() where CustomerID = " + lbl_id.Text.Trim();
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
                ep1.SetError(txt_name, "Please enter customer name.");
                txt_name.Focus();
                return;
            }
            if (txt_mobile_no.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_mobile_no, "Please enter Mobile No.");
                txt_mobile_no.Focus();
                return;
            }
            if (txt_address.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_address, "Please enter address.");
                txt_address.Focus();
                return;
            }

            if (txt_State_name.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_State_name, "Please enter state name.");
                txt_State_name.Focus();
                return;
            }

            if (txt_city.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_State_name, "Please enter city name.");
                txt_city.Focus();
                return;
            } 

            string query = string.Empty;
            if (btn_save.Text == "Save")
                query = "insert into Customer (State, CustomerName,DepartmentName,ContactPerson, Address, City, PostalCode, MobileNumber, PhoneNumber, FaxNumber, EmailAddress, CreatedByID) values ('" + txt_State_name.Text.Trim() + "','" + txt_name.Text.Trim() + "','" + txt_Department.Text.Trim() + "','"  + txt_Contact_Person.Text.Trim() + "','" + txt_address.Text.Trim() + "', '" + txt_city.Text.ToString() + "','" + txt_pin_code.Text.Trim() + "','" + txt_mobile_no.Text.Trim() + "','" + txt_phone_no.Text.Trim() + "','" + txt_fax_no.Text.Trim() + "','" + txt_email_id.Text.Trim() + "'," + DataAccess.gbl_longUserID + ")";
            else
                query = "update Customer set State = '" + txt_State_name.Text.Trim() + "', CustomerName = '" + txt_name.Text.Trim() + "', DepartmentName = '" + txt_Department.Text.Trim() + "', ContactPerson = '" + txt_Contact_Person.Text.Trim() + "', Address = '" + txt_address.Text.Trim() + "', City = '" + txt_city.Text.ToString() + "', PostalCode = '" + txt_pin_code.Text.Trim() + "', MobileNumber = '" + txt_mobile_no.Text.Trim() + "', PhoneNumber = '" + txt_phone_no.Text.Trim() + "', FaxNumber = '" + txt_fax_no.Text.Trim() + "', EmailAddress = '" + txt_email_id.Text.Trim() + "', UpdateByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where CustomerID = " + lbl_id.Text.Trim();
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
            lbl_id.Text = dgv_master.CurrentRow.Cells["CustomerID"].Value.ToString();
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
            dgv_master.Columns["CustomerID"].Visible = false;
            dgv_master.Columns["State"].Visible = false;

            dgv_master.Columns["CustomerName"].HeaderText = "Customer Name";
            dgv_master.Columns["DepartmentName"].HeaderText = "Department";
            dgv_master.Columns["ContactPerson"].HeaderText = "Contact";

            dgv_master.Columns["Address"].HeaderText = "Address";

            dgv_master.Columns["City"].HeaderText = "City";

            dgv_master.Columns["PostalCode"].HeaderText = "Pin Code";

            dgv_master.Columns["MobileNumber"].HeaderText = "Mobile No";

            dgv_master.Columns["PhoneNumber"].HeaderText = "Phone No";

            dgv_master.Columns["FaxNumber"].HeaderText = "Fax No";

            dgv_master.Columns["EmailAddress"].HeaderText = "Email Id";

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
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("DepartmentName LIKE '%{0}%' OR ContactPerson LIKE '%{0}%' OR CustomerName LIKE '%{0}%' OR Address LIKE '%{0}%' OR City LIKE '%{0}%' OR PostalCode LIKE '%{0}%' OR MobileNumber LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%' OR FaxNumber LIKE '%{0}%' OR EmailAddress LIKE '%{0}%'", txt_search.Text);
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

        private void txt_mobile_no_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_fax_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_email_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_city_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_pin_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
