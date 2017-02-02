using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Security.Cryptography;

namespace BillingSystem
{
    public partial class frmMain : Form
    {
        DataLayer _datalayer = new DataLayer();
        string companyName = "";
        string companyAddress1 = "";
        string companyAddress2 = "";
        string companyPhone = "";
        string companyEmail = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuInvoice_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frmInvoice>().Any())
            {
                CloseOpenForm.HideAllForms();
                frmInvoice _frmInvoice = new frmInvoice();
                _frmInvoice.MdiParent = this;
                _frmInvoice.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_master _frmSettinge = new frm_master();
                _frmSettinge.MdiParent = this;
                _frmSettinge.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Reset();
            IsMdiContainer = true;
            StartBackUp();

            string guid = Guid.NewGuid().ToString();
            DataAccess.gbl_height = Screen.PrimaryScreen.WorkingArea.Height;
            DataAccess.gbl_width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Height = DataAccess.gbl_height;
            this.Width = DataAccess.gbl_width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            tlp_footer.Width = DataAccess.gbl_width;

            int main_height = tlp_main.Height + tlp_footer.Height + 8;
            int main_width = Screen.PrimaryScreen.WorkingArea.Width;

            DataAccess.gbl_client_height = DataAccess.gbl_height - main_height;
            DataAccess.gbl_client_width = DataAccess.gbl_width - 6;

            DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default WHERE (fld_default_name = 'CompanyInfo')");
            string text = _dtDetails.Rows[0]["fld_value"].ToString();
            string[] Descs = text.Split('#');
            companyName = Descs[0].ToString();
            companyAddress1 = Descs[1].ToString();
            companyAddress2 = Descs[2].ToString();
            companyPhone = Descs[3].ToString();
            companyEmail = Descs[4].ToString();
            labelCompany.Text = companyName;
            //lblCompanyPhone.Text = "PH : " + companyPhone;
            this.Text = companyName + " Billing System";

            //frm_home formtransaction = new frm_home();
            //formtransaction.MdiParent = this;
            //formtransaction.Show();

            BindGrid();
        }

        public void BindGrid()
        {
            Decimal total_expense = 0, total_income = 0, total = 0;
            dgv_expense.DataSource = null;
            dgv_income.DataSource = null;
            DataTable _expenseTable = new DataTable();
            string expenseQuery = "SELECT fld_expense_id, fld_expense, fld_amount, fld_date FROM tbl_expense where (CONVERT(NVARCHAR(10), fld_date, 111) BETWEEN '" + _datalayer.OnlyDateFormat(dtp_from_date.Text.ToString()) + "' AND '" + _datalayer.OnlyDateFormat(dtp_to_date.Text.ToString()) + "') Order By fld_expense asc";
            _expenseTable = _datalayer.bindDataTable(expenseQuery);
            if (_expenseTable.Rows.Count > 0)
            {
                dgv_expense.DataSource = _expenseTable;
                total_expense = _expenseTable.AsEnumerable().Sum(row => row.Field<Decimal>("fld_amount"));
            }

            DataTable _incomeTable = new DataTable();
            string incomeQuery = "SELECT i.fld_invoice_id, i.fld_customer_id, c.fld_customer_name, i.fld_invoice_no, i.fld_invoice_date, CONVERT(decimal(14,2), ROUND(CONVERT(float, CASE WHEN i.fld_tax <= 0 THEN i.fld_invoice_amount ELSE ((i.fld_invoice_amount * i.fld_tax) / 100) + i.fld_invoice_amount END), 2)) AS fld_invoice_amount FROM tbl_invoice AS i INNER JOIN tbl_customer AS c ON i.fld_customer_id = c.fld_customer_id WHERE (CONVERT(NVARCHAR(10), i.fld_invoice_date, 111) BETWEEN '" + _datalayer.OnlyDateFormat(dtp_from_date.Text.ToString()) + "' AND '" + _datalayer.OnlyDateFormat(dtp_to_date.Text.ToString()) + "') ORDER BY c.fld_customer_name";
            _incomeTable = _datalayer.bindDataTable(incomeQuery);
            if (_incomeTable.Rows.Count > 0)
            {
                dgv_income.DataSource = _incomeTable;
                total_income = _incomeTable.AsEnumerable().Sum(row => row.Field<Decimal>("fld_invoice_amount"));
            }
            total = total_income - total_expense;

            if (total >= 0)
                lbl_total_header.Text = "Total Profit :";
            else
                lbl_total_header.Text = "Total Loss :";

            lbl_total_income.Text = total_income.ToString();
            lbl_total_expense.Text = total_expense.ToString();
            lbl_total.Text = total.ToString();
        }

