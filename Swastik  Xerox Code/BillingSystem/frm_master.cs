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
    public partial class frm_master : Form
    {
        DataLayer _datalayer = new DataLayer();
        public frm_master()
        {
            InitializeComponent();
        }

        private void frm_job_work_Load(object sender, EventArgs e)
        {
            SetFormLocation();

            DataTable _dtInvoiceNumber = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'InvoiceNumber')");
            if (_dtInvoiceNumber.Rows.Count > 0)
            {
                txt_invoice.Text = _dtInvoiceNumber.Rows[0]["fld_value"].ToString();
            }

            DataTable _dtRightsPassword = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'RightsPassword')");
            if (_dtRightsPassword.Rows.Count > 0)
            {
                txt_password.Text = _dtRightsPassword.Rows[0]["fld_value"].ToString();
            }

            DataTable _dtBackUp = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'BackUp')");
            if (_dtBackUp.Rows.Count > 0)
            {
                ckb_backup.Checked = Convert.ToBoolean(_dtBackUp.Rows[0]["fld_value"].ToString());

                if (ckb_backup.Checked)
                    tlp_backup.Enabled = true;
                else
                    tlp_backup.Enabled = false;
            }

            DataTable _dtBackUpMain = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'FolderMain')");
            if (_dtBackUpMain.Rows.Count > 0)
            {
                txt_bu_main.Text = _dtBackUpMain.Rows[0]["fld_value"].ToString();
            }

            DataTable _dtBackUpSub = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'FolderSub')");
            if (_dtBackUpSub.Rows.Count > 0)
            {
                txt_bu_sub.Text = _dtBackUpSub.Rows[0]["fld_value"].ToString();
            }

            DataTable _dtDuration = new DataTable();
            _dtDuration.Columns.Add("duration");
            DataRow _drDuration;
            _drDuration = _dtDuration.NewRow();
            _drDuration.ItemArray = new object[] { "Minutes" };
            _dtDuration.Rows.InsertAt(_drDuration, 0);
            _drDuration = _dtDuration.NewRow();
            _drDuration.ItemArray = new object[] { "Hours" };
            _dtDuration.Rows.InsertAt(_drDuration, 1);
            _drDuration = _dtDuration.NewRow();
            _drDuration.ItemArray = new object[] { "Days" };
            _dtDuration.Rows.InsertAt(_drDuration, 2);
            _drDuration = _dtDuration.NewRow();
            _drDuration.ItemArray = new object[] { "Months" };
            _dtDuration.Rows.InsertAt(_drDuration, 3);
            cmb_bu_dur.ValueMember = "duration";
            cmb_bu_dur.DisplayMember = "duration";
            cmb_bu_dur.DataSource = _dtDuration;
            DataTable _dtBackUpDuration = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'BackUpDuration')");
            if (_dtBackUpDuration.Rows.Count > 0)
            {
                cmb_bu_dur.Text = _dtBackUpDuration.Rows[0]["fld_value"].ToString();
                lbl_backup_time.Text = "Timing 1 = 1" + cmb_bu_dur.Text.ToString();
            }
            DataTable _dtBackUpTime = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'BackUpTime')");
            if (_dtBackUpTime.Rows.Count > 0)
            {
                int minutes = 1;
                if (cmb_bu_dur.Text.ToString() == "Minutes")
                {
                    minutes = Convert.ToInt16(_dtBackUpTime.Rows[0]["fld_value"].ToString());
                }
                else if (cmb_bu_dur.Text.ToString() == "Hours")
                {
                    minutes = Convert.ToInt16(_dtBackUpTime.Rows[0]["fld_value"].ToString()) / 60;
                }
                else if (cmb_bu_dur.Text.ToString() == "Days")
                {
                    minutes = (Convert.ToInt32(_dtBackUpTime.Rows[0]["fld_value"].ToString()) / 24) / 60;
                }
                else if (cmb_bu_dur.Text.ToString() == "Months")
                {
                    minutes = Convert.ToInt32(((Convert.ToInt64(_dtBackUpTime.Rows[0]["fld_value"].ToString()) / 30) / 24) / 60);
                }
                txt_bu_time.Text = minutes.ToString();
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

        private void txt_tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_bill_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bu_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }

            int val = 0;
            bool res = Int32.TryParse(txt_bu_time.Text, out val);
            if (res == true && val > -1 && val < 101)
            {
                // add record
            }
            else
            {
                MessageBox.Show("Please input 0 to 100 only.");
                return;
            }
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            if (txt_invoice.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_invoice, "Please enter Invoice Number.");
                txt_invoice.Focus();
                return;
            }
            string query = "update [Default] set fld_value = '" + txt_invoice.Text.Trim().ToString() + "' where (fld_default_name = 'InvoiceNumber')";
            string message = _datalayer.Opration(query);
            if (message == "Success")
            {
                MessageBox.Show("Invoice Number Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_password, "Please enter Rights Password");
                txt_password.Focus();
                return;
            }
            string query = "update [Default] set fld_value = '" + txt_password.Text.Trim().ToString() + "' where (fld_default_name = 'RightsPassword')";
            string message = _datalayer.Opration(query);
            if (message == "Success")
            {
                MessageBox.Show("Rights Password Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if (txt_bu_main.Text.Trim().ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_bu_main, "Please enter Backup Main Folder Name.");
                txt_bu_main.Focus();
                return;
            }
            if (txt_bu_sub.Text.Trim().ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_bu_sub, "Please enter Backup Sub Folder Name.");
                txt_bu_sub.Focus();
                return;
            }
            if (txt_bu_time.Text.Trim().ToString() == "")
            {
                ep1.Clear();
                ep1.SetError(txt_bu_time, "Please enter Backup Timing.");
                txt_bu_time.Focus();
                return;
            }

            Int64 minutes = 1;
            if (cmb_bu_dur.Text.ToString() == "Minutes")
            {
                minutes = Convert.ToInt64(txt_bu_time.Text.Trim().ToString());
            }
            else if (cmb_bu_dur.Text.ToString() == "Hours")
            {
                minutes = Convert.ToInt64(txt_bu_time.Text.Trim().ToString()) * 60;
            }
            else if (cmb_bu_dur.Text.ToString() == "Days")
            {
                minutes = (Convert.ToInt64(txt_bu_time.Text.Trim().ToString()) * 24) * 60;
            }
            else if (cmb_bu_dur.Text.ToString() == "Months")
            {
                minutes = ((Convert.ToInt64(txt_bu_time.Text.Trim().ToString()) * 30) * 24) * 60;
            }

            string message = _datalayer.Opration("update [Default] set fld_value = '" + ckb_backup.Checked.ToString() + "' where (fld_default_name = 'BackUp')");
            message = _datalayer.Opration("update [Default] set fld_value = '" + txt_bu_main.Text.Trim().ToString() + "' where (fld_default_name = 'FolderMain')");
            message = _datalayer.Opration("update [Default] set fld_value = '" + txt_bu_sub.Text.Trim().ToString() + "' where (fld_default_name = 'FolderSub')");
            message = _datalayer.Opration("update [Default] set fld_value = '" + cmb_bu_dur.Text.Trim().ToString() + "' where (fld_default_name = 'BackUpDuration')");
            message = _datalayer.Opration("update [Default] set fld_value = '" + minutes.ToString() + "' where (fld_default_name = 'BackUpTime')");
            if (message == "Success")
            {
                MessageBox.Show("Bales Rate Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckb_backup_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_backup.Checked)
                tlp_backup.Enabled = true;
            else
                tlp_backup.Enabled = false;
        }

        private void cmb_bu_dur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_backup_time.Text = "Timing 1 = 1" + cmb_bu_dur.Text.ToString();
            if (cmb_bu_dur.Text.ToString() == "Months")
            {
                txt_bu_time.Text = "1";
                txt_bu_time.Enabled = false;
            }
            else
            {
                txt_bu_time.Enabled = true;
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
            this.Close();
        }

        private void txt_invoice_KeyDown(object sender, KeyEventArgs e)
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

        private void ckb_backup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_bu_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_bu_sub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cmb_bu_dur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_bu_time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
