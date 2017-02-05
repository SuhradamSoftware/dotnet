namespace BillingSystem
{
    partial class BillGeneration
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
            this.tlp_billmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_billform = new System.Windows.Forms.TableLayoutPanel();
            this.txt_billdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.lbl_billno = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.tlp_price = new System.Windows.Forms.TableLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_sale_price = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.tlp_billtitle = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_total = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_Tax1 = new System.Windows.Forms.Label();
            this.lbl_tax2 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.txt_Tax1 = new System.Windows.Forms.TextBox();
            this.txt_Tax2 = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.TextBox();
            this.txt_Cust_Phone = new System.Windows.Forms.TextBox();
            this.tlp_billmain.SuspendLayout();
            this.tbl_billform.SuspendLayout();
            this.tlp_price.SuspendLayout();
            this.tlp_billtitle.SuspendLayout();
            this.tlp_total.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_billmain
            // 
            this.tlp_billmain.ColumnCount = 1;
            this.tlp_billmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_billmain.Controls.Add(this.tbl_billform, 0, 1);
            this.tlp_billmain.Controls.Add(this.tlp_billtitle, 0, 0);
            this.tlp_billmain.Controls.Add(this.tlp_total, 0, 3);
            this.tlp_billmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_billmain.Location = new System.Drawing.Point(0, 0);
            this.tlp_billmain.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_billmain.Name = "tlp_billmain";
            this.tlp_billmain.RowCount = 4;
            this.tlp_billmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_billmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlp_billmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.92105F));
            this.tlp_billmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.30921F));
            this.tlp_billmain.Size = new System.Drawing.Size(1057, 621);
            this.tlp_billmain.TabIndex = 0;
            // 
            // tbl_billform
            // 
            this.tbl_billform.ColumnCount = 4;
            this.tbl_billform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36616F));
            this.tbl_billform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.43088F));
            this.tbl_billform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.7362F));
            this.tbl_billform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.6728F));
            this.tbl_billform.Controls.Add(this.txt_billdate, 3, 0);
            this.tbl_billform.Controls.Add(this.label2, 2, 0);
            this.tbl_billform.Controls.Add(this.txt_billno, 1, 0);
            this.tbl_billform.Controls.Add(this.lbl_billno, 0, 0);
            this.tbl_billform.Controls.Add(this.lbl_itemname, 0, 1);
            this.tbl_billform.Controls.Add(this.lbl_qty, 2, 1);
            this.tbl_billform.Controls.Add(this.tlp_price, 3, 1);
            this.tbl_billform.Controls.Add(this.cmbProduct, 1, 1);
            this.tbl_billform.Location = new System.Drawing.Point(0, 49);
            this.tbl_billform.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_billform.Name = "tbl_billform";
            this.tbl_billform.RowCount = 2;
            this.tbl_billform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_billform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_billform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_billform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_billform.Size = new System.Drawing.Size(978, 105);
            this.tbl_billform.TabIndex = 2;
            // 
            // txt_billdate
            // 
            this.txt_billdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_billdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_billdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_billdate.Location = new System.Drawing.Point(589, 11);
            this.txt_billdate.Margin = new System.Windows.Forms.Padding(0);
            this.txt_billdate.Name = "txt_billdate";
            this.txt_billdate.Size = new System.Drawing.Size(389, 29);
            this.txt_billdate.TabIndex = 2;
            this.txt_billdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billdate_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(488, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_billno
            // 
            this.txt_billno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_billno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_billno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_billno.Location = new System.Drawing.Point(159, 11);
            this.txt_billno.Margin = new System.Windows.Forms.Padding(0);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(326, 29);
            this.txt_billno.TabIndex = 1;
            this.txt_billno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billno_KeyDown);
            // 
            // lbl_billno
            // 
            this.lbl_billno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_billno.AutoSize = true;
            this.lbl_billno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_billno.Location = new System.Drawing.Point(3, 15);
            this.lbl_billno.Name = "lbl_billno";
            this.lbl_billno.Size = new System.Drawing.Size(153, 21);
            this.lbl_billno.TabIndex = 4;
            this.lbl_billno.Text = "Bill No";
            this.lbl_billno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_itemname.Location = new System.Drawing.Point(3, 68);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(153, 21);
            this.lbl_itemname.TabIndex = 5;
            this.lbl_itemname.Text = "Item Name";
            this.lbl_itemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_qty.Location = new System.Drawing.Point(488, 68);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(98, 21);
            this.lbl_qty.TabIndex = 9;
            this.lbl_qty.Text = "Qty";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_price
            // 
            this.tlp_price.ColumnCount = 4;
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29268F));
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.46342F));
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_price.Controls.Add(this.btn_add, 3, 0);
            this.tlp_price.Controls.Add(this.txt_qty, 0, 0);
            this.tlp_price.Controls.Add(this.lbl_price, 1, 0);
            this.tlp_price.Controls.Add(this.txt_sale_price, 2, 0);
            this.tlp_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_price.Location = new System.Drawing.Point(589, 52);
            this.tlp_price.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_price.Name = "tlp_price";
            this.tlp_price.RowCount = 1;
            this.tlp_price.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_price.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlp_price.Size = new System.Drawing.Size(389, 53);
            this.tlp_price.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(293, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 33);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "+ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_qty.Location = new System.Drawing.Point(0, 12);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(73, 29);
            this.txt_qty.TabIndex = 4;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_price.Location = new System.Drawing.Point(100, 16);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(65, 21);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sale_price
            // 
            this.txt_sale_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_sale_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sale_price.Location = new System.Drawing.Point(168, 12);
            this.txt_sale_price.Margin = new System.Windows.Forms.Padding(0);
            this.txt_sale_price.Name = "txt_sale_price";
            this.txt_sale_price.Size = new System.Drawing.Size(98, 29);
            this.txt_sale_price.TabIndex = 5;
            this.txt_sale_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sale_price_KeyDown);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(162, 64);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(320, 29);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // tlp_billtitle
            // 
            this.tlp_billtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_billtitle.ColumnCount = 1;
            this.tlp_billtitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_billtitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_billtitle.Controls.Add(this.label1, 0, 0);
            this.tlp_billtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_billtitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_billtitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_billtitle.Name = "tlp_billtitle";
            this.tlp_billtitle.RowCount = 1;
            this.tlp_billtitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_billtitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlp_billtitle.Size = new System.Drawing.Size(1057, 49);
            this.tlp_billtitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1051, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_total
            // 
            this.tlp_total.ColumnCount = 2;
            this.tlp_total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_total.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlp_total.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlp_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_total.Location = new System.Drawing.Point(3, 379);
            this.tlp_total.Name = "tlp_total";
            this.tlp_total.RowCount = 1;
            this.tlp_total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_total.Size = new System.Drawing.Size(1051, 239);
            this.tlp_total.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_subtotal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Tax1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tax2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_discount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_discount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_SubTotal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Tax1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Tax2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_TotalAmount, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(528, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.514389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.947368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.96491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.18215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.626226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.73806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.41508F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 233);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_subtotal.Location = new System.Drawing.Point(3, 19);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(254, 21);
            this.lbl_subtotal.TabIndex = 10;
            this.lbl_subtotal.Text = "Total";
            this.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Tax1
            // 
            this.lbl_Tax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tax1.AutoSize = true;
            this.lbl_Tax1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tax1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_Tax1.Location = new System.Drawing.Point(3, 46);
            this.lbl_Tax1.Name = "lbl_Tax1";
            this.lbl_Tax1.Size = new System.Drawing.Size(254, 17);
            this.lbl_Tax1.TabIndex = 11;
            this.lbl_Tax1.Text = "Tax1";
            this.lbl_Tax1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tax2
            // 
            this.lbl_tax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tax2.AutoSize = true;
            this.lbl_tax2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_tax2.Location = new System.Drawing.Point(3, 69);
            this.lbl_tax2.Name = "lbl_tax2";
            this.lbl_tax2.Size = new System.Drawing.Size(254, 17);
            this.lbl_tax2.TabIndex = 12;
            this.lbl_tax2.Text = "Tax2";
            this.lbl_tax2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_discount.Location = new System.Drawing.Point(3, 91);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(254, 21);
            this.lbl_discount.TabIndex = 13;
            this.lbl_discount.Text = "Discount";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(3, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Grand Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(263, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_discount.Location = new System.Drawing.Point(260, 88);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(0);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(123, 29);
            this.txt_discount.TabIndex = 9;
            this.txt_discount.Text = "0";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_SubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txt_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SubTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SubTotal.ForeColor = System.Drawing.Color.Black;
            this.txt_SubTotal.Location = new System.Drawing.Point(260, 18);
            this.txt_SubTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.Size = new System.Drawing.Size(123, 22);
            this.txt_SubTotal.TabIndex = 21;
            this.txt_SubTotal.TabStop = false;
            this.txt_SubTotal.Text = "0.0";
            // 
            // txt_Tax1
            // 
            this.txt_Tax1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Tax1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txt_Tax1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tax1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Tax1.Location = new System.Drawing.Point(260, 46);
            this.txt_Tax1.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Tax1.Name = "txt_Tax1";
            this.txt_Tax1.Size = new System.Drawing.Size(123, 18);
            this.txt_Tax1.TabIndex = 22;
            this.txt_Tax1.TabStop = false;
            this.txt_Tax1.Text = "0.0";
            // 
            // txt_Tax2
            // 
            this.txt_Tax2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Tax2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txt_Tax2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tax2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_Tax2.Location = new System.Drawing.Point(260, 69);
            this.txt_Tax2.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Tax2.Name = "txt_Tax2";
            this.txt_Tax2.Size = new System.Drawing.Size(123, 18);
            this.txt_Tax2.TabIndex = 23;
            this.txt_Tax2.TabStop = false;
            this.txt_Tax2.Text = "0.0";
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txt_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_TotalAmount.Location = new System.Drawing.Point(260, 121);
            this.txt_TotalAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(123, 22);
            this.txt_TotalAmount.TabIndex = 24;
            this.txt_TotalAmount.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41666F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbCustomer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Cust_Phone, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.96815F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24204F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.78981F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 233);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mobile No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCustomer.Location = new System.Drawing.Point(153, 2);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(338, 29);
            this.cmbCustomer.TabIndex = 7;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // txt_Cust_Phone
            // 
            this.txt_Cust_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Cust_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cust_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Cust_Phone.Location = new System.Drawing.Point(153, 38);
            this.txt_Cust_Phone.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Cust_Phone.Name = "txt_Cust_Phone";
            this.txt_Cust_Phone.Size = new System.Drawing.Size(337, 29);
            this.txt_Cust_Phone.TabIndex = 8;
            this.txt_Cust_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cust_Phone_KeyDown);
            // 
            // BillGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 621);
            this.Controls.Add(this.tlp_billmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSaralBill";
            this.Load += new System.EventHandler(this.frmSaralBill_Load);
            this.tlp_billmain.ResumeLayout(false);
            this.tbl_billform.ResumeLayout(false);
            this.tbl_billform.PerformLayout();
            this.tlp_price.ResumeLayout(false);
            this.tlp_price.PerformLayout();
            this.tlp_billtitle.ResumeLayout(false);
            this.tlp_billtitle.PerformLayout();
            this.tlp_total.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_billmain;
        private System.Windows.Forms.TableLayoutPanel tlp_billtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbl_billform;
        private System.Windows.Forms.TextBox txt_billdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label lbl_billno;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_sale_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TableLayoutPanel tlp_price;
        private System.Windows.Forms.TableLayoutPanel tlp_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cmbCustomer;
        private System.Windows.Forms.TextBox txt_Cust_Phone;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_Tax1;
        private System.Windows.Forms.Label lbl_tax2;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.TextBox txt_Tax1;
        private System.Windows.Forms.TextBox txt_Tax2;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.ComboBox cmbProduct;

   

    }
}