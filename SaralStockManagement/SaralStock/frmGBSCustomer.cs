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

namespace BillingSystem
{
    public partial class frmGBSCustomer : Form
    {
        DataLayer _datalayer = new DataLayer();
        private bool deleteDisable = false;
        public frmGBSCustomer()
        {
            InitializeComponent();
        }

        private void frmGBSCustomer_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            BindGrid();

            txt_name.Text = txt_address.Text = txt_city.Text = txt_mobile_no.Text = txt_phone_no.Text = txt_email_id.Text = "";

            btn_save.Text = "SAVE";
            deleteDisable = false;
            btn_delete.Visible = false;
        }

        private void BindGrid()
        {
            DataSet customerData = new DataSet();
            string sqlString = string.Empty;

            sqlString = "SELECT um.CustomerID, um.CustomerName,um.Address, um.City, um.MobileNumber, um.PhoneNumber, um.EmailAddress FROM Customer AS um where um.IsDeleted = 0";

            customerData = _datalayer.bindDataSet(sqlString);

            if (customerData.Tables.Count > 0)
            {
                dgv_master.DataSource = customerData.Tables[0];
            }
        }

        private void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_master.CurrentRow.Cells["CustomerID"].Value.ToString();
                    txt_name.Text = dgv_master.CurrentRow.Cells["CustomerName"].Value.ToString();
                    txt_address.Text = dgv_master.CurrentRow.Cells["Address"].Value.ToString();
                    txt_city.Text = dgv_master.CurrentRow.Cells["City"].Value.ToString();
                    txt_mobile_no.Text = dgv_master.CurrentRow.Cells["MobileNumber"].Value.ToString();
                    txt_phone_no.Text = dgv_master.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                    txt_email_id.Text = dgv_master.CurrentRow.Cells["EmailAddress"].Value.ToString();
                    txt_name.Focus();
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

        private void DeleteRecord()
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
                ep1.SetError(txt_mobile_no, "Please enter mobile No.");
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

            if (txt_city.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_city, "Please enter city name.");
                txt_city.Focus();
                return;
            }

            string query = string.Empty;
            if (btn_save.Text == "SAVE")
                query = "INSERT INTO Customer (CustomerName, Address, City,  MobileNumber, PhoneNumber,  EmailAddress, CreatedByID) values ('" + txt_name.Text.Trim() + "','" + txt_address.Text.Trim() + "', '" + txt_city.Text.ToString() + "','" + txt_mobile_no.Text.Trim() + "','" + txt_phone_no.Text.Trim() + "','" + txt_email_id.Text.Trim() + "'," + DataAccess.gbl_longUserID + ")";
            else
                query = "UPDATE Customer SET CustomerName = '" + txt_name.Text.Trim() + "', Address = '" + txt_address.Text.Trim() + "', City = '" + txt_city.Text.ToString() + "', MobileNumber = '" + txt_mobile_no.Text.Trim() + "', PhoneNumber = '" + txt_phone_no.Text.Trim() + "', EmailAddress = '" + txt_email_id.Text.Trim() + "', UpdateByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where CustomerID = " + lbl_id.Text.Trim();
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
            dgv_master.Columns["CustomerID"].Visible = false;

            dgv_master.Columns["CustomerName"].HeaderText = "Customer Name";

            dgv_master.Columns["Address"].HeaderText = "Address";

            dgv_master.Columns["City"].HeaderText = "City";

            dgv_master.Columns["MobileNumber"].HeaderText = "Mobile No";

            dgv_master.Columns["PhoneNumber"].HeaderText = "Phone No";

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

        private void txt_mobile_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Search...")
            {
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("CustomerName LIKE '%{0}%' OR Address LIKE '%{0}%' OR City LIKE '%{0}%' OR MobileNumber LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%' OR EmailAddress LIKE '%{0}%'", txt_search.Text);
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
        private void txt_address_KeyDown(object sender, KeyEventArgs e)
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
    }
}
