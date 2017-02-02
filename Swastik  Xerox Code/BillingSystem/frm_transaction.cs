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
    public partial class frm_transaction : Form
    {
        DataLayer _datalayer = new DataLayer();
        In_DataLayer _indatalayer = new In_DataLayer();
        public frm_transaction()
        {
            InitializeComponent();
        }

        private void frm_party_master_Load(object sender, EventArgs e)
        {
            Master_Reset();
            SetFormLocation();
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
            string query_1 = "select CustomerID, CustomerName from Customer order by CustomerName asc";
            DataTable dt_1 = new DataTable();
            dt_1 = _datalayer.bindDataTable(query_1);

            DataRow dr_1;
            dr_1 = dt_1.NewRow();
            dr_1.ItemArray = new object[] { 0, "Select Customer" };
            dt_1.Rows.InsertAt(dr_1, 0);

            cmb_customer.ValueMember = "CustomerID";
            cmb_customer.DisplayMember = "CustomerName";
            cmb_customer.DataSource = dt_1;

            lbl_total_amount.Text = lbl_total_credit.Text = lbl_total_debit.Text = lbl_total_pending.Text = "0";

            ep1.Clear();
        }

        public void Light_Reset()
        {
            cmb_customer.SelectedIndex = 0;
            ep1.Clear();
        }

        public void BindGrid()
        {
            Decimal invoice = 0, credit = 0, debit = 0, pending = 0;
            DataTable _dt_invoice_amount = new DataTable();
            string query_invoice_amount = "SELECT InvoiceAmount from Invoice where CustomerID = " + cmb_customer.SelectedValue.ToString();
            _dt_invoice_amount = _datalayer.bindDataTable(query_invoice_amount);
            if (_dt_invoice_amount.Rows.Count > 0)
            {
                invoice = _dt_invoice_amount.AsEnumerable().Sum(row => row.Field<Decimal>("InvoiceAmount"));
            }

            DataTable _dt = new DataTable();
            string query = "SELECT i.InvoiceId, c.CustomerID, t.TransactionId, i.InvoiceNo, i.InvoiceDate, i.InvoiceAmount, t.CreaditAmount, t.DebitAmount, t.TransactionDate from Customer as c inner join Invoice as i on c.CustomerID = i.CustomerID inner join Transactions as t on c.CustomerID = t.CustomerID and i.InvoiceId = t.InvoiceId where c.CustomerID = " + cmb_customer.SelectedValue.ToString();
            _dt = _datalayer.bindDataTable(query);
            if (_dt.Rows.Count > 0)
            {
                dgv_master.DataSource = _dt;

                credit = _dt.AsEnumerable().Sum(row => row.Field<Decimal>("CreaditAmount"));
                debit = _dt.AsEnumerable().Sum(row => row.Field<Decimal>("DebitAmount"));
            }
            else
                dgv_master.DataSource = null;

            pending = invoice - credit;

            lbl_total_amount.Text = invoice.ToString();
            lbl_total_credit.Text = credit.ToString();
            lbl_total_debit.Text = debit.ToString();
            lbl_total_pending.Text = pending.ToString();
        }

        public void DeleteRecord()
        {
            try
            {
                string value = "";
                if (Box.InputBox("Varification", "Password:", ref value) == DialogResult.OK)
                {
                    DataTable _dtRightsPassword = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'RightsPassword')");
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
                _datalayer.ErrorLog("Fill Data", ex.Message.ToString());
            }
        }

        private void dgv_master_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_master.SelectedRows.Count > 0)
                {
                    string companyName = "";
                    string companyAddress1 = "";
                    string companyAddress2 = "";
                    string companyPhone = "";
                    string companyEmail = "";

                    DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM [Default] WHERE (fld_default_name = 'CompanyInfo')");
                    string text = _dtDetails.Rows[0]["fld_value"].ToString();
                    string[] Descs = text.Split('#');
                    companyName = Descs[0].ToString();
                    companyAddress1 = Descs[1].ToString();
                    companyAddress2 = Descs[2].ToString();
                    companyPhone = Descs[3].ToString();
                    companyEmail = Descs[4].ToString();


                    string query = "select c.CustomerName, i.InvoiceDate as Date, i.InvoiceNo as InvoiceNumber, p.ProductName as Description, id.Amount as LineAmount, c.Address as CustomerAddress1, c.City as CustomerCity, c.PhoneNumber  as CustomerPhone, i.InvoiceAmount as TotalAmount, '' as AmountinWord, '" + companyName + "' as MasterCompanyName, '" + companyAddress1 + "' as MasterCompanyAddress1, '" + companyAddress2 + "' as MasterCompanyAddress2, '" + companyPhone + "' as MasterCompanyPhone, '" + companyEmail + "' as MasterCompanyEmail from Customer as c inner join Invoice as i on c.CustomerID = i.CustomerID inner join InvoiceDetails as id on i.InvoiceId = id.InvoiceId inner join Product as p on id.ProductID = p.ProductID where i.InvoiceId = " + dgv_master.CurrentRow.Cells["InvoiceId"].Value.ToString();
                    DataSet _dataset = new DataSet();
                    _dataset = _datalayer.bindDataSet(query);

                    frmView _frmfrmView = new frmView(_dataset);
                    _frmfrmView.Show();
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Fill Data", ex.Message.ToString());
            }
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
                    this.contextMenuStrip2.Show(dgv_master, relativeMousePosition);
                }
            }
        }

        private void dgv_master_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_master.Columns["InvoiceId"].Visible = false;
            dgv_master.Columns["CustomerID"].Visible = false;
            dgv_master.Columns["TransactionId"].Visible = false;
            dgv_master.Columns["InvoiceNo"].HeaderText = "Invoice Number";
            dgv_master.Columns["InvoiceDate"].HeaderText = "Invoice Date";
            dgv_master.Columns["InvoiceDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_master.Columns["InvoiceAmount"].HeaderText = "Invoice Amount";
            dgv_master.Columns["CreaditAmount"].HeaderText = "Creadit Amount";
            dgv_master.Columns["DebitAmount"].HeaderText = "Debit Amount";
            dgv_master.Columns["TransactionDate"].HeaderText = "Transaction Date";
            dgv_master.Columns["TransactionDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

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
                    (dgv_master.DataSource as DataTable).DefaultView.RowFilter = string.Format("InvoiceNo LIKE '%{0}%' OR convert(InvoiceDate, 'System.String') LIKE '%{0}%' OR convert(InvoiceAmount, 'System.String') LIKE '%{0}%' OR convert(CreaditAmount, 'System.String') LIKE '%{0}%' OR convert(DebitAmount, 'System.String') LIKE '%{0}%' OR convert(TransactionDate, 'System.String') LIKE '%{0}%'", txt_search.Text);
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

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_customer.SelectedValue.ToString() == "0")
            {
                dgv_master.DataSource = null;
            }
            else
            {
                BindGrid();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string invoice_id = dgv_master.CurrentRow.Cells["InvoiceId"].Value.ToString();
                string customer_id = dgv_master.CurrentRow.Cells["CustomerID"].Value.ToString();
                string value = "";
                if (Box.PaymentBox("Payment", "Credit Amount :", ref value) == DialogResult.OK)
                {
                    string message = string.Empty;
                    if (value.ToString() != "")
                    {
                        Int32 payment = (Int32)Math.Floor(Convert.ToDecimal(value.ToString()));
                        if (payment != 0)
                        {
                            string query = "insert into Transactions (CustomerID, InvoiceId, CreaditAmount, DebitAmount, TransactionDate) values (" + customer_id + ", " + invoice_id + ", " + value.ToString() + ", 0, GETDATE())";
                            message = _datalayer.Opration(query);
                        }
                    }
                    if (message == "Success")
                    {
                        MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Master_Reset();
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Fill Data in Investment form", ex.Message.ToString());
            }
        }

        private void cmb_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
