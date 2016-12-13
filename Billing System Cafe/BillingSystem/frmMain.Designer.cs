namespace BillingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.labelCompany = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnGClose = new System.Windows.Forms.Button();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.tlp_footer = new System.Windows.Forms.TableLayoutPanel();
            this.p_footer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tlp_footer.SuspendLayout();
            this.p_footer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.ForeColor = System.Drawing.Color.White;
            this.labelCompany.Location = new System.Drawing.Point(12, 7);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(60, 37);
            this.labelCompany.TabIndex = 5;
            this.labelCompany.Text = "n/a";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCustomer,
            this.productToolStripMenuItem,
            this.taxToolStripMenuItem,
            this.MenuInvoice,
            this.toolStripSeparator4,
            this.settingToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCustomer
            // 
            this.MenuCustomer.Image = ((System.Drawing.Image)(resources.GetObject("MenuCustomer.Image")));
            this.MenuCustomer.Name = "MenuCustomer";
            this.MenuCustomer.Size = new System.Drawing.Size(87, 23);
            this.MenuCustomer.Text = "Customer";
            this.MenuCustomer.Click += new System.EventHandler(this.MenuCustomer_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Image = global::BillingSystem.Properties.Resources.Product1;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // taxToolStripMenuItem
            // 
            this.taxToolStripMenuItem.Image = global::BillingSystem.Properties.Resources.Tax;
            this.taxToolStripMenuItem.Name = "taxToolStripMenuItem";
            this.taxToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.taxToolStripMenuItem.Text = "Tax";
            this.taxToolStripMenuItem.Visible = false;
            this.taxToolStripMenuItem.Click += new System.EventHandler(this.taxToolStripMenuItem_Click);
            // 
            // MenuInvoice
            // 
            this.MenuInvoice.Image = global::BillingSystem.Properties.Resources.SaveM;
            this.MenuInvoice.Name = "MenuInvoice";
            this.MenuInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.MenuInvoice.Size = new System.Drawing.Size(73, 23);
            this.MenuInvoice.Text = "&Invoice";
            this.MenuInvoice.Click += new System.EventHandler(this.MenuInvoice_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.settingToolStripMenuItem.Text = "&Setting";
            this.settingToolStripMenuItem.Visible = false;
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BillingSystem.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 28);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.labelCompany);
            this.panel3.Controls.Add(this.btnminimize);
            this.panel3.Controls.Add(this.btnGClose);
            this.panel3.Controls.Add(this.lblCompanyAddress);
            this.panel3.Controls.Add(this.lblCompanyPhone);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 79);
            this.panel3.TabIndex = 23;
            // 
            // btnminimize
            // 
            this.btnminimize.AllowDrop = true;
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackgroundImage = global::BillingSystem.Properties.Resources.minus;
            this.btnminimize.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.Black;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnminimize.Location = new System.Drawing.Point(1128, 7);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(27, 23);
            this.btnminimize.TabIndex = 22;
            this.btnminimize.Text = "-";
            this.btnminimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Visible = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnGClose
            // 
            this.btnGClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGClose.BackColor = System.Drawing.Color.White;
            this.btnGClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGClose.Image = global::BillingSystem.Properties.Resources.close;
            this.btnGClose.Location = new System.Drawing.Point(1164, 7);
            this.btnGClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnGClose.Name = "btnGClose";
            this.btnGClose.Size = new System.Drawing.Size(27, 23);
            this.btnGClose.TabIndex = 0;
            this.btnGClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGClose.UseVisualStyleBackColor = false;
            this.btnGClose.Click += new System.EventHandler(this.btnGClose_Click);
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddress.Location = new System.Drawing.Point(19, 53);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(29, 17);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "n/a";
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyPhone.Location = new System.Drawing.Point(974, 49);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(37, 23);
            this.lblCompanyPhone.TabIndex = 0;
            this.lblCompanyPhone.Text = "n/a";
            // 
            // tlp_footer
            // 
            this.tlp_footer.ColumnCount = 3;
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_footer.Controls.Add(this.p_footer, 1, 0);
            this.tlp_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_footer.Location = new System.Drawing.Point(0, 663);
            this.tlp_footer.Name = "tlp_footer";
            this.tlp_footer.RowCount = 1;
            this.tlp_footer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_footer.Size = new System.Drawing.Size(1200, 37);
            this.tlp_footer.TabIndex = 27;
            // 
            // p_footer
            // 
            this.p_footer.Controls.Add(this.panel4);
            this.p_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_footer.Location = new System.Drawing.Point(123, 3);
            this.p_footer.Name = "p_footer";
            this.p_footer.Size = new System.Drawing.Size(954, 45);
            this.p_footer.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 45);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(204, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "All rights reserved.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(53, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "SUHRADAM SOFTWARE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "© 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tlp_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "n/a";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tlp_footer.ResumeLayout(false);
            this.p_footer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGClose;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tlp_footer;
        private System.Windows.Forms.Panel p_footer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MenuCustomer;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxToolStripMenuItem;
    }
}