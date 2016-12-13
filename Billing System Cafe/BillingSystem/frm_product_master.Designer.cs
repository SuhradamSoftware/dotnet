namespace BillingSystem
{
    partial class frm_Product_master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_master = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.tlp_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_header.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_main.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlp_main.Controls.Add(this.lbl_id, 0, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 1;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(679, 469);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 463);
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
            this.tlp_header.Size = new System.Drawing.Size(531, 26);
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
            this.lbl_exit.Location = new System.Drawing.Point(512, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(16, 26);
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
            this.lbl_header.Size = new System.Drawing.Size(493, 26);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Product Details";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(531, 160);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.009188F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.91142F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.91142F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.167985F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_address, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_name, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_ProductDescription, 2, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.83117F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.16883F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(471, 154);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_address.Location = new System.Drawing.Point(27, 29);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(208, 125);
            this.lbl_address.TabIndex = 18;
            this.lbl_address.Text = "Description";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.lbl_name.Location = new System.Drawing.Point(27, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(208, 29);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Product Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_name.Location = new System.Drawing.Point(243, 4);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.MaxLength = 48;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 24);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // txt_ProductDescription
            // 
            this.txt_ProductDescription.BackColor = System.Drawing.Color.White;
            this.txt_ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_ProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(84)))));
            this.txt_ProductDescription.Location = new System.Drawing.Point(243, 33);
            this.txt_ProductDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductDescription.MaxLength = 198;
            this.txt_ProductDescription.Multiline = true;
            this.txt_ProductDescription.Name = "txt_ProductDescription";
            this.txt_ProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ProductDescription.Size = new System.Drawing.Size(208, 117);
            this.txt_ProductDescription.TabIndex = 19;
            this.txt_ProductDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductDescription_KeyDown);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 201);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 31);
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
            this.btn_save.Location = new System.Drawing.Point(343, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
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
            this.btn_delete.Location = new System.Drawing.Point(406, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(55, 23);
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
            this.btn_reset.Location = new System.Drawing.Point(469, 4);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(58, 23);
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
            this.txt_search.Size = new System.Drawing.Size(130, 24);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv_master.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_master.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_master.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_master.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_master.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_master.Location = new System.Drawing.Point(4, 239);
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
            // frm_Product_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(679, 469);
            this.Controls.Add(this.tlp_main);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Product_master";
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
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.DataGridView dgv_master;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_ProductDescription;

    }
}