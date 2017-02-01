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
            this.maintitlepanel = new System.Windows.Forms.Panel();
            this.labelCompany = new System.Windows.Forms.Label();
            this.menutitlepanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkBillMenu = new System.Windows.Forms.LinkLabel();
            this.linkPurchase = new System.Windows.Forms.LinkLabel();
            this.linkProductMenu = new System.Windows.Forms.LinkLabel();
            this.minIcon = new System.Windows.Forms.PictureBox();
            this.maxIcon = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.tlp_footer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maintitlepanel.SuspendLayout();
            this.menutitlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.buttonpanel.SuspendLayout();
            this.tlp_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintitlepanel
            // 
            this.maintitlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.maintitlepanel.Controls.Add(this.labelCompany);
            this.maintitlepanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintitlepanel.ForeColor = System.Drawing.Color.White;
            this.maintitlepanel.Location = new System.Drawing.Point(0, -1);
            this.maintitlepanel.Name = "maintitlepanel";
            this.maintitlepanel.Size = new System.Drawing.Size(352, 48);
            this.maintitlepanel.TabIndex = 0;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(34, 9);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(176, 30);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = " Company Name";
            // 
            // menutitlepanel
            // 
            this.menutitlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.menutitlepanel.Controls.Add(this.linkLabel1);
            this.menutitlepanel.Controls.Add(this.linkBillMenu);
            this.menutitlepanel.Controls.Add(this.linkPurchase);
            this.menutitlepanel.Controls.Add(this.linkProductMenu);
            this.menutitlepanel.Location = new System.Drawing.Point(352, 0);
            this.menutitlepanel.Name = "menutitlepanel";
            this.menutitlepanel.Size = new System.Drawing.Size(703, 47);
            this.menutitlepanel.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Location = new System.Drawing.Point(299, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Settings";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkBillMenu
            // 
            this.linkBillMenu.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.linkBillMenu.AutoSize = true;
            this.linkBillMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBillMenu.ForeColor = System.Drawing.Color.White;
            this.linkBillMenu.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBillMenu.LinkColor = System.Drawing.SystemColors.Window;
            this.linkBillMenu.Location = new System.Drawing.Point(242, 15);
            this.linkBillMenu.Name = "linkBillMenu";
            this.linkBillMenu.Size = new System.Drawing.Size(31, 21);
            this.linkBillMenu.TabIndex = 3;
            this.linkBillMenu.TabStop = true;
            this.linkBillMenu.Text = "Bill";
            this.linkBillMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBillMenu_LinkClicked);
            // 
            // linkPurchase
            // 
            this.linkPurchase.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.linkPurchase.AutoSize = true;
            this.linkPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPurchase.ForeColor = System.Drawing.Color.White;
            this.linkPurchase.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPurchase.LinkColor = System.Drawing.SystemColors.Window;
            this.linkPurchase.Location = new System.Drawing.Point(132, 15);
            this.linkPurchase.Name = "linkPurchase";
            this.linkPurchase.Size = new System.Drawing.Size(73, 21);
            this.linkPurchase.TabIndex = 2;
            this.linkPurchase.TabStop = true;
            this.linkPurchase.Text = "Purchase";
            this.linkPurchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCustomerMenu_LinkClicked);
            // 
            // linkProductMenu
            // 
            this.linkProductMenu.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.linkProductMenu.AutoSize = true;
            this.linkProductMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProductMenu.ForeColor = System.Drawing.Color.White;
            this.linkProductMenu.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkProductMenu.LinkColor = System.Drawing.SystemColors.Window;
            this.linkProductMenu.Location = new System.Drawing.Point(31, 15);
            this.linkProductMenu.Name = "linkProductMenu";
            this.linkProductMenu.Size = new System.Drawing.Size(71, 21);
            this.linkProductMenu.TabIndex = 1;
            this.linkProductMenu.TabStop = true;
            this.linkProductMenu.Text = "Products";
            this.linkProductMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProductMenu_LinkClicked);
            // 
            // minIcon
            // 
            this.minIcon.Image = ((System.Drawing.Image)(resources.GetObject("minIcon.Image")));
            this.minIcon.Location = new System.Drawing.Point(3, 0);
            this.minIcon.Name = "minIcon";
            this.minIcon.Size = new System.Drawing.Size(48, 48);
            this.minIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minIcon.TabIndex = 2;
            this.minIcon.TabStop = false;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            // 
            // maxIcon
            // 
            this.maxIcon.Image = ((System.Drawing.Image)(resources.GetObject("maxIcon.Image")));
            this.maxIcon.Location = new System.Drawing.Point(52, 0);
            this.maxIcon.Name = "maxIcon";
            this.maxIcon.Size = new System.Drawing.Size(49, 48);
            this.maxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxIcon.TabIndex = 2;
            this.maxIcon.TabStop = false;
            this.maxIcon.Click += new System.EventHandler(this.maxIcon_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(102, 0);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(48, 48);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // buttonpanel
            // 
            this.buttonpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.buttonpanel.Controls.Add(this.closeIcon);
            this.buttonpanel.Controls.Add(this.maxIcon);
            this.buttonpanel.Controls.Add(this.minIcon);
            this.buttonpanel.Location = new System.Drawing.Point(1048, 0);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(150, 47);
            this.buttonpanel.TabIndex = 3;
            // 
            // tlp_footer
            // 
            this.tlp_footer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlp_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.tlp_footer.Controls.Add(this.label1);
            this.tlp_footer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp_footer.ForeColor = System.Drawing.Color.White;
            this.tlp_footer.Location = new System.Drawing.Point(0, 670);
            this.tlp_footer.Name = "tlp_footer";
            this.tlp_footer.Size = new System.Drawing.Size(1198, 29);
            this.tlp_footer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "@ 2017 Suhradam Software. All rights reserved.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tlp_footer);
            this.Controls.Add(this.buttonpanel);
            this.Controls.Add(this.menutitlepanel);
            this.Controls.Add(this.maintitlepanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(60, 20);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simple Billing System";
            this.Load += new System.EventHandler(this.frmGBSMain_Load);
            this.maintitlepanel.ResumeLayout(false);
            this.maintitlepanel.PerformLayout();
            this.menutitlepanel.ResumeLayout(false);
            this.menutitlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.buttonpanel.ResumeLayout(false);
            this.tlp_footer.ResumeLayout(false);
            this.tlp_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel maintitlepanel;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Panel menutitlepanel;
        private System.Windows.Forms.LinkLabel linkProductMenu;
        private System.Windows.Forms.LinkLabel linkPurchase;
        private System.Windows.Forms.LinkLabel linkBillMenu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox minIcon;
        private System.Windows.Forms.PictureBox maxIcon;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel tlp_footer;
        private System.Windows.Forms.Label label1;
    }
}