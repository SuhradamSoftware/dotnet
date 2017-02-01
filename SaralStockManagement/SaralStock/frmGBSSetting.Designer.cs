namespace BillingSystem
{
    partial class frmGBSSetting
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
            this.productTitlePanel = new System.Windows.Forms.Panel();
            this.lblSettingTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_master = new System.Windows.Forms.DataGridView();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lblBillKey = new System.Windows.Forms.Label();
            this.lbl_Prefix = new System.Windows.Forms.Label();
            this.btn_PrefixUpdate = new System.Windows.Forms.Button();
            this.txt_Prefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // productTitlePanel
            // 
            this.productTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.productTitlePanel.Controls.Add(this.lblSettingTitle);
            this.productTitlePanel.Location = new System.Drawing.Point(0, 1);
            this.productTitlePanel.Name = "productTitlePanel";
            this.productTitlePanel.Size = new System.Drawing.Size(1034, 48);
            this.productTitlePanel.TabIndex = 2;
            // 
            // lblSettingTitle
            // 
            this.lblSettingTitle.AutoSize = true;
            this.lblSettingTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingTitle.ForeColor = System.Drawing.Color.White;
            this.lblSettingTitle.Location = new System.Drawing.Point(13, 9);
            this.lblSettingTitle.Name = "lblSettingTitle";
            this.lblSettingTitle.Size = new System.Drawing.Size(71, 25);
            this.lblSettingTitle.TabIndex = 1;
            this.lblSettingTitle.Text = "Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bill No";
            // 
            // txt_billno
            // 
            this.txt_billno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_billno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billno.Location = new System.Drawing.Point(163, 117);
            this.txt_billno.MaxLength = 3;
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(167, 35);
            this.txt_billno.TabIndex = 2;
            this.txt_billno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_billno_KeyPress);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(375, 117);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 35);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_tax.Location = new System.Drawing.Point(14, 206);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(75, 21);
            this.lbl_tax.TabIndex = 28;
            this.lbl_tax.Text = "Tax Type";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(163, 197);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(219, 35);
            this.txt_name.TabIndex = 3;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_rate.Location = new System.Drawing.Point(404, 206);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(72, 21);
            this.lbl_rate.TabIndex = 30;
            this.lbl_rate.Text = "Tax Rate";
            // 
            // txt_Rate
            // 
            this.txt_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rate.Location = new System.Drawing.Point(482, 197);
            this.txt_Rate.MaxLength = 10;
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(272, 35);
            this.txt_Rate.TabIndex = 4;
            this.txt_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rate_KeyPress);
            this.txt_Rate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Rate_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(769, 197);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 35);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgv_master
            // 
            this.dgv_master.AllowDrop = true;
            this.dgv_master.AllowUserToAddRows = false;
            this.dgv_master.AllowUserToDeleteRows = false;
            this.dgv_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_master.Location = new System.Drawing.Point(12, 266);
            this.dgv_master.Name = "dgv_master";
            this.dgv_master.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_master.Size = new System.Drawing.Size(1010, 304);
            this.dgv_master.TabIndex = 36;
            this.dgv_master.TabStop = false;
            this.dgv_master.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_master_CellDoubleClick);
            this.dgv_master.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_master_DataBindingComplete);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(94)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(907, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 35);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(27, 169);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 24);
            this.lbl_id.TabIndex = 38;
            this.lbl_id.Text = "lbl_id";
            this.lbl_id.Visible = false;
            // 
            // lblBillKey
            // 
            this.lblBillKey.BackColor = System.Drawing.Color.Transparent;
            this.lblBillKey.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillKey.Location = new System.Drawing.Point(79, 123);
            this.lblBillKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillKey.Name = "lblBillKey";
            this.lblBillKey.Size = new System.Drawing.Size(45, 24);
            this.lblBillKey.TabIndex = 39;
            this.lblBillKey.Text = "0";
            this.lblBillKey.Visible = false;
            // 
            // lbl_Prefix
            // 
            this.lbl_Prefix.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prefix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prefix.Location = new System.Drawing.Point(100, 70);
            this.lbl_Prefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prefix.Name = "lbl_Prefix";
            this.lbl_Prefix.Size = new System.Drawing.Size(45, 24);
            this.lbl_Prefix.TabIndex = 43;
            this.lbl_Prefix.Text = "0";
            this.lbl_Prefix.Visible = false;
            // 
            // btn_PrefixUpdate
            // 
            this.btn_PrefixUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(120)))));
            this.btn_PrefixUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrefixUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrefixUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_PrefixUpdate.Location = new System.Drawing.Point(375, 64);
            this.btn_PrefixUpdate.Name = "btn_PrefixUpdate";
            this.btn_PrefixUpdate.Size = new System.Drawing.Size(115, 35);
            this.btn_PrefixUpdate.TabIndex = 41;
            this.btn_PrefixUpdate.Text = "UPDATE";
            this.btn_PrefixUpdate.UseVisualStyleBackColor = false;
            this.btn_PrefixUpdate.Click += new System.EventHandler(this.btn_PrefixUpdate_Click);
            // 
            // txt_Prefix
            // 
            this.txt_Prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Prefix.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prefix.Location = new System.Drawing.Point(163, 64);
            this.txt_Prefix.MaxLength = 10;
            this.txt_Prefix.Name = "txt_Prefix";
            this.txt_Prefix.Size = new System.Drawing.Size(167, 35);
            this.txt_Prefix.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Bill Prefix";
            // 
            // frmGBSSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1034, 582);
            this.Controls.Add(this.lbl_Prefix);
            this.Controls.Add(this.btn_PrefixUpdate);
            this.Controls.Add(this.txt_Prefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBillKey);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_master);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_billno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(80, 60);
            this.Name = "frmGBSSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmGBSSetting";
            this.Load += new System.EventHandler(this.frmGBSSetting_Load);
            this.productTitlePanel.ResumeLayout(false);
            this.productTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel productTitlePanel;
        private System.Windows.Forms.Label lblSettingTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_master;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lblBillKey;
        private System.Windows.Forms.Label lbl_Prefix;
        private System.Windows.Forms.Button btn_PrefixUpdate;
        private System.Windows.Forms.TextBox txt_Prefix;
        private System.Windows.Forms.Label label3;
    }
}