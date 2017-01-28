namespace SaralStockManagement
{
    partial class frmSaralProduct
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
            this.tbl_productmain = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_producttitle = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_productform = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_sale_price = new System.Windows.Forms.TextBox();
            this.txt_expiredate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbl_productmain.SuspendLayout();
            this.tlp_producttitle.SuspendLayout();
            this.tbl_productform.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_productmain
            // 
            this.tbl_productmain.ColumnCount = 1;
            this.tbl_productmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_productmain.Controls.Add(this.tlp_producttitle, 0, 0);
            this.tbl_productmain.Controls.Add(this.tbl_productform, 0, 1);
            this.tbl_productmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_productmain.Location = new System.Drawing.Point(0, 0);
            this.tbl_productmain.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_productmain.Name = "tbl_productmain";
            this.tbl_productmain.RowCount = 3;
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tbl_productmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tbl_productmain.Size = new System.Drawing.Size(1000, 510);
            this.tbl_productmain.TabIndex = 0;
            // 
            // tlp_producttitle
            // 
            this.tlp_producttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_producttitle.ColumnCount = 1;
            this.tlp_producttitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_producttitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_producttitle.Controls.Add(this.label1, 0, 0);
            this.tlp_producttitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_producttitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_producttitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_producttitle.Name = "tlp_producttitle";
            this.tlp_producttitle.RowCount = 1;
            this.tlp_producttitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_producttitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_producttitle.Size = new System.Drawing.Size(1000, 40);
            this.tlp_producttitle.TabIndex = 0;
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
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbl_productform
            // 
            this.tbl_productform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_productform.ColumnCount = 4;
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2F));
            this.tbl_productform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.1F));
            this.tbl_productform.Controls.Add(this.txt_product, 3, 0);
            this.tbl_productform.Controls.Add(this.label2, 2, 0);
            this.tbl_productform.Controls.Add(this.txt_itemno, 1, 0);
            this.tbl_productform.Controls.Add(this.label3, 0, 0);
            this.tbl_productform.Controls.Add(this.label4, 0, 1);
            this.tbl_productform.Controls.Add(this.txt_category, 1, 1);
            this.tbl_productform.Controls.Add(this.label5, 2, 1);
            this.tbl_productform.Controls.Add(this.txt_company, 3, 1);
            this.tbl_productform.Controls.Add(this.lbl_qty, 0, 2);
            this.tbl_productform.Controls.Add(this.txt_qty, 1, 2);
            this.tbl_productform.Controls.Add(this.lbl_price, 2, 2);
            this.tbl_productform.Controls.Add(this.txt_sale_price, 3, 2);
            this.tbl_productform.Controls.Add(this.txt_expiredate, 1, 3);
            this.tbl_productform.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tbl_productform.Controls.Add(this.label8, 0, 3);
            this.tbl_productform.Location = new System.Drawing.Point(0, 40);
            this.tbl_productform.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_productform.Name = "tbl_productform";
            this.tbl_productform.RowCount = 4;
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.34061F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.21397F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65066F));
            this.tbl_productform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.66812F));
            this.tbl_productform.Size = new System.Drawing.Size(1000, 229);
            this.tbl_productform.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(3, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Expire Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product
            // 
            this.txt_product.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_product.Location = new System.Drawing.Point(658, 6);
            this.txt_product.Margin = new System.Windows.Forms.Padding(0);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(342, 29);
            this.txt_product.TabIndex = 3;
            this.txt_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(500, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_itemno
            // 
            this.txt_itemno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_itemno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_itemno.Location = new System.Drawing.Point(163, 6);
            this.txt_itemno.Margin = new System.Windows.Forms.Padding(0);
            this.txt_itemno.Name = "txt_itemno";
            this.txt_itemno.Size = new System.Drawing.Size(334, 29);
            this.txt_itemno.TabIndex = 1;
            this.txt_itemno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemno_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_category
            // 
            this.txt_category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_category.Location = new System.Drawing.Point(163, 48);
            this.txt_category.Margin = new System.Windows.Forms.Padding(0);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(334, 29);
            this.txt_category.TabIndex = 6;
            this.txt_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_category_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(500, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_company
            // 
            this.txt_company.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_company.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_company.Location = new System.Drawing.Point(658, 48);
            this.txt_company.Margin = new System.Windows.Forms.Padding(0);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(342, 29);
            this.txt_company.TabIndex = 8;
            this.txt_company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_company_KeyDown);
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_qty.Location = new System.Drawing.Point(3, 95);
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
            this.txt_qty.Location = new System.Drawing.Point(163, 91);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(334, 29);
            this.txt_qty.TabIndex = 10;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_price.Location = new System.Drawing.Point(500, 95);
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
            this.txt_sale_price.Location = new System.Drawing.Point(658, 91);
            this.txt_sale_price.Margin = new System.Windows.Forms.Padding(0);
            this.txt_sale_price.Name = "txt_sale_price";
            this.txt_sale_price.Size = new System.Drawing.Size(339, 29);
            this.txt_sale_price.TabIndex = 12;
            this.txt_sale_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sale_price_KeyDown);
            // 
            // txt_expiredate
            // 
            this.txt_expiredate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_expiredate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_expiredate.Location = new System.Drawing.Point(163, 128);
            this.txt_expiredate.Margin = new System.Windows.Forms.Padding(0);
            this.txt_expiredate.Name = "txt_expiredate";
            this.txt_expiredate.Size = new System.Drawing.Size(334, 29);
            this.txt_expiredate.TabIndex = 14;
            this.txt_expiredate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_expiredate_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02381F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(661, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 95);
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
            this.button1.TabIndex = 0;
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
            this.button2.TabIndex = 1;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmSaralProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.tbl_productmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaralProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSaralPurchase";
            this.tbl_productmain.ResumeLayout(false);
            this.tlp_producttitle.ResumeLayout(false);
            this.tlp_producttitle.PerformLayout();
            this.tbl_productform.ResumeLayout(false);
            this.tbl_productform.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_productmain;
        private System.Windows.Forms.TableLayoutPanel tlp_producttitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbl_productform;
        private System.Windows.Forms.TextBox txt_itemno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_sale_price;
        private System.Windows.Forms.TextBox txt_expiredate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
}

}