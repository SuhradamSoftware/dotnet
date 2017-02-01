namespace BillingSystem
{
    partial class frmGBSInvoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lbl_billno = new System.Windows.Forms.Label();
            this.lbl_date_1 = new System.Windows.Forms.Label();
            this.txt_invoice_no = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lbl_mobileno = new System.Windows.Forms.Label();
            this.txt_Cust_Phone = new System.Windows.Forms.TextBox();
            this.lbl_cust_city = new System.Windows.Forms.Label();
            this.txt_Cust_City = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_description = new System.Windows.Forms.ComboBox();
            this.lbl_item_qty = new System.Windows.Forms.Label();
            this.txt_Quntity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dg_invoice = new System.Windows.Forms.DataGridView();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label_Tax1 = new System.Windows.Forms.Label();
            this.label_Tax2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.btn_customeradd = new System.Windows.Forms.Button();
            this.txt_Tax1 = new System.Windows.Forms.TextBox();
            this.txt_Tax2 = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label_Tax3 = new System.Windows.Forms.Label();
            this.txt_Tax3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Other_Charge = new System.Windows.Forms.TextBox();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_TotalTax = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbldelivery = new System.Windows.Forms.Label();
            this.txt_Delivery = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblInvoiceTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceTitle.Location = new System.Drawing.Point(12, 11);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(38, 25);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "Bill";
            // 
            // lbl_billno
            // 
            this.lbl_billno.AutoSize = true;
            this.lbl_billno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_billno.Location = new System.Drawing.Point(13, 63);
            this.lbl_billno.Name = "lbl_billno";
            this.lbl_billno.Size = new System.Drawing.Size(58, 21);
            this.lbl_billno.TabIndex = 7;
            this.lbl_billno.Text = "Bill No";
            // 
            // lbl_date_1
            // 
            this.lbl_date_1.AutoSize = true;
            this.lbl_date_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_date_1.Location = new System.Drawing.Point(363, 64);
            this.lbl_date_1.Name = "lbl_date_1";
            this.lbl_date_1.Size = new System.Drawing.Size(70, 21);
            this.lbl_date_1.TabIndex = 8;
            this.lbl_date_1.Text = "Bill Date";
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_invoice_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invoice_no.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoice_no.Location = new System.Drawing.Point(113, 59);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.Size = new System.Drawing.Size(226, 29);
            this.txt_invoice_no.TabIndex = 12;
            this.txt_invoice_no.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_date.Location = new System.Drawing.Point(439, 61);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(119, 27);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "                     ";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lblcustomer.Location = new System.Drawing.Point(13, 447);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(128, 21);
            this.lblcustomer.TabIndex = 14;
            this.lblcustomer.Text = "Customer Name";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(162, 437);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(270, 38);
            this.cmbCustomer.TabIndex = 5;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_Keydown);
            // 
            // lbl_mobileno
            // 
            this.lbl_mobileno.AutoSize = true;
            this.lbl_mobileno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobileno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_mobileno.Location = new System.Drawing.Point(13, 539);
            this.lbl_mobileno.Name = "lbl_mobileno";
            this.lbl_mobileno.Size = new System.Drawing.Size(88, 21);
            this.lbl_mobileno.TabIndex = 16;
            this.lbl_mobileno.Text = "Mobile No";
            // 
            // txt_Cust_Phone
            // 
            this.txt_Cust_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cust_Phone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_Phone.Location = new System.Drawing.Point(162, 530);
            this.txt_Cust_Phone.Name = "txt_Cust_Phone";
            this.txt_Cust_Phone.Size = new System.Drawing.Size(270, 35);
            this.txt_Cust_Phone.TabIndex = 7;
            this.txt_Cust_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cust_Phone_KeyDown);
            this.txt_Cust_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_cust_city
            // 
            this.lbl_cust_city.AutoSize = true;
            this.lbl_cust_city.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_cust_city.Location = new System.Drawing.Point(13, 496);
            this.lbl_cust_city.Name = "lbl_cust_city";
            this.lbl_cust_city.Size = new System.Drawing.Size(38, 21);
            this.lbl_cust_city.TabIndex = 18;
            this.lbl_cust_city.Text = "City";
            // 
            // txt_Cust_City
            // 
            this.txt_Cust_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cust_City.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_City.Location = new System.Drawing.Point(162, 487);
            this.txt_Cust_City.Name = "txt_Cust_City";
            this.txt_Cust_City.Size = new System.Drawing.Size(270, 35);
            this.txt_Cust_City.TabIndex = 6;
            this.txt_Cust_City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cust_City_KeyDown);
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_item.Location = new System.Drawing.Point(13, 109);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(93, 21);
            this.lbl_item.TabIndex = 20;
            this.lbl_item.Text = "Select Item";
            // 
            // cmb_description
            // 
            this.cmb_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_description.FormattingEnabled = true;
            this.cmb_description.Location = new System.Drawing.Point(113, 102);
            this.cmb_description.Name = "cmb_description";
            this.cmb_description.Size = new System.Drawing.Size(226, 29);
            this.cmb_description.TabIndex = 1;
            this.cmb_description.SelectedIndexChanged += new System.EventHandler(this.cmb_description_SelectedIndexChanged);
            this.cmb_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_description_KeyDown);
            // 
            // lbl_item_qty
            // 
            this.lbl_item_qty.AutoSize = true;
            this.lbl_item_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_item_qty.Location = new System.Drawing.Point(360, 110);
            this.lbl_item_qty.Name = "lbl_item_qty";
            this.lbl_item_qty.Size = new System.Drawing.Size(36, 21);
            this.lbl_item_qty.TabIndex = 22;
            this.lbl_item_qty.Text = "Qty";
            // 
            // txt_Quntity
            // 
            this.txt_Quntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quntity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quntity.Location = new System.Drawing.Point(404, 105);
            this.txt_Quntity.Name = "txt_Quntity";
            this.txt_Quntity.Size = new System.Drawing.Size(80, 29);
            this.txt_Quntity.TabIndex = 2;
            this.txt_Quntity.TextChanged += new System.EventHandler(this.txt_Line_TextChanged);
            this.txt_Quntity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quntity_KeyDown);
            this.txt_Quntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.Price.Location = new System.Drawing.Point(499, 109);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(46, 21);
            this.Price.TabIndex = 24;
            this.Price.Text = "Price";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(551, 105);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(93, 29);
            this.txt_UnitPrice.TabIndex = 3;
            this.txt_UnitPrice.TextChanged += new System.EventHandler(this.txt_Line_TextChanged);
            this.txt_UnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UnitPrice_KeyDown);
            this.txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(840, 101);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 35);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "+ADD";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dg_invoice
            // 
            this.dg_invoice.AllowUserToAddRows = false;
            this.dg_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_invoice.Location = new System.Drawing.Point(17, 148);
            this.dg_invoice.Name = "dg_invoice";
            this.dg_invoice.RowHeadersVisible = false;
            this.dg_invoice.Size = new System.Drawing.Size(1021, 267);
            this.dg_invoice.TabIndex = 27;
            this.dg_invoice.TabStop = false;
            this.dg_invoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_invoice_CellDoubleClick);
            this.dg_invoice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dg_invoice_DataBindingComplete);
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_subtotal.Location = new System.Drawing.Point(663, 424);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(79, 21);
            this.lbl_subtotal.TabIndex = 28;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // label_Tax1
            // 
            this.label_Tax1.AutoSize = true;
            this.label_Tax1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_Tax1.Location = new System.Drawing.Point(677, 459);
            this.label_Tax1.Name = "label_Tax1";
            this.label_Tax1.Size = new System.Drawing.Size(62, 17);
            this.label_Tax1.TabIndex = 29;
            this.label_Tax1.Text = "Tax 1 (%)";
            // 
            // label_Tax2
            // 
            this.label_Tax2.AutoSize = true;
            this.label_Tax2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_Tax2.Location = new System.Drawing.Point(815, 458);
            this.label_Tax2.Name = "label_Tax2";
            this.label_Tax2.Size = new System.Drawing.Size(62, 17);
            this.label_Tax2.TabIndex = 30;
            this.label_Tax2.Text = "Tax 2 (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(668, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(643, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Grand Total";
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.Location = new System.Drawing.Point(757, 561);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.ReadOnly = true;
            this.txt_TotalAmount.Size = new System.Drawing.Size(175, 26);
            this.txt_TotalAmount.TabIndex = 33;
            this.txt_TotalAmount.TabStop = false;
            this.txt_TotalAmount.Text = "0.00";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(947, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(735, 103);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(93, 29);
            this.txt_amount.TabIndex = 36;
            this.txt_amount.TabStop = false;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_amount.Location = new System.Drawing.Point(658, 108);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(69, 21);
            this.lbl_amount.TabIndex = 35;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_SubTotal.Location = new System.Drawing.Point(757, 424);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(175, 22);
            this.txt_SubTotal.TabIndex = 37;
            this.txt_SubTotal.TabStop = false;
            this.txt_SubTotal.Text = "0.00";
            // 
            // btn_customeradd
            // 
            this.btn_customeradd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_customeradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customeradd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customeradd.ForeColor = System.Drawing.Color.White;
            this.btn_customeradd.Location = new System.Drawing.Point(439, 447);
            this.btn_customeradd.Name = "btn_customeradd";
            this.btn_customeradd.Size = new System.Drawing.Size(70, 35);
            this.btn_customeradd.TabIndex = 38;
            this.btn_customeradd.TabStop = false;
            this.btn_customeradd.Text = "+ADD";
            this.btn_customeradd.UseVisualStyleBackColor = false;
            this.btn_customeradd.Click += new System.EventHandler(this.btn_customeradd_Click);
            // 
            // txt_Tax1
            // 
            this.txt_Tax1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Tax1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tax1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Tax1.Location = new System.Drawing.Point(757, 458);
            this.txt_Tax1.Name = "txt_Tax1";
            this.txt_Tax1.Size = new System.Drawing.Size(53, 18);
            this.txt_Tax1.TabIndex = 39;
            this.txt_Tax1.TabStop = false;
            this.txt_Tax1.Text = "0.00";
            this.txt_Tax1.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_Tax2
            // 
            this.txt_Tax2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Tax2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tax2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Tax2.Location = new System.Drawing.Point(878, 458);
            this.txt_Tax2.Name = "txt_Tax2";
            this.txt_Tax2.Size = new System.Drawing.Size(53, 18);
            this.txt_Tax2.TabIndex = 40;
            this.txt_Tax2.TabStop = false;
            this.txt_Tax2.Text = "0.00";
            this.txt_Tax2.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(757, 525);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(175, 22);
            this.txt_discount.TabIndex = 9;
            this.txt_discount.Text = "0.00";
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label_Tax3
            // 
            this.label_Tax3.AutoSize = true;
            this.label_Tax3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tax3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_Tax3.Location = new System.Drawing.Point(675, 497);
            this.label_Tax3.Name = "label_Tax3";
            this.label_Tax3.Size = new System.Drawing.Size(62, 17);
            this.label_Tax3.TabIndex = 42;
            this.label_Tax3.Text = "Tax 3 (%)";
            // 
            // txt_Tax3
            // 
            this.txt_Tax3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Tax3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tax3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Tax3.Location = new System.Drawing.Point(757, 496);
            this.txt_Tax3.Name = "txt_Tax3";
            this.txt_Tax3.Size = new System.Drawing.Size(53, 18);
            this.txt_Tax3.TabIndex = 43;
            this.txt_Tax3.TabStop = false;
            this.txt_Tax3.Text = "0.00";
            this.txt_Tax3.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Tax3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(820, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Other";
            // 
            // txt_Other_Charge
            // 
            this.txt_Other_Charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Other_Charge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Other_Charge.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Other_Charge.Location = new System.Drawing.Point(876, 495);
            this.txt_Other_Charge.Name = "txt_Other_Charge";
            this.txt_Other_Charge.Size = new System.Drawing.Size(53, 18);
            this.txt_Other_Charge.TabIndex = 45;
            this.txt_Other_Charge.TabStop = false;
            this.txt_Other_Charge.Text = "0.00";
            this.txt_Other_Charge.TextChanged += new System.EventHandler(this.txt_Summary_TextChanged);
            this.txt_Other_Charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // txt_TotalTax
            // 
            this.txt_TotalTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_TotalTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalTax.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_TotalTax.Location = new System.Drawing.Point(937, 457);
            this.txt_TotalTax.MaxLength = 20;
            this.txt_TotalTax.Name = "txt_TotalTax";
            this.txt_TotalTax.ReadOnly = true;
            this.txt_TotalTax.Size = new System.Drawing.Size(105, 16);
            this.txt_TotalTax.TabIndex = 102;
            this.txt_TotalTax.Text = "0.00";
            this.txt_TotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TotalTax.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(911, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 35);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "RESET";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(94)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(982, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.TabIndex = 104;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbldelivery
            // 
            this.lbldelivery.AutoSize = true;
            this.lbldelivery.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbldelivery.Location = new System.Drawing.Point(13, 588);
            this.lbldelivery.Name = "lbldelivery";
            this.lbldelivery.Size = new System.Drawing.Size(69, 21);
            this.lbldelivery.TabIndex = 105;
            this.lbldelivery.Text = "Delivery";
            // 
            // txt_Delivery
            // 
            this.txt_Delivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Delivery.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delivery.Location = new System.Drawing.Point(162, 579);
            this.txt_Delivery.Name = "txt_Delivery";
            this.txt_Delivery.Size = new System.Drawing.Size(271, 35);
            this.txt_Delivery.TabIndex = 8;
            // 
            // frmGBSInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1060, 623);
            this.Controls.Add(this.txt_Delivery);
            this.Controls.Add(this.lbldelivery);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txt_TotalTax);
            this.Controls.Add(this.txt_Other_Charge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Tax3);
            this.Controls.Add(this.label_Tax3);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_Tax2);
            this.Controls.Add(this.txt_Tax1);
            this.Controls.Add(this.btn_customeradd);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Tax2);
            this.Controls.Add(this.label_Tax1);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.dg_invoice);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txt_Quntity);
            this.Controls.Add(this.lbl_item_qty);
            this.Controls.Add(this.cmb_description);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.txt_Cust_City);
            this.Controls.Add(this.lbl_cust_city);
            this.Controls.Add(this.txt_Cust_Phone);
            this.Controls.Add(this.lbl_mobileno);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_invoice_no);
            this.Controls.Add(this.lbl_date_1);
            this.Controls.Add(this.lbl_billno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(80, 60);
            this.Name = "frmGBSInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGBSInvoice";
            this.Load += new System.EventHandler(this.frmGBSInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.Label lbl_billno;
        private System.Windows.Forms.Label lbl_date_1;
        private System.Windows.Forms.TextBox txt_invoice_no;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lbl_mobileno;
        private System.Windows.Forms.TextBox txt_Cust_Phone;
        private System.Windows.Forms.Label lbl_cust_city;
        private System.Windows.Forms.TextBox txt_Cust_City;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.ComboBox cmb_description;
        private System.Windows.Forms.Label lbl_item_qty;
        private System.Windows.Forms.TextBox txt_Quntity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dg_invoice;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label label_Tax1;
        private System.Windows.Forms.Label label_Tax2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Button btn_customeradd;
        private System.Windows.Forms.TextBox txt_Tax1;
        private System.Windows.Forms.TextBox txt_Tax2;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label_Tax3;
        private System.Windows.Forms.TextBox txt_Tax3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Other_Charge;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.TextBox txt_TotalTax;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbldelivery;
        private System.Windows.Forms.TextBox txt_Delivery;
    }
}