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
    public partial class frmGBSSetting : Form
    {
        DataLayer _datalayer = new DataLayer();
        private bool deleteDisable = false;
        public frmGBSSetting()
        {
            InitializeComponent();
        }

        private void frmGBSSetting_Load(object sender, EventArgs e)
        {
            Reset();
            FillNameValue();
        }

        public void Reset()
        {
            btn_delete.Visible = false;
            BindGrid();
            FillNameValue();
            txt_Rate.Text = txt_name.Text = "";

            btn_save.Text = "SAVE";
            deleteDisable = false;
            ep1.Clear();
        }

        public void BindGrid()
        {
            DataSet _ds = new DataSet();
            string query = string.Empty;

            query = "SELECT um.TaxID, um.TaxDescription, um.TaxRate FROM Taxes AS um where um.IsDeleted = 0";

            _ds = _datalayer.bindDataSet(query);

            if (_ds.Tables.Count > 0)
            {
                dgv_master.DataSource = _ds.Tables[0];
            }
        }

        public void FillNameValue()
        {
            DataSet nameValueData = new DataSet();
            string query = string.Empty;

            query = "SELECT BSNameKey, BSNameValue FROM BSNameValues ";

            nameValueData = _datalayer.bindDataSet(query);

            if (nameValueData.Tables.Count > 0)
            {
                for (int i = 0; i < nameValueData.Tables[0].Rows.Count; i++)
                {
                    if (nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString() == "BillNumber")
                    {
                        txt_billno.Text = nameValueData.Tables[0].Rows[i]["BSNameValue"].ToString();
                        lblBillKey.Text = nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString();
                    }
                    else if (nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString() == "BillPrefix")
                    {
                        txt_Prefix.Text = nameValueData.Tables[0].Rows[i]["BSNameValue"].ToString();
                        lbl_Prefix.Text = nameValueData.Tables[0].Rows[i]["BSNameKey"].ToString();
                    }
                }
            }
        }

        public void FillData()
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_master.CurrentRow.Cells["TaxID"].Value.ToString();
                    txt_name.Text = dgv_master.CurrentRow.Cells["TaxDescription"].Value.ToString();
                    txt_Rate.Text = dgv_master.CurrentRow.Cells["TaxRate"].Value.ToString();

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
                    query = "update Taxes set IsDeleted = 1 where TaxID = " + lbl_id.Text.Trim();
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

        private void txt_Rate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["TaxID"].Visible = false;
            dgv_master.Columns["TaxDescription"].HeaderText = "Tax Type";
            dgv_master.Columns["TaxRate"].HeaderText = "TaxRate";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "SAVE" && dgv_master.RowCount == 3)
            {
                MessageBox.Show("Not allowed to create more than 3 tax...");
                return;
            }

            if (txt_name.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_name, "Please enter Tax type.");
                txt_name.Focus();
                return;
            }

            if (txt_Rate.Text.ToString() == "" || txt_Rate.Text.ToString() == "0")
            {
                ep1.Clear();
                ep1.SetError(txt_Rate, "Please enter Tax Rate.");
                txt_Rate.Focus();
                return;
            }

            string query = string.Empty;
            if (btn_save.Text == "SAVE")
                query = "insert into Taxes (TaxDescription, TaxRate) values ('" + txt_name.Text.Trim() + "'," + txt_Rate.Text.Trim() + ")";
            else
                query = "update Taxes set TaxDescription = '" + txt_name.Text.Trim() + "', TaxRate = " + txt_Rate.Text.Trim() + " where TaxID = " + lbl_id.Text.Trim();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_billno.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_billno, "Please enter bill no.");
                txt_billno.Focus();
                return;
            }

            string query = string.Empty;
            query = "UPDATE BSNameValues  SET BSNameValue = '" + txt_billno.Text.Trim() + "' WHERE BSNameKey = '" + lblBillKey.Text.Trim() + "'";
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

        private void txt_billno_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        

        private void btn_PrefixUpdate_Click(object sender, EventArgs e)
        {
            if (txt_Prefix.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_Prefix, "Please enter bill prefix.");
                txt_Prefix.Focus();
                return;
            }

            string query = string.Empty;
            query = "UPDATE BSNameValues  SET BSNameValue = '" + txt_Prefix.Text.Trim() + "' WHERE BSNameKey = '" + lbl_Prefix.Text.Trim() + "'";
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
}
