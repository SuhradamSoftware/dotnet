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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.box1 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_invoice_no = new System.Windows.Forms.TextBox();
            this.txt_Cust_Zip = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Cust_City = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Cust_State = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Cust_Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Department = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Other_Charge = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_shipping = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Tax1 = new System.Windows.Forms.TextBox();
            this.label_Tax1 = new System.Windows.Forms.Label();
            this.txt_Tax2 = new System.Windows.Forms.TextBox();
            this.label_Tax2 = new System.Windows.Forms.Label();
            this.txt_Tax3 = new System.Windows.Forms.TextBox();
            this.label_Tax3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.labeldiscount = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.txt_TotalTax = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.box1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoice)).BeginInit();
            this.invoicepanel.SuspendLayout();
            this.lbl_net_amount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // box1
            // 
            this.box1.Controls.Add(this.cmbCustomer);
            this.box1.Controls.Add(this.lbl_date);
            this.box1.Controls.Add(this.label4);
            this.box1.Controls.Add(this.label5);
            this.box1.Controls.Add(this.txt_invoice_no);
            this.box1.Controls.Add(this.txt_Cust_Zip);
            this.box1.Controls.Add(this.label15);
            this.box1.Controls.Add(this.txt_Cust_City);
            this.box1.Controls.Add(this.label13);
            this.box1.Controls.Add(this.txt_Cust_State);
            this.box1.Controls.Add(this.label12);
            this.box1.Controls.Add(this.txt_CustomerAddress);
            this.box1.Controls.Add(this.label9);
            this.box1.Controls.Add(this.txt_Cust_Phone);
            this.box1.Controls.Add(this.label8);
            this.box1.Controls.Add(this.txt_Department);
            this.box1.Controls.Add(this.label7);
            this.box1.Controls.Add(this.label3);
            this.box1.Controls.Add(this.txt_CustomerName);
            this.box1.Controls.Add(this.label2);
            this.box1.Font = new System.Drawing.Font("Calibri", 11F);
            this.box1.Location = new System.Drawing.Point(14, 50);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(1174, 162);
            this.box1.TabIndex = 75;
            this.box1.TabStop = false;
            this.box1.Text = "Customer Details";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCustomer.BackColor = System.Drawing.Color.Linen;
            this.cmbCustomer.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(145, 48);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(309, 23);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_Keydown);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lbl_date.Location = new System.Drawing.Point(790, 19);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 15);
            this.lbl_date.TabIndex = 86;
            this.lbl_date.Text = "lbl_date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label4.Location = new System.Drawing.Point(746, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label5.Location = new System.Drawing.Point(79, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 87;
            this.label5.Text = "Bill No :";
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.BackColor = System.Drawing.Color.Linen;
            this.txt_invoice_no.Enabled = false;
            this.txt_invoice_no.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_invoice_no.Location = new System.Drawing.Point(145, 22);
            this.txt_invoice_no.MaxLength = 20;
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.Size = new System.Drawing.Size(168, 23);
            this.txt_invoice_no.TabIndex = 88;
            // 
            // txt_Cust_Zip
            // 
            this.txt_Cust_Zip.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_Zip.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Cust_Zip.Location = new System.Drawing.Point(793, 132);
            this.txt_Cust_Zip.MaxLength = 10;
            this.txt_Cust_Zip.Name = "txt_Cust_Zip";
            this.txt_Cust_Zip.Size = new System.Drawing.Size(88, 23);
            this.txt_Cust_Zip.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label15.Location = new System.Drawing.Point(761, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Zip :";
            // 
            // txt_Cust_City
            // 
            this.txt_Cust_City.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_City.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Cust_City.Location = new System.Drawing.Point(486, 132);
            this.txt_Cust_City.MaxLength = 100;
            this.txt_Cust_City.Name = "txt_Cust_City";
            this.txt_Cust_City.Size = new System.Drawing.Size(119, 23);
            this.txt_Cust_City.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label13.Location = new System.Drawing.Point(446, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "City :";
            // 
            // txt_Cust_State
            // 
            this.txt_Cust_State.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_State.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Cust_State.Location = new System.Drawing.Point(145, 129);
            this.txt_Cust_State.MaxLength = 100;
            this.txt_Cust_State.Name = "txt_Cust_State";
            this.txt_Cust_State.Size = new System.Drawing.Size(130, 23);
            this.txt_Cust_State.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label12.Location = new System.Drawing.Point(92, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "State :";
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.BackColor = System.Drawing.Color.Linen;
            this.txt_CustomerAddress.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_CustomerAddress.Location = new System.Drawing.Point(145, 102);
            this.txt_CustomerAddress.MaxLength = 500;
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.Size = new System.Drawing.Size(1014, 23);
            this.txt_CustomerAddress.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label9.Location = new System.Drawing.Point(75, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address :";
            // 
            // txt_Cust_Phone
            // 
            this.txt_Cust_Phone.BackColor = System.Drawing.Color.Linen;
            this.txt_Cust_Phone.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Cust_Phone.Location = new System.Drawing.Point(791, 75);
            this.txt_Cust_Phone.MaxLength = 20;
            this.txt_Cust_Phone.Name = "txt_Cust_Phone";
            this.txt_Cust_Phone.Size = new System.Drawing.Size(214, 23);
            this.txt_Cust_Phone.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label8.Location = new System.Drawing.Point(722, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone No. :";
            // 
            // txt_Department
            // 
            this.txt_Department.BackColor = System.Drawing.Color.Linen;
            this.txt_Department.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Department.Location = new System.Drawing.Point(145, 75);
            this.txt_Department.MaxLength = 100;
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(314, 23);
            this.txt_Department.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label7.Location = new System.Drawing.Point(21, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Department Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name :";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BackColor = System.Drawing.Color.Linen;
            this.txt_CustomerName.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_CustomerName.Location = new System.Drawing.Point(791, 48);
            this.txt_CustomerName.MaxLength = 100;
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(314, 23);
            this.txt_CustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label2.Location = new System.Drawing.Point(686, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact Person :";
            // 
            // dg_invoice
            // 
            this.dg_invoice.AllowUserToAddRows = false;
            this.dg_invoice.BackgroundColor = System.Drawing.Color.White;
            this.dg_invoice.Location = new System.Drawing.Point(11, 291);
            this.dg_invoice.Name = "dg_invoice";
            this.dg_invoice.ReadOnly = true;
            this.dg_invoice.RowHeadersVisible = false;
            this.dg_invoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_invoice.Size = new System.Drawing.Size(1177, 179);
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
            this.lbl_net_amount.Location = new System.Drawing.Point(14, 213);
            this.lbl_net_amount.Name = "lbl_net_amount";
            this.lbl_net_amount.Size = new System.Drawing.Size(1174, 73);
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
            this.btnCancel.Location = new System.Drawing.Point(996, 39);
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
            this.btnDelete.Location = new System.Drawing.Point(909, 40);
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
            this.txt_amount.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_amount.Location = new System.Drawing.Point(582, 46);
            this.txt_amount.MaxLength = 15;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(203, 23);
            this.txt_amount.TabIndex = 12;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(523, 48);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(55, 15);
            this.lblamount.TabIndex = 59;
            this.lblamount.Text = "Amount :";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BackColor = System.Drawing.Color.Linen;
            this.txt_UnitPrice.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_UnitPrice.Location = new System.Drawing.Point(361, 42);
            this.txt_UnitPrice.MaxLength = 10;
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(93, 23);
            this.txt_UnitPrice.TabIndex = 11;
            this.txt_UnitPrice.TextChanged += new System.EventHandler(this.txt_UnitPrice_TextChanged);
            this.txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitPrice_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label16.Location = new System.Drawing.Point(294, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 57;
            this.label16.Text = "Unit Price :";
            // 
            // txt_Quntity
            // 
            this.txt_Quntity.BackColor = System.Drawing.Color.Linen;
            this.txt_Quntity.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Quntity.Location = new System.Drawing.Point(145, 43);
            this.txt_Quntity.MaxLength = 10;
            this.txt_Quntity.Name = "txt_Quntity";
            this.txt_Quntity.Size = new System.Drawing.Size(64, 23);
            this.txt_Quntity.TabIndex = 10;
            this.txt_Quntity.TextChanged += new System.EventHandler(this.txt_Quntity_TextChanged);
            this.txt_Quntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quntity_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label17.Location = new System.Drawing.Point(82, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
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
            this.btnSave.Location = new System.Drawing.Point(808, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_description
            // 
            this.cmb_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_description.BackColor = System.Drawing.Color.Linen;
            this.cmb_description.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cmb_description.FormattingEnabled = true;
            this.cmb_description.Location = new System.Drawing.Point(145, 16);
            this.cmb_description.Name = "cmb_description";
            this.cmb_description.Size = new System.Drawing.Size(309, 23);
            this.cmb_description.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(59, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
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
            this.btnPrint.Location = new System.Drawing.Point(1111, 563);
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
            this.label11.Location = new System.Drawing.Point(909, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 88;
            this.label11.Text = "Sub Total :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Other_Charge);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_shipping);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(509, 540);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 56);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Charges";
            // 
            // txt_Other_Charge
            // 
            this.txt_Other_Charge.BackColor = System.Drawing.Color.Linen;
            this.txt_Other_Charge.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Other_Charge.Location = new System.Drawing.Point(285, 24);
            this.txt_Other_Charge.MaxLength = 8;
            this.txt_Other_Charge.Name = "txt_Other_Charge";
            this.txt_Other_Charge.Size = new System.Drawing.Size(81, 23);
            this.txt_Other_Charge.TabIndex = 95;
            this.txt_Other_Charge.Text = "0.00";
            this.txt_Other_Charge.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Other_Charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(219, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 96;
            this.label19.Text = "Other :";
            // 
            // txt_shipping
            // 
            this.txt_shipping.BackColor = System.Drawing.Color.Linen;
            this.txt_shipping.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_shipping.Location = new System.Drawing.Point(126, 22);
            this.txt_shipping.MaxLength = 8;
            this.txt_shipping.Name = "txt_shipping";
            this.txt_shipping.Size = new System.Drawing.Size(81, 23);
            this.txt_shipping.TabIndex = 94;
            this.txt_shipping.Text = "0.00";
            this.txt_shipping.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_shipping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(60, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 94;
            this.label18.Text = "Shipping :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(930, 570);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 15);
            this.label20.TabIndex = 93;
            this.label20.Text = "Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Tax1);
            this.groupBox1.Controls.Add(this.label_Tax1);
            this.groupBox1.Controls.Add(this.txt_Tax2);
            this.groupBox1.Controls.Add(this.label_Tax2);
            this.groupBox1.Controls.Add(this.txt_Tax3);
            this.groupBox1.Controls.Add(this.label_Tax3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(352, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 56);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxes";
            // 
            // txt_Tax1
            // 
            this.txt_Tax1.BackColor = System.Drawing.Color.Linen;
            this.txt_Tax1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Tax1.Location = new System.Drawing.Point(440, 24);
            this.txt_Tax1.MaxLength = 5;
            this.txt_Tax1.Name = "txt_Tax1";
            this.txt_Tax1.Size = new System.Drawing.Size(81, 23);
            this.txt_Tax1.TabIndex = 95;
            this.txt_Tax1.Text = "0.00";
            this.txt_Tax1.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label_Tax1
            // 
            this.label_Tax1.AutoSize = true;
            this.label_Tax1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax1.Location = new System.Drawing.Point(374, 27);
            this.label_Tax1.Name = "label_Tax1";
            this.label_Tax1.Size = new System.Drawing.Size(61, 15);
            this.label_Tax1.TabIndex = 96;
            this.label_Tax1.Text = "Tax 1 (%) :";
            this.label_Tax1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Tax2
            // 
            this.txt_Tax2.BackColor = System.Drawing.Color.Linen;
            this.txt_Tax2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Tax2.Location = new System.Drawing.Point(283, 22);
            this.txt_Tax2.MaxLength = 5;
            this.txt_Tax2.Name = "txt_Tax2";
            this.txt_Tax2.Size = new System.Drawing.Size(81, 23);
            this.txt_Tax2.TabIndex = 94;
            this.txt_Tax2.Text = "0.00";
            this.txt_Tax2.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label_Tax2
            // 
            this.label_Tax2.AutoSize = true;
            this.label_Tax2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax2.Location = new System.Drawing.Point(217, 25);
            this.label_Tax2.Name = "label_Tax2";
            this.label_Tax2.Size = new System.Drawing.Size(61, 15);
            this.label_Tax2.TabIndex = 94;
            this.label_Tax2.Text = "Tax 2 (%) :";
            this.label_Tax2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Tax3
            // 
            this.txt_Tax3.BackColor = System.Drawing.Color.Linen;
            this.txt_Tax3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Tax3.Location = new System.Drawing.Point(120, 21);
            this.txt_Tax3.MaxLength = 5;
            this.txt_Tax3.Name = "txt_Tax3";
            this.txt_Tax3.Size = new System.Drawing.Size(81, 23);
            this.txt_Tax3.TabIndex = 93;
            this.txt_Tax3.Text = "0.00";
            this.txt_Tax3.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label_Tax3
            // 
            this.label_Tax3.AutoSize = true;
            this.label_Tax3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax3.Location = new System.Drawing.Point(58, 23);
            this.label_Tax3.Name = "label_Tax3";
            this.label_Tax3.Size = new System.Drawing.Size(61, 15);
            this.label_Tax3.TabIndex = 92;
            this.label_Tax3.Text = "Tax 3 (%) :";
            this.label_Tax3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(909, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 98;
            this.label10.Text = "Total Tax :";
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.Linen;
            this.txt_discount.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_discount.Location = new System.Drawing.Point(998, 535);
            this.txt_discount.MaxLength = 8;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(105, 23);
            this.txt_discount.TabIndex = 97;
            this.txt_discount.Text = "0.00";
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // labeldiscount
            // 
            this.labeldiscount.AutoSize = true;
            this.labeldiscount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiscount.Location = new System.Drawing.Point(909, 538);
            this.labeldiscount.Name = "labeldiscount";
            this.labeldiscount.Size = new System.Drawing.Size(61, 15);
            this.labeldiscount.TabIndex = 98;
            this.labeldiscount.Text = "Discount :";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SubTotal.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_SubTotal.Location = new System.Drawing.Point(998, 473);
            this.txt_SubTotal.MaxLength = 20;
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(105, 23);
            this.txt_SubTotal.TabIndex = 100;
            this.txt_SubTotal.Text = "0.00";
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalTax
            // 
            this.txt_TotalTax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TotalTax.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_TotalTax.Location = new System.Drawing.Point(998, 503);
            this.txt_TotalTax.MaxLength = 20;
            this.txt_TotalTax.Name = "txt_TotalTax";
            this.txt_TotalTax.ReadOnly = true;
            this.txt_TotalTax.Size = new System.Drawing.Size(105, 23);
            this.txt_TotalTax.TabIndex = 101;
            this.txt_TotalTax.Text = "0.00";
            this.txt_TotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_TotalAmount.Location = new System.Drawing.Point(998, 567);
            this.txt_TotalAmount.MaxLength = 20;
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.ReadOnly = true;
            this.txt_TotalAmount.Size = new System.Drawing.Size(105, 23);
            this.txt_TotalAmount.TabIndex = 102;
            this.txt_TotalAmount.Text = "0.00";
            this.txt_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.txt_TotalTax);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.labeldiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.TextBox txt_Cust_Zip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Cust_City;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Cust_Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_shipping;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Other_Charge;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Cust_State;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Tax1;
        private System.Windows.Forms.Label label_Tax1;
        private System.Windows.Forms.TextBox txt_Tax2;
        private System.Windows.Forms.Label label_Tax2;
        private System.Windows.Forms.TextBox txt_Tax3;
        private System.Windows.Forms.Label label_Tax3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label labeldiscount;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.TextBox txt_TotalTax;
        private System.Windows.Forms.TextBox txt_SubTotal;
    }
}