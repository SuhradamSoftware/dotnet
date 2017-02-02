namespace BillingSystem
{
    partial class frm_master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_backup = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_backup_time = new System.Windows.Forms.Label();
            this.txt_bu_time = new System.Windows.Forms.TextBox();
            this.txt_bu_sub = new System.Windows.Forms.TextBox();
            this.txt_bu_main = new System.Windows.Forms.TextBox();
            this.cmb_bu_dur = new System.Windows.Forms.ComboBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.ckb_backup = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_password = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_invoice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_main.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tlp_backup.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlp_header.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tlp_main.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlp_main.Controls.Add(this.tlp_header, 0, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(39, 3);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 5;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlp_main.Size = new System.Drawing.Size(645, 590);
            this.tlp_main.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel9.Controls.Add(this.tlp_backup, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.ckb_backup, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(639, 76);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // tlp_backup
            // 
            this.tlp_backup.ColumnCount = 10;
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp_backup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlp_backup.Controls.Add(this.label10, 0, 0);
            this.tlp_backup.Controls.Add(this.label11, 2, 0);
            this.tlp_backup.Controls.Add(this.label12, 4, 0);
            this.tlp_backup.Controls.Add(this.lbl_backup_time, 6, 0);
            this.tlp_backup.Controls.Add(this.txt_bu_time, 6, 1);
            this.tlp_backup.Controls.Add(this.txt_bu_sub, 2, 1);
            this.tlp_backup.Controls.Add(this.txt_bu_main, 0, 1);
            this.tlp_backup.Controls.Add(this.cmb_bu_dur, 4, 1);
            this.tlp_backup.Controls.Add(this.btn_backup, 8, 1);
            this.tlp_backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_backup.Location = new System.Drawing.Point(79, 3);
            this.tlp_backup.Name = "tlp_backup";
            this.tlp_backup.RowCount = 2;
            this.tlp_backup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_backup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_backup.Size = new System.Drawing.Size(557, 70);
            this.tlp_backup.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Main Backup Folder Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(130, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sub Backup Folder Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(257, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 28);
            this.label12.TabIndex = 21;
            this.label12.Text = "Back Duration Option";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_backup_time
            // 
            this.lbl_backup_time.AutoSize = true;
            this.lbl_backup_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_backup_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backup_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_backup_time.Location = new System.Drawing.Point(384, 0);
            this.lbl_backup_time.Name = "lbl_backup_time";
            this.lbl_backup_time.Size = new System.Drawing.Size(110, 28);
            this.lbl_backup_time.TabIndex = 22;
            this.lbl_backup_time.Text = "-";
            this.lbl_backup_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bu_time
            // 
            this.txt_bu_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_bu_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bu_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_bu_time.Location = new System.Drawing.Point(384, 31);
            this.txt_bu_time.MaxLength = 2;
            this.txt_bu_time.Name = "txt_bu_time";
            this.txt_bu_time.Size = new System.Drawing.Size(110, 24);
            this.txt_bu_time.TabIndex = 3;
            this.txt_bu_time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bu_time_KeyDown);
            this.txt_bu_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bu_time_KeyPress);
            // 
            // txt_bu_sub
            // 
            this.txt_bu_sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_bu_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bu_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_bu_sub.Location = new System.Drawing.Point(130, 31);
            this.txt_bu_sub.MaxLength = 10;
            this.txt_bu_sub.Name = "txt_bu_sub";
            this.txt_bu_sub.Size = new System.Drawing.Size(110, 24);
            this.txt_bu_sub.TabIndex = 1;
            this.txt_bu_sub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bu_sub_KeyDown);
            // 
            // txt_bu_main
            // 
            this.txt_bu_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_bu_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bu_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_bu_main.Location = new System.Drawing.Point(3, 31);
            this.txt_bu_main.MaxLength = 10;
            this.txt_bu_main.Name = "txt_bu_main";
            this.txt_bu_main.Size = new System.Drawing.Size(110, 24);
            this.txt_bu_main.TabIndex = 0;
            this.txt_bu_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bu_main_KeyDown);
            // 
            // cmb_bu_dur
            // 
            this.cmb_bu_dur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_bu_dur.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bu_dur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cmb_bu_dur.FormattingEnabled = true;
            this.cmb_bu_dur.Location = new System.Drawing.Point(257, 31);
            this.cmb_bu_dur.Name = "cmb_bu_dur";
            this.cmb_bu_dur.Size = new System.Drawing.Size(110, 26);
            this.cmb_bu_dur.TabIndex = 2;
            this.cmb_bu_dur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_bu_dur_KeyDown);
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.btn_backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Location = new System.Drawing.Point(511, 31);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(32, 36);
            this.btn_backup.TabIndex = 4;
            this.btn_backup.Text = "UPDATE";
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // ckb_backup
            // 
            this.ckb_backup.AutoSize = true;
            this.ckb_backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ckb_backup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.ckb_backup.Location = new System.Drawing.Point(9, 3);
            this.ckb_backup.Name = "ckb_backup";
            this.ckb_backup.Size = new System.Drawing.Size(64, 70);
            this.ckb_backup.TabIndex = 0;
            this.ckb_backup.Text = "Allow Back Up";
            this.ckb_backup.UseVisualStyleBackColor = true;
            this.ckb_backup.CheckedChanged += new System.EventHandler(this.ckb_backup_CheckedChanged);
            this.ckb_backup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ckb_backup_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.Controls.Add(this.btn_password, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_invoice, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_invoice, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_password, 6, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(639, 76);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_password
            // 
            this.btn_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btn_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_password.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_password.ForeColor = System.Drawing.Color.White;
            this.btn_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_password.Location = new System.Drawing.Point(434, 30);
            this.btn_password.Margin = new System.Windows.Forms.Padding(4);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(81, 42);
            this.btn_password.TabIndex = 3;
            this.btn_password.Text = "&PASSWORD SAVE";
            this.btn_password.UseVisualStyleBackColor = false;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_invoice.Location = new System.Drawing.Point(219, 30);
            this.btn_invoice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(81, 42);
            this.btn_invoice.TabIndex = 1;
            this.btn_invoice.Text = "&INVOICE SAVE";
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(105, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Invoice Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_invoice
            // 
            this.txt_invoice.BackColor = System.Drawing.Color.White;
            this.txt_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_invoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_invoice.Location = new System.Drawing.Point(105, 30);
            this.txt_invoice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_invoice.MaxLength = 10;
            this.txt_invoice.Name = "txt_invoice";
            this.txt_invoice.Size = new System.Drawing.Size(94, 24);
            this.txt_invoice.TabIndex = 0;
            this.txt_invoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_invoice_KeyDown);
            this.txt_invoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoice_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(320, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Rights Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_password.Location = new System.Drawing.Point(320, 30);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(94, 24);
            this.txt_password.TabIndex = 2;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // tlp_header
            // 
            this.tlp_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_header.ColumnCount = 2;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_header.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tlp_header.Controls.Add(this.lbl_header, 0, 0);
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_header.Location = new System.Drawing.Point(3, 3);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(639, 41);
            this.tlp_header.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btn_exit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(386, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 35);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(233, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(14, 29);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(3, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(377, 41);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Setting";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel8.Controls.Add(this.tlp_main, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(724, 596);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // frm_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(724, 596);
            this.Controls.Add(this.tableLayoutPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_job_work";
            this.Load += new System.EventHandler(this.frm_job_work_Load);
            this.tlp_main.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tlp_backup.ResumeLayout(false);
            this.tlp_backup.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlp_header.ResumeLayout(false);
            this.tlp_header.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.TextBox txt_invoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tlp_backup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_backup_time;
        private System.Windows.Forms.TextBox txt_bu_time;
        private System.Windows.Forms.TextBox txt_bu_sub;
        private System.Windows.Forms.TextBox txt_bu_main;
        private System.Windows.Forms.ComboBox cmb_bu_dur;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.CheckBox ckb_backup;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_header;
    }
}