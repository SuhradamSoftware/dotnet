namespace BillingSystem
{
    partial class frm_customer_master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.UploadPicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_DocumentNumber = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.txt_DocumentNumber = new System.Windows.Forms.TextBox();
            this.txt_phone_no = new System.Windows.Forms.TextBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.label_DocumentPath = new System.Windows.Forms.Label();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_DocumentType = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.lbl_customerID = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_master = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.tlp_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_header.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPicBox)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 54);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // tlp_main
            // 
            this.tlp_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tlp_main.ColumnCount = 3;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_main.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlp_main.Controls.Add(this.lbl_id, 0, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 1;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(1200, 700);
            this.tlp_main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlp_header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_master, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.930693F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.54456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.920792F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.60396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 694);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlp_header
            // 
            this.tlp_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.tlp_header.ColumnCount = 3;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlp_header.Controls.Add(this.lbl_exit, 2, 0);
            this.tlp_header.Controls.Add(this.lbl_header, 0, 0);
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_header.Location = new System.Drawing.Point(3, 3);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(1068, 40);
            this.tlp_header.TabIndex = 18;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.lbl_exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_exit.ForeColor = System.Drawing.Color.White;
            this.lbl_exit.Location = new System.Drawing.Point(1027, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(38, 40);
            this.lbl_exit.TabIndex = 6;
            this.lbl_exit.Text = "X";
            this.lbl_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_exit.Click += new System.EventHandler(this.btnGClose_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(3, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(997, 40);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Customer Details";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1068, 300);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_address, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_address, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.UploadPicBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(590, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 294);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_address.Location = new System.Drawing.Point(4, 0);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(106, 73);
            this.lbl_address.TabIndex = 18;
            this.lbl_address.Text = "Address :";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_address.Location = new System.Drawing.Point(118, 4);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.MaxLength = 198;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_address.Size = new System.Drawing.Size(277, 65);
            this.txt_address.TabIndex = 6;
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // UploadPicBox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.UploadPicBox, 3);
            this.UploadPicBox.Location = new System.Drawing.Point(3, 76);
            this.UploadPicBox.Name = "UploadPicBox";
            this.UploadPicBox.Size = new System.Drawing.Size(300, 214);
            this.UploadPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadPicBox.TabIndex = 32;
            this.UploadPicBox.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.61225F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.06123F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.label_DocumentNumber, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btn_Upload, 2, 6);
            this.tableLayoutPanel6.Controls.Add(this.txt_DocumentNumber, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.txt_phone_no, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txt_FileName, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label_DocumentPath, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.lbl_phone_no, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_name, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_DocumentType, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.cmbDocumentType, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lbl_city, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txt_CustomerID, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_customerID, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_city, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0384F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9904F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9904F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9904F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9904F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(581, 294);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label_DocumentNumber
            // 
            this.label_DocumentNumber.BackColor = System.Drawing.Color.Transparent;
            this.label_DocumentNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DocumentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_DocumentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_DocumentNumber.Location = new System.Drawing.Point(4, 169);
            this.label_DocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DocumentNumber.Name = "label_DocumentNumber";
            this.label_DocumentNumber.Size = new System.Drawing.Size(169, 37);
            this.label_DocumentNumber.TabIndex = 30;
            this.label_DocumentNumber.Text = "Document Number :";
            this.label_DocumentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.btn_Upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Upload.ForeColor = System.Drawing.Color.White;
            this.btn_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Upload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Upload.Location = new System.Drawing.Point(489, 252);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(88, 38);
            this.btn_Upload.TabIndex = 19;
            this.btn_Upload.Text = "Browse";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // txt_DocumentNumber
            // 
            this.txt_DocumentNumber.BackColor = System.Drawing.Color.White;
            this.txt_DocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DocumentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_DocumentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_DocumentNumber.Location = new System.Drawing.Point(181, 173);
            this.txt_DocumentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DocumentNumber.MaxLength = 18;
            this.txt_DocumentNumber.Name = "txt_DocumentNumber";
            this.txt_DocumentNumber.Size = new System.Drawing.Size(131, 24);
            this.txt_DocumentNumber.TabIndex = 31;
            // 
            // txt_phone_no
            // 
            this.txt_phone_no.BackColor = System.Drawing.Color.White;
            this.txt_phone_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_phone_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_phone_no.Location = new System.Drawing.Point(181, 130);
            this.txt_phone_no.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone_no.MaxLength = 18;
            this.txt_phone_no.Name = "txt_phone_no";
            this.txt_phone_no.Size = new System.Drawing.Size(131, 24);
            this.txt_phone_no.TabIndex = 10;
            // 
            // txt_FileName
            // 
            this.txt_FileName.BackColor = System.Drawing.Color.White;
            this.txt_FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_FileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_FileName.Location = new System.Drawing.Point(181, 252);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FileName.MaxLength = 18;
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(300, 24);
            this.txt_FileName.TabIndex = 32;
            // 
            // label_DocumentPath
            // 
            this.label_DocumentPath.BackColor = System.Drawing.Color.Transparent;
            this.label_DocumentPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DocumentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_DocumentPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_DocumentPath.Location = new System.Drawing.Point(4, 248);
            this.label_DocumentPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DocumentPath.Name = "label_DocumentPath";
            this.label_DocumentPath.Size = new System.Drawing.Size(169, 46);
            this.label_DocumentPath.TabIndex = 30;
            this.label_DocumentPath.Text = "Document :";
            this.label_DocumentPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_phone_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_phone_no.Location = new System.Drawing.Point(4, 126);
            this.lbl_phone_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(169, 43);
            this.lbl_phone_no.TabIndex = 27;
            this.lbl_phone_no.Text = "Phone Number :";
            this.lbl_phone_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_name.Location = new System.Drawing.Point(4, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(169, 42);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Customer Name :";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_name.Location = new System.Drawing.Point(181, 4);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.MaxLength = 48;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(300, 24);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // label_DocumentType
            // 
            this.label_DocumentType.BackColor = System.Drawing.Color.Transparent;
            this.label_DocumentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_DocumentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.label_DocumentType.Location = new System.Drawing.Point(4, 206);
            this.label_DocumentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DocumentType.Name = "label_DocumentType";
            this.label_DocumentType.Size = new System.Drawing.Size(169, 42);
            this.label_DocumentType.TabIndex = 29;
            this.label_DocumentType.Text = "DocumentType :";
            this.label_DocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDocumentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbDocumentType.BackColor = System.Drawing.Color.White;
            this.cmbDocumentType.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Items.AddRange(new object[] {
            "Select Document",
            "PAN Card",
            "Driving Licence",
            "Election Card"});
            this.cmbDocumentType.Location = new System.Drawing.Point(180, 209);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(180, 23);
            this.cmbDocumentType.TabIndex = 30;
            // 
            // lbl_city
            // 
            this.lbl_city.BackColor = System.Drawing.Color.Transparent;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_city.Location = new System.Drawing.Point(4, 84);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(47, 25);
            this.lbl_city.TabIndex = 28;
            this.lbl_city.Text = "City :";
            this.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BackColor = System.Drawing.Color.White;
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_CustomerID.Location = new System.Drawing.Point(181, 46);
            this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CustomerID.MaxLength = 8;
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(131, 24);
            this.txt_CustomerID.TabIndex = 4;
            this.txt_CustomerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_id_KeyDown);
            // 
            // lbl_customerID
            // 
            this.lbl_customerID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_customerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_customerID.Location = new System.Drawing.Point(4, 42);
            this.lbl_customerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customerID.Name = "lbl_customerID";
            this.lbl_customerID.Size = new System.Drawing.Size(169, 42);
            this.lbl_customerID.TabIndex = 23;
            this.lbl_customerID.Text = "Customer ID : ";
            this.lbl_customerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_city
            // 
            this.txt_city.BackColor = System.Drawing.Color.White;
            this.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_city.Location = new System.Drawing.Point(181, 88);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.MaxLength = 18;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(131, 24);
            this.txt_city.TabIndex = 7;
            this.txt_city.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_city_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_delete, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_search, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 355);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1068, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(686, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "&SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete.Location = new System.Drawing.Point(814, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 39);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "&DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_reset.Location = new System.Drawing.Point(942, 4);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(122, 39);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "&REFRESH";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_search.Location = new System.Drawing.Point(4, 4);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.MaxLength = 198;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(269, 24);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search...";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // dgv_master
            // 
            this.dgv_master.AllowUserToAddRows = false;
            this.dgv_master.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv_master.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_master.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_master.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_master.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_master.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_master.Location = new System.Drawing.Point(4, 409);
            this.dgv_master.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_master.Name = "dgv_master";
            this.dgv_master.RowHeadersVisible = false;
            this.dgv_master.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_master.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_master.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_master.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_master.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.dgv_master.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv_master.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_master.Size = new System.Drawing.Size(529, 220);
            this.dgv_master.TabIndex = 0;
            this.dgv_master.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_master_CellDoubleClick);
            this.dgv_master.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_master_CellMouseDown);
            this.dgv_master.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_master_DataBindingComplete);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(4, 0);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 24);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "lbl_id";
            this.lbl_id.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Jpg|*.jpg|Jpge|*.jpge|Gif|*.gif|PNG|*.png\"";
            // 
            // frm_customer_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tlp_main);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_customer_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_user_master";
            this.Load += new System.EventHandler(this.frm_user_master_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_user_master_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.tlp_main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_header.ResumeLayout(false);
            this.tlp_header.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPicBox)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_customerID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.DataGridView dgv_master;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label label_DocumentType;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label label_DocumentPath;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_DocumentNumber;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.TextBox txt_phone_no;
        private System.Windows.Forms.TextBox txt_DocumentNumber;
        private System.Windows.Forms.PictureBox UploadPicBox;

    }
}