        public void StartBackUp()
        {
            string sourceFile = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string check_path = System.IO.Path.Combine(sourceFile, "Setting.dll");
            Int64 backup_time = 0;
            if (File.Exists(check_path))
            {
                DataTable _dtBackUp = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default where (fld_default_name = 'BackUp')");
                if (_dtBackUp.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(_dtBackUp.Rows[0]["fld_value"].ToString()))
                    {
                        DataTable _dtBackUpTime = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default where (fld_default_name = 'BackUpTime')");
                        if (_dtBackUpTime.Rows.Count > 0)
                        {
                            backup_time = Convert.ToInt64(_dtBackUpTime.Rows[0]["fld_value"].ToString());
                        }
                    }
                }
            }

            if (backup_time != 0)
            {
                var timer = new System.Threading.Timer(c => ThreadProcess(), null, TimeSpan.Zero, TimeSpan.FromMinutes(backup_time));
            }
        }

        static void ThreadProcess()
        {
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    BackUp();
                }
            ));
            backgroundThread.Start();
        }

        static void BackUp()
        {
            try
            {
                string sourceFile = System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Setting.dll");

                string[] drives = System.IO.Directory.GetLogicalDrives();
                foreach (string str in drives)
                {
                    DataLayer _datalayer = new DataLayer();
                    DataTable _dtBackUpMain = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default where (fld_default_name = 'FolderMain')");
                    string path = str + _dtBackUpMain.Rows[0]["fld_value"].ToString();
                    if (!Directory.Exists(path))
                    {
                        if (str == "D:\\" || str == "E:\\")
                            Directory.CreateDirectory(path);
                    }

                    if (Directory.Exists(path))
                    {
                        DataTable _dtBackUpSub = _datalayer.bindDataTable("SELECT fld_value FROM tbl_default where (fld_default_name = 'FolderSub')");
                        string Inner_Path = path + @"\" + _dtBackUpSub.Rows[0]["fld_value"].ToString();
                        if (!Directory.Exists(Inner_Path))
                        {
                            if (str == "D:\\" || str == "E:\\")
                                Directory.CreateDirectory(Inner_Path);
                        }

                        if (Directory.Exists(Inner_Path))
                        {
                            string DateDirectory = Inner_Path + @"\" + DateTime.Now.ToString("dd-MM-yyyy");
                            if (!Directory.Exists(DateDirectory))
                            {
                                Directory.CreateDirectory(DateDirectory);
                            }

                            if (Directory.Exists(DateDirectory))
                            {
                                string destinationFile = DateDirectory + @"\" + DateTime.Now.ToString("HH-mm-ss");
                                Encrypt(destinationFile, sourceFile);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog("BackUp", ex.Message.ToString());
            }
        }

        //Encrypt Database
        static void Encrypt(string inputFilePath, string outputfilePath)
        {
            try
            {
                string EncryptionKey = "QWP9OASLK0ZXM0N4TGB99DF7EI6KCG";
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (FileStream fsOutput = new FileStream(inputFilePath, FileMode.Create))
                    {
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsInput = new FileStream(outputfilePath, FileMode.Open))
                            {
                                int data;
                                while ((data = fsInput.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog("Encrypt", ex.Message.ToString());
            }
        }

        static void ErrorLog(string reson, string errorMessage)
        {
            try
            {
                string path = @"Error_Thread.txt";
                if (!File.Exists(path))
                {
                    FileStream fs_creat = new FileStream(path, FileMode.Create);
                    fs_creat.Close();
                }

                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter str = new StreamWriter(fs);
                str.BaseStream.Seek(0, SeekOrigin.End);
                str.Write("Reson : " + reson + Environment.NewLine);
                str.WriteLine("Error Message : " + errorMessage);
                str.WriteLine("Date Time : " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                str.WriteLine("----------------------------------------------------------------");
                str.Flush();
                str.Close();
                fs.Close();
            }
            catch (Exception)
            {
                //con.Close();
            }
        }

        private void MenuCustomer_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_customer_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_customer_master formInvoice = new frm_customer_master();
                formInvoice.MdiParent = this;
                formInvoice.Show();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_Product_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_Product_master formInvoice = new frm_Product_master();
                formInvoice.MdiParent = this;
                formInvoice.Show();
            }
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_point>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_point formtransaction = new frm_point();
                formtransaction.MdiParent = this;
                formtransaction.Show();
            }
        }

        public static void SetFolderPermission(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();
            var currentUserIdentity = WindowsIdentity.GetCurrent();
            var fileSystemRule = new FileSystemAccessRule(currentUserIdentity.Name,
                                                          FileSystemRights.Read,
                                                          InheritanceFlags.ObjectInherit |
                                                          InheritanceFlags.ContainerInherit,
                                                          PropagationFlags.None,
                                                          AccessControlType.Allow);

            directorySecurity.AddAccessRule(fileSystemRule);

        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frm_employee_master>().Any())
            {
                CloseOpenForm.HideAllForms();
                frm_employee_master formtransaction = new frm_employee_master();
                formtransaction.MdiParent = this;
                formtransaction.Show();
            }
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        public void Reset()
        {
            dtp_from_date.Format = DateTimePickerFormat.Custom;
            dtp_from_date.CustomFormat = "dd/MM/yyyy";
            dtp_from_date.MaxDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);

            dtp_to_date.Format = DateTimePickerFormat.Custom;
            dtp_to_date.CustomFormat = "dd/MM/yyyy";
            dtp_to_date.MaxDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);

            txt_expense.Text = txt_amount.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_expense.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_expense, "Please enter Expense.");
                    txt_expense.Focus();
                    return;
                }

                if (txt_amount.Text.ToString() == "")
                {
                    ep1.Clear();
                    ep1.SetError(txt_amount, "Please enter Amount.");
                    txt_amount.Focus();
                    return;
                }

                string query = string.Empty;
                string message = string.Empty;
                if (btn_save.Text == "SAVE")
                {
                    query = "insert into tbl_expense (fld_expense, fld_amount, fld_date) values ('" + txt_expense.Text.Trim() + "', " + txt_amount.Text.Trim() + ", '" + _datalayer.DateFormat(dtp_date.Text.ToString()) + "')";
                    message = _datalayer.Opration(query);
                }
                else
                {
                    query = "update tbl_expense set fld_expense = '" + txt_expense.Text.Trim() + "', fld_amount = " + txt_amount.Text.Trim() + ", fld_date = '" + _datalayer.DateFormat(dtp_date.Text.ToString()) + "' where fld_expense_id = " + lbl_id.Text.Trim();
                    message = _datalayer.Opration(query);
                }

                if (message == "Success")
                {
                    MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Sorry!!! there are some issue to insert this record, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_expense.Focus();
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Customer save/update record", ex.Message.ToString());
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void dgv_expense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_id.Text = dgv_expense.CurrentRow.Cells["fld_expense_id"].Value.ToString();
            DeleteRecord();
        }

        public void FillData()
        {
            try
            {
                if (dgv_expense.SelectedRows.Count > 0)
                {
                    lbl_id.Text = dgv_expense.CurrentRow.Cells["fld_expense_id"].Value.ToString();
                    txt_expense.Text = dgv_expense.CurrentRow.Cells["fld_expense"].Value.ToString();
                    txt_amount.Text = dgv_expense.CurrentRow.Cells["fld_amount"].Value.ToString();
                    DateTime bill_date = new DateTime();
                    bill_date = Convert.ToDateTime(dgv_expense.CurrentRow.Cells["fld_date"].Value.ToString());
                    dtp_date.Text = bill_date.Date.ToString("dd/MM/yyyy");
                    txt_expense.Focus();
                    btn_save.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                _datalayer.ErrorLog("Expense Fill Data", ex.Message.ToString());
            }
        }

        public void DeleteRecord()
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Empty;
                    query = "delete tbl_expense where fld_expense_id = " + lbl_id.Text.Trim();
                    string message = _datalayer.Opration(query);
                    if (message == "Success")
                    {
                        MessageBox.Show("Data Delete Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
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
                _datalayer.ErrorLog("Expense Delete Record", ex.Message.ToString());
            }
        }

        private void dgv_expense_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Here you can do whatever you want with the cell
                    this.dgv_expense.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dgv_expense.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(dgv_expense, relativeMousePosition);
                }
            }
        }

        private void dgv_expense_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_expense.Columns["fld_expense_id"].Visible = false;
            dgv_expense.Columns["fld_expense"].HeaderText = "Expense";
            dgv_expense.Columns["fld_amount"].HeaderText = "Amount";
            dgv_expense.Columns["fld_date"].HeaderText = "Date";
            dgv_expense.Columns["fld_date"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewRow row in dgv_expense.Rows)
            {
                row.Height = 24;
            }

            for (int i = 0; i < dgv_expense.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dgv_expense.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(247, 251, 252);
                }
            }

            dgv_expense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_expense.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            dgv_expense.EnableHeadersVisualStyles = false;
            dgv_expense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_expense.ColumnHeadersHeight = 34;
            dgv_expense.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dgv_expense.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dgv_income_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_income.Columns["fld_invoice_id"].Visible = false;
            dgv_income.Columns["fld_customer_id"].Visible = false;
            dgv_income.Columns["fld_customer_name"].HeaderText = "Customer Name";
            dgv_income.Columns["fld_invoice_no"].HeaderText = "Invoice Number";
            dgv_income.Columns["fld_invoice_date"].HeaderText = "Invoice Date";
            dgv_income.Columns["fld_invoice_date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_income.Columns["fld_invoice_amount"].HeaderText = "Amount";

            foreach (DataGridViewRow row in dgv_income.Rows)
            {
                row.Height = 24;
            }

            for (int i = 0; i < dgv_income.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dgv_income.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(247, 251, 252);
                }
            }

            dgv_income.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_income.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            dgv_income.EnableHeadersVisualStyles = false;
            dgv_income.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_income.ColumnHeadersHeight = 34;
            dgv_income.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dgv_income.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void txt_i_search_Enter(object sender, EventArgs e)
        {
            if (txt_i_search.Text == "Search...")
            {
                txt_i_search.Text = "";
                txt_i_search.ForeColor = Color.Black;
            }
        }

        private void txt_i_search_Leave(object sender, EventArgs e)
        {
            if (txt_i_search.Text == "")
            {
                txt_i_search.Text = "Search...";
                txt_i_search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txt_i_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_i_search.Text != "Search...")
            {
                if (dgv_income.RowCount > 0)
                {
                    DataView datavw = new DataView();
                    datavw = (dgv_income.DataSource as DataTable).DefaultView;
                    datavw.RowFilter = string.Format("fld_customer_name LIKE '%{0}%' OR fld_invoice_no LIKE '%{0}%' OR convert(fld_invoice_date, 'System.String') LIKE '%{0}%' OR convert(fld_invoice_amount, 'System.String') LIKE '%{0}%'", txt_i_search.Text);
                    lbl_total_count.Text = "Total Count : " + datavw.Count.ToString();

                    (dgv_income.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_customer_name LIKE '%{0}%' OR fld_invoice_no LIKE '%{0}%' OR convert(fld_invoice_date, 'System.String') LIKE '%{0}%' OR convert(fld_invoice_amount, 'System.String') LIKE '%{0}%'", txt_i_search.Text);
                    dgv_income.Refresh();

                    Decimal total_income = 0;
                    DataTable _incomeTable = new DataTable();
                    if (datavw.Count > 0)
                    {
                        _incomeTable = datavw.ToTable();
                        total_income = _incomeTable.AsEnumerable().Sum(row => row.Field<Decimal>("fld_invoice_amount"));
                    }
                    lbl_total_income.Text = total_income.ToString();
                }
            }
            else
            {
                lbl_total_count.Text = "";
            }
        }

        private void txt_e_search_Enter(object sender, EventArgs e)
        {
            if (txt_e_search.Text == "Search...")
            {
                txt_e_search.Text = "";
                txt_e_search.ForeColor = Color.Black;
            }
        }

        private void txt_e_search_Leave(object sender, EventArgs e)
        {
            if (txt_e_search.Text == "")
            {
                txt_e_search.Text = "Search...";
                txt_e_search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txt_e_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_e_search.Text != "Search...")
            {
                if (dgv_expense.RowCount > 0)
                {
                    (dgv_expense.DataSource as DataTable).DefaultView.RowFilter = string.Format("fld_expense LIKE '%{0}%' OR convert(fld_date, 'System.String') LIKE '%{0}%' OR convert(fld_amount, 'System.String') LIKE '%{0}%'", txt_e_search.Text);
                    dgv_expense.Refresh();
                }
            }
        }

        private void dgv_income_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_income.SelectedRows.Count > 0)
            {
                string companyName = "";
                string companyAddress1 = "";
                string companyAddress2 = "";
                string companyPhone = "";
                string companyEmail = "";

                DataTable _dtDetails = _datalayer.bindDataTable("SELECT fld_value FROM [tbl_default] WHERE (fld_default_name = 'CompanyInfo')");
                string text = _dtDetails.Rows[0]["fld_value"].ToString();
                string[] Descs = text.Split('#');
                companyName = Descs[0].ToString();
                companyAddress1 = Descs[1].ToString();
                companyAddress2 = Descs[2].ToString();
                companyPhone = Descs[3].ToString();
                companyEmail = Descs[4].ToString();

                string amountinword = string.Empty;
                DataTable _amountwordTable = new DataTable();
                string amountwordQuery = "SELECT ROUND(CONVERT(float, CASE WHEN i.fld_tax <= 0 THEN i.fld_invoice_amount ELSE ((i.fld_invoice_amount * i.fld_tax) / 100) + i.fld_invoice_amount END), 2) AS fld_invoice_amount FROM tbl_invoice WHERE fld_invoice_id = " + dgv_income.CurrentRow.Cells["fld_invoice_id"].Value.ToString();
                _amountwordTable = _datalayer.bindDataTable(amountwordQuery);
                if (_amountwordTable.Rows.Count > 0)
                {
                    decimal grand_total = Convert.ToDecimal(_amountwordTable.Rows[0]["fld_invoice_amount"].ToString());
                    string[] total = grand_total.ToString().Split('.');
                    amountinword = DataAccess.NumbersToWords(Convert.ToInt32(total[0]));
                }

                string query = "select i.fld_invoice_no, i.fld_invoice_date, ' ' as fld_customer_code,  c.fld_customer_name, c.fld_address as fld_customer_add1, c.fld_city as fld_customer_city, c.fld_phone_number AS fld_customer_mobile, i.fld_invoice_amount AS fld_gross_total, CASE WHEN i.fld_tax <= 0 THEN '' ELSE 'Tax ' + CONVERT(nvarchar(20), i.fld_tax) + '% : ' + CONVERT(nvarchar(6), ROUND(CONVERT(float, (i.fld_invoice_amount * i.fld_tax) / 100), 2)) END AS fld_tax, ROUND(CONVERT(float, CASE WHEN i.fld_tax <= 0 THEN i.fld_invoice_amount ELSE ((i.fld_invoice_amount * i.fld_tax) / 100) + i.fld_invoice_amount END), 2) AS fld_grand_total, '" + amountinword + "' as AmountinWord, p.fld_product_name, id.fld_amount, id.fld_discount, id.fld_gross_amount as fld_sub_total, '" + companyName + "' as MasterCompanyName, '" + companyAddress1 + "' as MasterCompanyAddress1, '" + companyAddress2 + "' as MasterCompanyAddress2, '" + companyPhone + "' as MasterCompanyPhone, '" + companyEmail + "' as MasterCompanyEmail from tbl_customer as c inner join tbl_invoice as i on c.fld_customer_id = i.fld_customer_id inner join tbl_invoice_details as id on i.fld_invoice_id = id.fld_invoice_id inner join tbl_product as p on id.fld_product_id = p.fld_product_id where i.fld_invoice_id = " + dgv_income.CurrentRow.Cells["fld_invoice_id"].Value.ToString();
                DataSet _dataset = new DataSet();
                _dataset = _datalayer.bindDataSet(query);

                frmView _frmfrmView = new frmView(_dataset);
                _frmfrmView.Show();
            }
        }

        private void dtp_from_date_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dtp_to_date_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dtp_from_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void dtp_to_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_i_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_expense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void dtp_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_e_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
