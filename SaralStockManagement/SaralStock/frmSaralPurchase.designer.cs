namespace BillingSystem
{
    partial class frmSaralPurchase
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
            this.tbl_productmain = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_producttitle = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Details = new System.Windows.Forms.Label();
            this.tbl_productform = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.cmb_Party = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ItemNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_sale_price = new System.Windows.Forms.TextBox();
            this.txt_expiryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_master = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.tbl_productmain.SuspendLayout();
            this.tlp_producttitle.SuspendLayout();
            this.tbl_productform.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_productmain
            // 
            this.tbl_productmain.ColumnCount = 1;
            this.tbl_productmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_productmain.Controls.Add(this.dgv_master, 0, 3);
            this.tbl_productmain.Controls.Add(this.tlp_producttitle, 0, 0);
            this.tbl_productmain.Controls.Add(this.tbl_productform, 0, 1);
            this.tbl_productmain.Controls.Add(this.lbl_id, 0, 4);
            this.tbl_productmain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tbl_productmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_productmain.Location = new System.Drawing.Point(0, 0);
            this.tbl_productmain.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_productmain.Name = "tbl_productmain";
            this.tbl_productmain.RowCount = 5;
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.23539F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36394F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.38731F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_productmain.Size = new System.Drawing.Size(1057, 621);
            this.tbl_productmain.TabIndex = 0;
            // 
            // tlp_producttitle
            // 
            this.tlp_producttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_producttitle.ColumnCount = 1;
            this.tlp_producttitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_producttitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_producttitle.Controls.Add(this.txt_Details, 0, 0);
            this.tlp_producttitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_producttitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_producttitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_producttitle.Name = "tlp_producttitle";
            this.tlp_producttitle.RowCount = 1;
            this.tlp_producttitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_producttitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlp_producttitle.Size = new System.Drawing.Size(1057, 48);
            this.tlp_producttitle.TabIndex = 0;
            // 
            // txt_Details
            // 
            this.txt_Details.AutoSize = true;
            this.txt_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Details.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Details.ForeColor = System.Drawing.Color.White;
            this.txt_Details.Location = new System.Drawing.Point(3, 0);
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(1051, 48);
            this.txt_Details.TabIndex = 0;
            this.txt_Details.Text = "Purchase Entry";
            this.txt_Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbl_productform
            // 
            this.tbl_productform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_productform.ColumnCount = 4;
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36726F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.43314F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16767F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.03194F));
            this.tbl_productform.Controls.Add(this.label8, 0, 4);
            this.tbl_productform.Controls.Add(this.label7, 0, 5);
            this.tbl_productform.Controls.Add(this.cmb_Category, 1, 1);
            this.tbl_productform.Controls.Add(this.txt_PurchasePrice, 1, 3);
            this.tbl_productform.Controls.Add(this.label1, 0, 3);
            this.tbl_productform.Controls.Add(this.cmb_brand, 3, 2);
            this.tbl_productform.Controls.Add(this.cmb_Party, 1, 2);
            this.tbl_productform.Controls.Add(this.label3, 0, 0);
            this.tbl_productform.Controls.Add(this.cmb_ItemNo, 1, 0);
            this.tbl_productform.Controls.Add(this.label5, 2, 2);
            this.tbl_productform.Controls.Add(this.lbl_price, 2, 3);
            this.tbl_productform.Controls.Add(this.txt_sale_price, 3, 3);
            this.tbl_productform.Controls.Add(this.label6, 0, 2);
            this.tbl_productform.Controls.Add(this.tableLayoutPanel1, 3, 5);
            this.tbl_productform.Controls.Add(this.textBox1, 1, 5);
            this.tbl_productform.Controls.Add(this.txt_product, 3, 0);
            this.tbl_productform.Controls.Add(this.label2, 2, 0);
            this.tbl_productform.Controls.Add(this.label4, 0, 1);
            this.tbl_productform.Controls.Add(this.txt_qty, 3, 1);
            this.tbl_productform.Controls.Add(this.lbl_qty, 2, 1);
            this.tbl_productform.Controls.Add(this.txt_expiryDate, 1, 4);
            this.tbl_productform.Location = new System.Drawing.Point(0, 48);
            this.tbl_productform.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_productform.Name = "tbl_productform";
            this.tbl_productform.RowCount = 6;
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90013F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90013F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90013F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.93975F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.07814F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.28172F));
            this.tbl_productform.Size = new System.Drawing.Size(1057, 247);
            this.tbl_productform.TabIndex = 1;
            // 
            // cmb_Category
            // 
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_Category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(176, 42);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(226, 29);
            this.cmb_Category.TabIndex = 3;
            this.cmb_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PurchasePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_PurchasePrice.Location = new System.Drawing.Point(176, 122);
            this.txt_PurchasePrice.MaxLength = 10;
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.Size = new System.Drawing.Size(194, 29);
            this.txt_PurchasePrice.TabIndex = 7;
            this.txt_PurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txt_PurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Purchase Price :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_brand
            // 
            this.cmb_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_brand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_brand.FormattingEnabled = true;
            this.cmb_brand.Location = new System.Drawing.Point(699, 81);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(226, 29);
            this.cmb_brand.TabIndex = 6;
            this.cmb_brand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cmb_Party
            // 
            this.cmb_Party.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Party.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_Party.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Party.FormattingEnabled = true;
            this.cmb_Party.Location = new System.Drawing.Point(176, 81);
            this.cmb_Party.Name = "cmb_Party";
            this.cmb_Party.Size = new System.Drawing.Size(226, 29);
            this.cmb_Party.TabIndex = 5;
            this.cmb_Party.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item No :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ItemNo
            // 
            this.cmb_ItemNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_ItemNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_ItemNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemNo.FormattingEnabled = true;
            this.cmb_ItemNo.Location = new System.Drawing.Point(176, 3);
            this.cmb_ItemNo.Name = "cmb_ItemNo";
            this.cmb_ItemNo.Size = new System.Drawing.Size(226, 29);
            this.cmb_ItemNo.TabIndex = 1;
            this.cmb_ItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(529, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Brand :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_price.Location = new System.Drawing.Point(529, 126);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(164, 21);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Sales Price :";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sale_price
            // 
            this.txt_sale_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_sale_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sale_price.Location = new System.Drawing.Point(699, 122);
            this.txt_sale_price.MaxLength = 10;
            this.txt_sale_price.Name = "txt_sale_price";
            this.txt_sale_price.Size = new System.Drawing.Size(194, 29);
            this.txt_sale_price.TabIndex = 8;
            this.txt_sale_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txt_sale_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_expiryDate
            // 
            this.txt_expiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_expiryDate.Location = new System.Drawing.Point(176, 163);
            this.txt_expiryDate.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txt_expiryDate.Name = "txt_expiryDate";
            this.txt_expiryDate.ShowCheckBox = true;
            this.txt_expiryDate.Size = new System.Drawing.Size(111, 20);
            this.txt_expiryDate.TabIndex = 9;
            this.txt_expiryDate.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            this.txt_expiryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Party :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02381F));
            this.tableLayoutPanel1.Controls.Add(this.btn_reset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(699, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 44);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(180, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(96, 38);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(94)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(80, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 38);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(71, 38);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_product
            // 
            this.txt_product.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_product.Location = new System.Drawing.Point(699, 5);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(334, 29);
            this.txt_product.TabIndex = 2;
            this.txt_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(4, 599);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 22);
            this.lbl_id.TabIndex = 34;
            this.lbl_id.Text = "lbl_id";
            this.lbl_id.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(529, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_qty.Location = new System.Drawing.Point(699, 44);
            this.txt_qty.MaxLength = 10;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(121, 29);
            this.txt_qty.TabIndex = 4;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_qty.Location = new System.Drawing.Point(529, 48);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(164, 21);
            this.lbl_qty.TabIndex = 9;
            this.lbl_qty.Text = "Qty. :";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(3, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Details :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Expiry Date :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_master
            // 
            this.dgv_master.AllowDrop = true;
            this.dgv_master.AllowUserToAddRows = false;
            this.dgv_master.AllowUserToDeleteRows = false;
            this.dgv_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_master.Location = new System.Drawing.Point(3, 408);
            this.dgv_master.Name = "dgv_master";
            this.dgv_master.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_master.Size = new System.Drawing.Size(1051, 188);
            this.dgv_master.TabIndex = 35;
            this.dgv_master.TabStop = false;
            this.dgv_master.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_master_DataBindingComplete);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82785F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.07544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.31141F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97872F));
            this.tableLayoutPanel2.Controls.Add(this.txt_Search, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_StartDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_EndDate, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_apply, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 298);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.96296F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.40741F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 104);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Start Date :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tableLayoutPanel2.SetColumnSpan(this.label10, 4);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1028, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Search Purchase";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(176, 38);
            this.txt_StartDate.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(127, 20);
            this.txt_StartDate.TabIndex = 10;
            this.txt_StartDate.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(517, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "End Date :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(695, 38);
            this.txt_EndDate.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Size = new System.Drawing.Size(127, 20);
            this.txt_EndDate.TabIndex = 12;
            this.txt_EndDate.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(3, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Item:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.Location = new System.Drawing.Point(695, 73);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(71, 28);
            this.btn_apply.TabIndex = 15;
            this.btn_apply.Text = "APPLY";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbl_productform.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(176, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 44);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Search.Location = new System.Drawing.Point(176, 73);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(334, 29);
            this.txt_Search.TabIndex = 37;
            // 
            // frmSaralPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 621);
            this.Controls.Add(this.tbl_productmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaralPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaralPurchase";
            this.Load += new System.EventHandler(this.frmSaralProduct_Load);
            this.tbl_productmain.ResumeLayout(false);
            this.tlp_producttitle.ResumeLayout(false);
            this.tlp_producttitle.PerformLayout();
            this.tbl_productform.ResumeLayout(false);
            this.tbl_productform.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_productmain;
        private System.Windows.Forms.TableLayoutPanel tlp_producttitle;
        private System.Windows.Forms.Label txt_Details;
        private System.Windows.Forms.TableLayoutPanel tbl_productform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_sale_price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.DateTimePicker txt_expiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Party;
        private System.Windows.Forms.ComboBox cmb_brand;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_ItemNo;
        private System.Windows.Forms.TextBox txt_PurchasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_master;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txt_StartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txt_EndDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Search;
}

}