namespace ClientApplication
{
    partial class GenerateKey
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
            this.CustomerKey = new System.Windows.Forms.Button();
            this.CutomerKey = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelProductKey = new System.Windows.Forms.Label();
            this.RegisterKeyText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterProductKeyTxt = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerKey
            // 
            this.CustomerKey.Location = new System.Drawing.Point(162, 48);
            this.CustomerKey.Name = "CustomerKey";
            this.CustomerKey.Size = new System.Drawing.Size(150, 23);
            this.CustomerKey.TabIndex = 0;
            this.CustomerKey.Text = "Generate Key";
            this.CustomerKey.UseVisualStyleBackColor = true;
            this.CustomerKey.Click += new System.EventHandler(this.CustomerKey_Click);
            // 
            // CutomerKey
            // 
            this.CutomerKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CutomerKey.Location = new System.Drawing.Point(108, 92);
            this.CutomerKey.Name = "CutomerKey";
            this.CutomerKey.ReadOnly = true;
            this.CutomerKey.Size = new System.Drawing.Size(399, 20);
            this.CutomerKey.TabIndex = 3;
            this.CutomerKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutomerKey.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelProductKey
            // 
            this.labelProductKey.AutoSize = true;
            this.labelProductKey.Location = new System.Drawing.Point(19, 94);
            this.labelProductKey.Name = "labelProductKey";
            this.labelProductKey.Size = new System.Drawing.Size(71, 13);
            this.labelProductKey.TabIndex = 5;
            this.labelProductKey.Text = "Product Key :";
            this.labelProductKey.Visible = false;
            // 
            // RegisterKeyText
            // 
            this.RegisterKeyText.AutoSize = true;
            this.RegisterKeyText.Location = new System.Drawing.Point(67, 16);
            this.RegisterKeyText.Name = "RegisterKeyText";
            this.RegisterKeyText.Size = new System.Drawing.Size(380, 13);
            this.RegisterKeyText.TabIndex = 6;
            this.RegisterKeyText.Text = "Generate product key and contact Suhradam Software to register your product.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegisterKeyText);
            this.groupBox1.Controls.Add(this.CustomerKey);
            this.groupBox1.Controls.Add(this.CutomerKey);
            this.groupBox1.Controls.Add(this.labelProductKey);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRegister);
            this.groupBox2.Controls.Add(this.RegisterProductKeyTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter register key recevied from Suhradam Software to register your product.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Register Key :";
            // 
            // RegisterProductKeyTxt
            // 
            this.RegisterProductKeyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterProductKeyTxt.Location = new System.Drawing.Point(108, 53);
            this.RegisterProductKeyTxt.Name = "RegisterProductKeyTxt";
            this.RegisterProductKeyTxt.Size = new System.Drawing.Size(399, 20);
            this.RegisterProductKeyTxt.TabIndex = 7;
            this.RegisterProductKeyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(148, 97);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(150, 23);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Register Product";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // GenerateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateKey";
            this.Text = "Register Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerKey;
        private System.Windows.Forms.TextBox CutomerKey;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelProductKey;
        private System.Windows.Forms.Label RegisterKeyText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegisterProductKeyTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegister;
    }
}

