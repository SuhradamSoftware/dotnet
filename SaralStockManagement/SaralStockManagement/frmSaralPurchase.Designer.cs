namespace SaralStockManagement
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
            this.tlp_purchasemain = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_purchasetitle = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_purchaseform = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_expirydate = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.txt_itemno = new System.Windows.Forms.TextBox();
            this.lbl_productno = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_sale_price = new System.Windows.Forms.TextBox();
            this.txt_expiredate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tlp_purchasemain.SuspendLayout();
            this.tlp_purchasetitle.SuspendLayout();
            this.tbl_purchaseform.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_purchasemain
            // 
            this.tlp_purchasemain.ColumnCount = 1;
            this.tlp_purchasemain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_purchasemain.Controls.Add(this.tlp_purchasetitle, 0, 0);
            this.tlp_purchasemain.Controls.Add(this.tbl_purchaseform, 0, 1);
            this.tlp_purchasemain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_purchasemain.Location = new System.Drawing.Point(0, 0);
            this.tlp_purchasemain.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_purchasemain.Name = "tlp_purchasemain";
            this.tlp_purchasemain.RowCount = 3;
            this.tlp_purchasemain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_purchasemain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_purchasemain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tlp_purchasemain.Size = new System.Drawing.Size(1000, 510);
            this.tlp_purchasemain.TabIndex = 0;
            // 
            // tlp_purchasetitle
            // 
            this.tlp_purchasetitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_purchasetitle.ColumnCount = 1;
            this.tlp_purchasetitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_purchasetitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_purchasetitle.Controls.Add(this.label1, 0, 0);
            this.tlp_purchasetitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_purchasetitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_purchasetitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_purchasetitle.Name = "tlp_purchasetitle";
            this.tlp_purchasetitle.RowCount = 1;
            this.tlp_purchasetitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_purchasetitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_purchasetitle.Size = new System.Drawing.Size(1000, 40);
            this.tlp_purchasetitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbl_purchaseform
            // 
            this.tbl_purchaseform.ColumnCount = 4;
            this.tbl_purchaseform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4F));
            this.tbl_purchaseform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5F));
            this.tbl_purchaseform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2F));
            this.tbl_purchaseform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.1F));
            this.tbl_purchaseform.Controls.Add(this.lbl_expirydate, 0, 3);
            this.tbl_purchaseform.Controls.Add(this.txt_product, 3, 0);
            this.tbl_purchaseform.Controls.Add(this.lbl_productname, 2, 0);
            this.tbl_purchaseform.Controls.Add(this.txt_itemno, 1, 0);
            this.tbl_purchaseform.Controls.Add(this.lbl_productno, 0, 0);
            this.tbl_purchaseform.Controls.Add(this.lbl_category, 0, 1);
            this.tbl_purchaseform.Controls.Add(this.txt_category, 1, 1);
            this.tbl_purchaseform.Controls.Add(this.lbl_company, 2, 1);
            this.tbl_purchaseform.Controls.Add(this.txt_company, 3, 1);
            this.tbl_purchaseform.Controls.Add(this.lbl_qty, 0, 2);
            this.tbl_purchaseform.Controls.Add(this.txt_qty, 1, 2);
            this.tbl_purchaseform.Controls.Add(this.lbl_price, 2, 2);
            this.tbl_purchaseform.Controls.Add(this.txt_sale_price, 3, 2);
            this.tbl_purchaseform.Controls.Add(this.txt_expiredate, 1, 3);
            this.tbl_purchaseform.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tbl_purchaseform.Location = new System.Drawing.Point(0, 40);
            this.tbl_purchaseform.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_purchaseform.Name = "tbl_purchaseform";
            this.tbl_purchaseform.RowCount = 4;
            this.tbl_purchaseform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_purchaseform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_purchaseform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_purchaseform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_purchaseform.Size = new System.Drawing.Size(1000, 229);
            this.tbl_purchaseform.TabIndex = 1;
            // 
            // lbl_expirydate
            // 
            this.lbl_expirydate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_expirydate.AutoSize = true;
            this.lbl_expirydate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expirydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_expirydate.Location = new System.Drawing.Point(3, 189);
            this.lbl_expirydate.Name = "lbl_expirydate";
            this.lbl_expirydate.Size = new System.Drawing.Size(157, 21);
            this.lbl_expirydate.TabIndex = 13;
            this.lbl_expirydate.Text = "Expire Date";
            this.lbl_expirydate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product
            // 
            this.txt_product.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_product.Location = new System.Drawing.Point(658, 14);
            this.txt_product.Margin = new System.Windows.Forms.Padding(0);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(342, 29);
            this.txt_product.TabIndex = 2;
            this.txt_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyDown);
            // 
            // lbl_productname
            // 
            this.lbl_productname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_productname.Location = new System.Drawing.Point(500, 18);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(155, 21);
            this.lbl_productname.TabIndex = 2;
            this.lbl_productname.Text = "Item Name";
            this.lbl_productname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_itemno
            // 
            this.txt_itemno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_itemno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_itemno.Location = new System.Drawing.Point(163, 14);
            this.txt_itemno.Margin = new System.Windows.Forms.Padding(0);
            this.txt_itemno.Name = "txt_itemno";
            this.txt_itemno.Size = new System.Drawing.Size(334, 29);
            this.txt_itemno.TabIndex = 1;

            this.txt_itemno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemno_KeyDown);
            // 
            // lbl_productno
            // 
            this.lbl_productno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_productno.AutoSize = true;
            this.lbl_productno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_productno.Location = new System.Drawing.Point(3, 18);
            this.lbl_productno.Name = "lbl_productno";
            this.lbl_productno.Size = new System.Drawing.Size(157, 21);
            this.lbl_productno.TabIndex = 4;
            this.lbl_productno.Text = "Item No";
            this.lbl_productno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_category.Location = new System.Drawing.Point(3, 75);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(157, 21);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_category
            // 
            this.txt_category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_category.Location = new System.Drawing.Point(163, 71);
            this.txt_category.Margin = new System.Windows.Forms.Padding(0);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(334, 29);
            this.txt_category.TabIndex = 3;
            this.txt_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_category_KeyDown);
            // 
            // lbl_company
            // 
            this.lbl_company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_company.AutoSize = true;
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_company.Location = new System.Drawing.Point(500, 75);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(155, 21);
            this.lbl_company.TabIndex = 7;
            this.lbl_company.Text = "Company";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_company
            // 
            this.txt_company.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_company.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_company.Location = new System.Drawing.Point(658, 71);
            this.txt_company.Margin = new System.Windows.Forms.Padding(0);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(342, 29);
            this.txt_company.TabIndex = 4;
            this.txt_company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_company_KeyDown);
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_qty.Location = new System.Drawing.Point(3, 132);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(157, 21);
            this.lbl_qty.TabIndex = 9;
            this.lbl_qty.Text = "Qty";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_qty.Location = new System.Drawing.Point(163, 128);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(334, 29);
            this.txt_qty.TabIndex = 5;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_price.Location = new System.Drawing.Point(500, 132);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(155, 21);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sale_price
            // 
            this.txt_sale_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_sale_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sale_price.Location = new System.Drawing.Point(658, 128);
            this.txt_sale_price.Margin = new System.Windows.Forms.Padding(0);
            this.txt_sale_price.Name = "txt_sale_price";
            this.txt_sale_price.Size = new System.Drawing.Size(339, 29);
            this.txt_sale_price.TabIndex = 6;
            this.txt_sale_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sale_price_KeyDown);
            // 
            // txt_expiredate
            // 
            this.txt_expiredate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_expiredate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_expiredate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_expiredate.Location = new System.Drawing.Point(163, 185);
            this.txt_expiredate.Margin = new System.Windows.Forms.Padding(0);
            this.txt_expiredate.Name = "txt_expiredate";
            this.txt_expiredate.Size = new System.Drawing.Size(334, 29);
            this.txt_expiredate.TabIndex = 7;
            this.txt_expiredate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_expiredate_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02381F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(661, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 52);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(80, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmSaralPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.tlp_purchasemain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaralPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSaralPurchase";
            this.Load += new System.EventHandler(this.frmSaralPurchase_Load);
            this.tlp_purchasemain.ResumeLayout(false);
            this.tlp_purchasetitle.ResumeLayout(false);
            this.tlp_purchasetitle.PerformLayout();
            this.tbl_purchaseform.ResumeLayout(false);
            this.tbl_purchaseform.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_purchasemain;
        private System.Windows.Forms.TableLayoutPanel tlp_purchasetitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbl_purchaseform;
        private System.Windows.Forms.TextBox txt_itemno;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label lbl_productno;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_expirydate;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_sale_price;
        private System.Windows.Forms.TextBox txt_expiredate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}