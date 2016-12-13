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
            btn_save.Text = "Save";
            BindGrid();
            txt_CustomerID.Text = txt_name.Text = txt_DocumentNumber.Text =  txt_address.Text = txt_city.Text = cmbDocumentType.Text = txt_phone_no.Text = txt_FileName.Text = txt_CustomerID.Text = "";
            cmbDocumentType.SelectedIndex = 1;
            UploadPicBox.ImageLocation = "";
            deleteDisable = false;
            ep1.Clear();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.CustomerID, um.CustomerName,um.DocumentType, um.DocumentNumber, um.PhoneNumber,um.City, um.Address, um.CustomerCode,DocumentPath FROM Customer AS um where um.IsDeleted = 0";

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
                    txt_CustomerID.Text = dgv_master.CurrentRow.Cells["CustomerCode"].Value.ToString();
                    txt_name.Text = dgv_master.CurrentRow.Cells["CustomerName"].Value.ToString();
                    txt_DocumentNumber.Text = dgv_master.CurrentRow.Cells["DocumentNumber"].Value.ToString();
                    txt_address.Text = dgv_master.CurrentRow.Cells["Address"].Value.ToString();
                    txt_city.Text = dgv_master.CurrentRow.Cells["City"].Value.ToString();
                    cmbDocumentType.Text = dgv_master.CurrentRow.Cells["DocumentType"].Value.ToString();
                    txt_phone_no.Text = dgv_master.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                    UploadPicBox.ImageLocation = "C:\\SuhradamSoft\\BillingSystemCafe\\" + dgv_master.CurrentRow.Cells["DocumentPath"].Value.ToString();
                    txt_CustomerID.Focus();
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
            //if (cmbDocumentType.SelectedIndex == 0)
            //{
            //    ep1.Clear();
            //    ep1.SetError(cmbDocumentType, "Please select document type.");
            //    cmbDocumentType.Focus();
            //    return;
            //}
            //if (txt_DocumentNumber.Text.ToString() == "")
            //{
            //    ep1.Clear();
            //    ep1.SetError(txt_DocumentNumber, "Please enter document number.");
            //    txt_DocumentNumber.Focus();
            //    return;
            //}

            //if (txt_FileName.Text.ToString() == "")
            //{
            //    ep1.Clear();
            //    ep1.SetError(txt_FileName, "Please select document");
            //    txt_FileName.Focus();
            //    return;
            //}

            

            DataSet customerData = new DataSet();
            string query = string.Empty;
            string message = string.Empty;
            if (btn_save.Text == "Save")
            {
                query = "SELECT CustomerID FROM Customer where CustomerName = '" + txt_name.Text.Trim() + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count > 0)
                {
                    Reset();
                    MessageBox.Show("Customer name already exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                query = "insert into Customer (CustomerCode, CustomerName,DocumentNumber, Address, City, DocumentType, PhoneNumber, DocumentPath, CreatedByID) values ('" + txt_CustomerID.Text.Trim() + "','" + txt_name.Text.Trim() + "','" + txt_DocumentNumber.Text.Trim() + "','" + txt_address.Text.Trim() + "', '" + txt_city.Text.ToString() + "','" + cmbDocumentType.Text.Trim() + "','" + txt_phone_no.Text.Trim() + "','" + txt_FileName.Text.Trim() + "'," + DataAccess.gbl_longUserID + ")";
                message = _datalayer.Opration(query);
            }
            else
            {
                query = "SELECT CustomerID FROM Customer where CustomerName = '" + txt_name.Text.Trim() + "' and CustomerID <> " + lbl_id.Text.Trim();
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count > 0)
                {
                    Reset();
                    MessageBox.Show("Customer name already exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    
                }

                query = "update Customer set CustomerCode = '" + txt_CustomerID.Text.Trim() + "', CustomerName = '" + txt_name.Text.Trim() + "', DocumentNumber = '" + txt_DocumentNumber.Text.Trim() + "', Address = '" + txt_address.Text.Trim() + "', City = '" + txt_city.Text.ToString() + "', DocumentType = '" + cmbDocumentType.Text.Trim() + "', PhoneNumber = '" + txt_phone_no.Text.Trim() + "', DocumentPath = '" + txt_FileName.Text.Trim() + "', UpdateByID = " + DataAccess.gbl_longUserID + ", UpdatedDate = GETDATE() where CustomerID = " + lbl_id.Text.Trim();
                message = _datalayer.Opration(query);
            }

            if (message == "Success")
            {
                query = "SELECT CustomerID FROM Customer where CustomerName = '" + txt_name.Text.Trim() + "'";
                customerData = _datalayer.bindDataSet(query);
                if (customerData.Tables[0].Rows.Count > 0)
                {
                    string documentPath= customerData.Tables[0].Rows[0]["CustomerID"].ToString()  + Path.GetExtension(txt_FileName.Text);
                    if (txt_FileName.Text.ToString() != "")
                    {
                        File.Copy(txt_FileName.Text, "C:\\SuhradamSoft\\BillingSystemCafe\\" + documentPath);
                    }

                    query = "update Customer set  DocumentPath = '" + documentPath + "' where CustomerID = " + customerData.Tables[0].Rows[0]["CustomerID"].ToString();

                    message = _datalayer.Opration(query);
                }

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
            dgv_master.Columns["DocumentPath"].Visible = false;

            dgv_master.Columns["CustomerName"].HeaderText = "Customer Name";
            dgv_master.Columns["DocumentNumber"].HeaderText = "Document Number";

            dgv_master.Columns["Address"].HeaderText = "Address";

            dgv_master.Columns["City"].HeaderText = "City";

            dgv_master.Columns["CustomerCode"].HeaderText = "Customer Code";

            dgv_master.Columns["DocumentType"].HeaderText = "Document Type";

            dgv_master.Columns["PhoneNumber"].HeaderText = "Phone No";

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

        private void cmbDocumentType_KeyPress(object sender, KeyPressEventArgs e)
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
                (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("DocumentNumber LIKE '%{0}%' OR CustomerName LIKE '%{0}%' OR Address LIKE '%{0}%' OR City LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%'", txt_search.Text);
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

        private void cmbDocumentType_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_FileName_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            // clear the folder path
            txt_FileName.Text = string.Empty;

            // Show the FolderBrowserDialog.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_FileName.Text = openFileDialog1.FileName;
            }
            UploadPicBox.ImageLocation = txt_FileName.Text;


            //openFileDialog1.ShowDialog();

            //txt_FileName.Text = openFileDialog1.FileName;

            //int count = 0;

            //string[] FName;

            //foreach (string s in openFileDialog1.FileNames)
            //{

            //    FName = s.Split('\\');

            //    File.Copy(s, "C:\\file\\" + FName[FName.Length - 1]);

            //    count++;

            //}

            //MessageBox.Show(Convert.ToString(count) + " File(s) copied");
        }
    }
}
