namespace Window_Form_Exam.Forms.Products
{
    partial class Product_FRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_uniprice = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_sellprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_category_name = new System.Windows.Forms.ComboBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.col_productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_uniprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_createddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_updateddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(145, 75);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(170, 20);
            this.txt_productname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sell Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "QTY";
            // 
            // txt_uniprice
            // 
            this.txt_uniprice.Location = new System.Drawing.Point(145, 152);
            this.txt_uniprice.Name = "txt_uniprice";
            this.txt_uniprice.Size = new System.Drawing.Size(170, 20);
            this.txt_uniprice.TabIndex = 3;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(145, 114);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(170, 20);
            this.txt_barcode.TabIndex = 2;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(425, 114);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(176, 20);
            this.txt_qty.TabIndex = 5;
            // 
            // txt_sellprice
            // 
            this.txt_sellprice.Location = new System.Drawing.Point(425, 75);
            this.txt_sellprice.Name = "txt_sellprice";
            this.txt_sellprice.Size = new System.Drawing.Size(176, 20);
            this.txt_sellprice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unit Price";
            // 
            // cbo_category_name
            // 
            this.cbo_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_category_name.FormattingEnabled = true;
            this.cbo_category_name.Location = new System.Drawing.Point(425, 151);
            this.cbo_category_name.Name = "cbo_category_name";
            this.cbo_category_name.Size = new System.Drawing.Size(176, 21);
            this.cbo_category_name.TabIndex = 6;
            this.cbo_category_name.TextChanged += new System.EventHandler(this.cbo_category_name_TextChanged);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(658, 185);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(658, 74);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 7;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(658, 110);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(658, 147);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(267, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Information";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(93, 213);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(158, 20);
            this.txt_search.TabIndex = 11;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Search by:";
            // 
            // dg_product
            // 
            this.dg_product.AllowUserToAddRows = false;
            this.dg_product.AllowUserToDeleteRows = false;
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_productid,
            this.col_productname,
            this.col_barcode,
            this.col_uniprice,
            this.col_sellprice,
            this.col_categoryname,
            this.col_qty,
            this.col_createddate,
            this.col_updateddate});
            this.dg_product.ContextMenuStrip = this.contextMenuStrip1;
            this.dg_product.Location = new System.Drawing.Point(0, 239);
            this.dg_product.MultiSelect = false;
            this.dg_product.Name = "dg_product";
            this.dg_product.ReadOnly = true;
            this.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_product.Size = new System.Drawing.Size(800, 211);
            this.dg_product.TabIndex = 25;
            this.dg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellClick);
            this.dg_product.DoubleClick += new System.EventHandler(this.dg_product_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_username});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Username:";
            // 
            // lbl_username
            // 
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 17);
            this.lbl_username.Text = "lbl_username";
            // 
            // col_productid
            // 
            this.col_productid.HeaderText = "ID";
            this.col_productid.Name = "col_productid";
            this.col_productid.ReadOnly = true;
            this.col_productid.Width = 30;
            // 
            // col_productname
            // 
            this.col_productname.HeaderText = "Product Name";
            this.col_productname.Name = "col_productname";
            this.col_productname.ReadOnly = true;
            // 
            // col_barcode
            // 
            this.col_barcode.HeaderText = "Barcode";
            this.col_barcode.Name = "col_barcode";
            this.col_barcode.ReadOnly = true;
            // 
            // col_uniprice
            // 
            this.col_uniprice.HeaderText = "Unit Price";
            this.col_uniprice.Name = "col_uniprice";
            this.col_uniprice.ReadOnly = true;
            // 
            // col_sellprice
            // 
            this.col_sellprice.HeaderText = "Sell Price";
            this.col_sellprice.Name = "col_sellprice";
            this.col_sellprice.ReadOnly = true;
            // 
            // col_categoryname
            // 
            this.col_categoryname.HeaderText = "Category";
            this.col_categoryname.Name = "col_categoryname";
            this.col_categoryname.ReadOnly = true;
            // 
            // col_qty
            // 
            this.col_qty.HeaderText = "QTY";
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 50;
            // 
            // col_createddate
            // 
            this.col_createddate.HeaderText = "Created Date";
            this.col_createddate.Name = "col_createddate";
            this.col_createddate.ReadOnly = true;
            // 
            // col_updateddate
            // 
            this.col_updateddate.HeaderText = "Updated Date";
            this.col_updateddate.Name = "col_updateddate";
            this.col_updateddate.ReadOnly = true;
            // 
            // Product_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dg_product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.cbo_category_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sellprice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.txt_uniprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label1);
            this.Name = "Product_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.Product_FRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_uniprice;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_sellprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_category_name;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_uniprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sellprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_createddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_updateddate;
    }
}