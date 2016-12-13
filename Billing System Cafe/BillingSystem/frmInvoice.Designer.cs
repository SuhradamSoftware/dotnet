namespace BillingSystem
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.box1 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_invoice_no = new System.Windows.Forms.TextBox();
            this.txt_Cust_City = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Cust_Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_invoice = new System.Windows.Forms.DataGridView();
            this.invoicepanel = new System.Windows.Forms.Panel();
            this.btnGClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_net_amount = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Quntity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmb_description = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbl_rupeesword = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label_DocumentType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_CodeType = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.box1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoice)).BeginInit();
            this.invoicepanel.SuspendLayout();
            this.lbl_net_amount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // box1
            // 
            this.box1.Controls.Add(this.label_CodeType);
            this.box1.Controls.Add(this.label_Code);
            this.box1.Controls.Add(this.pictureBox1);
            this.box1.Controls.Add(this.label_DocumentType);
            this.box1.Controls.Add(this.label7);
            this.box1.Controls.Add(this.cmbCustomer);
            this.box1.Controls.Add(this.lbl_date);
            this.box1.Controls.Add(this.label4);
            this.box1.Controls.Add(this.label5);
            this.box1.Controls.Add(this.txt_invoice_no);
            this.box1.Controls.Add(this.txt_Cust_City);
            this.box1.Controls.Add(this.label13);
            this.box1.Controls.Add(this.txt_CustomerAddress);
            this.box1.Controls.Add(this.label9);
            this.box1.Controls.Add(this.txt_Cust_Phone);
            this.box1.Controls.Add(this.label8);
            this.box1.Controls.Add(this.label3);
            this.box1.Font = new System.Drawing.Font("Calibri", 11F);
            this.box1.Location = new System.Drawing.Point(14, 50);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(1174, 240);
            this.box1.TabIndex = 75;
            this.box1.TabStop = false;
            this.box1.Text = "Customer Details";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCustomer.BackColor = System.Drawing.Color.Linen;
            this.cmbCustomer.Font = new System.Drawing.Font("Calibri", 15F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(157, 61);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(309, 32);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_Keydown);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_date.Location = new System.Drawing.Point(396, 25);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(79, 24);
            this.lbl_date.TabIndex = 86;
            this.lbl_date.Text = "lbl_date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F);
            this.label4.Location = new System.Drawing.Point(335, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F);
            this.label5.Location = new System.Drawing.Point(71, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "Bill No :";
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.BackColor = System.Drawing.Color.Linen;
            this.txt_invoice_no.Enabled = false;
            this.txt_invoice_no.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt_invoice_no.Location = new System.Drawing.Point(157, 22);
            this.txt_invoice_no.MaxLength = 20;
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.Size = new System.Drawing.Size(168, 32);
            this.txt_invoice_no.TabIndex = 88;
            // 
            // txt_Cust_City
            // 
            this.txt_Cust_City.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_City.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt_Cust_City.Location = new System.Drawing.Point(157, 137);
            this.txt_Cust_City.MaxLength = 100;
            this.txt_Cust_City.Name = "txt_Cust_City";
            this.txt_Cust_City.Size = new System.Drawing.Size(119, 32);
            this.txt_Cust_City.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15F);
            this.label13.Location = new System.Drawing.Point(99, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "City :";
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.BackColor = System.Drawing.Color.Linen;
            this.txt_CustomerAddress.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt_CustomerAddress.Location = new System.Drawing.Point(157, 99);
            this.txt_CustomerAddress.MaxLength = 500;
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(633, 32);
            this.txt_CustomerAddress.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15F);
            this.label9.Location = new System.Drawing.Point(63, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address :";
            // 
            // txt_Cust_Phone
            // 
            this.txt_Cust_Phone.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_Phone.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt_Cust_Phone.Location = new System.Drawing.Point(400, 143);
            this.txt_Cust_Phone.MaxLength = 20;
            this.txt_Cust_Phone.Name = "txt_Cust_Phone";
            this.txt_Cust_Phone.Size = new System.Drawing.Size(142, 32);
            this.txt_Cust_Phone.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F);
            this.label8.Location = new System.Drawing.Point(287, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F);
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer :";
            // 
            // dg_invoice
            // 
            this.dg_invoice.AllowUserToAddRows = false;
            this.dg_invoice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_invoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_invoice.Location = new System.Drawing.Point(11, 413);
            this.dg_invoice.Name = "dg_invoice";
            this.dg_invoice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_invoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_invoice.RowHeadersVisible = false;
            this.dg_invoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_invoice.Size = new System.Drawing.Size(1177, 147);
            this.dg_invoice.TabIndex = 81;
            this.dg_invoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_invoice_CellDoubleClick);
            // 
            // invoicepanel
            // 
            this.invoicepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.invoicepanel.Controls.Add(this.btnGClose);
            this.invoicepanel.Controls.Add(this.label1);
            this.invoicepanel.Location = new System.Drawing.Point(17, 8);
            this.invoicepanel.Name = "invoicepanel";
            this.invoicepanel.Size = new System.Drawing.Size(1171, 36);
            this.invoicepanel.TabIndex = 82;
            // 
            // btnGClose
            // 
            this.btnGClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGClose.BackColor = System.Drawing.Color.White;
            this.btnGClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGClose.Image = global::BillingSystem.Properties.Resources.close;
            this.btnGClose.Location = new System.Drawing.Point(1131, 6);
            this.btnGClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnGClose.Name = "btnGClose";
            this.btnGClose.Size = new System.Drawing.Size(27, 23);
            this.btnGClose.TabIndex = 107;
            this.btnGClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGClose.UseVisualStyleBackColor = false;
            this.btnGClose.Click += new System.EventHandler(this.btnGClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 106;
            this.label1.Text = "Invoice";
            // 
            // lbl_net_amount
            // 
            this.lbl_net_amount.Controls.Add(this.btnCancel);
            this.lbl_net_amount.Controls.Add(this.btnDelete);
            this.lbl_net_amount.Controls.Add(this.txt_amount);
            this.lbl_net_amount.Controls.Add(this.lblamount);
            this.lbl_net_amount.Controls.Add(this.txt_UnitPrice);
            this.lbl_net_amount.Controls.Add(this.label16);
            this.lbl_net_amount.Controls.Add(this.txt_Quntity);
            this.lbl_net_amount.Controls.Add(this.label17);
            this.lbl_net_amount.Controls.Add(this.btnSave);
            this.lbl_net_amount.Controls.Add(this.cmb_description);
            this.lbl_net_amount.Controls.Add(this.label6);
            this.lbl_net_amount.Font = new System.Drawing.Font("Calibri", 11F);
            this.lbl_net_amount.Location = new System.Drawing.Point(14, 296);
            this.lbl_net_amount.Name = "lbl_net_amount";
            this.lbl_net_amount.Size = new System.Drawing.Size(1174, 111);
            this.lbl_net_amount.TabIndex = 83;
            this.lbl_net_amount.TabStop = false;
            this.lbl_net_amount.Text = "Line Items";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(996, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 28);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(909, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 28);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.Linen;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(587, 69);
            this.txt_amount.MaxLength = 15;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(203, 30);
            this.txt_amount.TabIndex = 12;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(481, 72);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(91, 25);
            this.lblamount.TabIndex = 59;
            this.lblamount.Text = "Amount :";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BackColor = System.Drawing.Color.Linen;
            this.txt_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(373, 69);
            this.txt_UnitPrice.MaxLength = 10;
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(93, 30);
            this.txt_UnitPrice.TabIndex = 7;
            this.txt_UnitPrice.TextChanged += new System.EventHandler(this.txt_UnitPrice_TextChanged);
            this.txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitPrice_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(249, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 57;
            this.label16.Text = "Unit Price :";
            // 
            // txt_Quntity
            // 
            this.txt_Quntity.BackColor = System.Drawing.Color.Linen;
            this.txt_Quntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quntity.Location = new System.Drawing.Point(145, 66);
            this.txt_Quntity.MaxLength = 10;
            this.txt_Quntity.Name = "txt_Quntity";
            this.txt_Quntity.Size = new System.Drawing.Size(78, 30);
            this.txt_Quntity.TabIndex = 6;
            this.txt_Quntity.TextChanged += new System.EventHandler(this.txt_Quntity_TextChanged);
            this.txt_Quntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quntity_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(50, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 25);
            this.label17.TabIndex = 55;
            this.label17.Text = "Quantity :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(808, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_description
            // 
            this.cmb_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_description.BackColor = System.Drawing.Color.Linen;
            this.cmb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_description.FormattingEnabled = true;
            this.cmb_description.Location = new System.Drawing.Point(145, 16);
            this.cmb_description.Name = "cmb_description";
            this.cmb_description.Size = new System.Drawing.Size(309, 33);
            this.cmb_description.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Description :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(215)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(1125, 573);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 30);
            this.btnPrint.TabIndex = 96;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbl_rupeesword
            // 
            this.lbl_rupeesword.AutoSize = true;
            this.lbl_rupeesword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rupeesword.Location = new System.Drawing.Point(73, 545);
            this.lbl_rupeesword.Name = "lbl_rupeesword";
            this.lbl_rupeesword.Size = new System.Drawing.Size(0, 15);
            this.lbl_rupeesword.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(909, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 88;
            this.label11.Text = "Total :";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SubTotal.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_SubTotal.Location = new System.Drawing.Point(998, 573);
            this.txt_SubTotal.MaxLength = 20;
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(105, 23);
            this.txt_SubTotal.TabIndex = 100;
            this.txt_SubTotal.Text = "0.00";
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_DocumentType
            // 
            this.label_DocumentType.AutoSize = true;
            this.label_DocumentType.Font = new System.Drawing.Font("Calibri", 15F);
            this.label_DocumentType.Location = new System.Drawing.Point(160, 181);
            this.label_DocumentType.Name = "label_DocumentType";
            this.label_DocumentType.Size = new System.Drawing.Size(35, 24);
            this.label_DocumentType.TabIndex = 90;
            this.label_DocumentType.Text = "NA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F);
            this.label7.Location = new System.Drawing.Point(50, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 89;
            this.label7.Text = "Document :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(808, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label_CodeType
            // 
            this.label_CodeType.AutoSize = true;
            this.label_CodeType.Font = new System.Drawing.Font("Calibri", 15F);
            this.label_CodeType.Location = new System.Drawing.Point(636, 64);
            this.label_CodeType.Name = "label_CodeType";
            this.label_CodeType.Size = new System.Drawing.Size(35, 24);
            this.label_CodeType.TabIndex = 93;
            this.label_CodeType.Text = "NA";
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Font = new System.Drawing.Font("Calibri", 15F);
            this.label_Code.Location = new System.Drawing.Point(482, 64);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(149, 24);
            this.label_Code.TabIndex = 92;
            this.label_Code.Text = "Customer Code :";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 614);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.invoicepanel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbl_rupeesword);
            this.Controls.Add(this.dg_invoice);
            this.Controls.Add(this.lbl_net_amount);
            this.Controls.Add(this.box1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInvoice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoice)).EndInit();
            this.invoicepanel.ResumeLayout(false);
            this.invoicepanel.PerformLayout();
            this.lbl_net_amount.ResumeLayout(false);
            this.lbl_net_amount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.TextBox txt_Cust_City;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Cust_Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_invoice;
        private System.Windows.Forms.GroupBox lbl_net_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Quntity;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmb_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel invoicepanel;
        private System.Windows.Forms.Button btnGClose;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbl_rupeesword;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_invoice_no;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label_DocumentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_CodeType;
        private System.Windows.Forms.Label label_Code;
    }
}