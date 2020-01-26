namespace Stock_Management
{
    partial class ProductWindow
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
            this.stock_datagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_type = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.Label();
            this.stock_proname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ProductName = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.stock_weight = new System.Windows.Forms.ComboBox();
            this.stock_AddProduct = new System.Windows.Forms.Button();
            this.stock_status = new System.Windows.Forms.ComboBox();
            this.stock_DeleteProduct = new System.Windows.Forms.Button();
            this.stock_quantity = new System.Windows.Forms.TextBox();
            this.stock_generatereport = new System.Windows.Forms.Button();
            this.stock_updateproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stock_datagrid
            // 
            this.stock_datagrid.AllowUserToAddRows = false;
            this.stock_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.stock_datagrid.Location = new System.Drawing.Point(12, 74);
            this.stock_datagrid.Name = "stock_datagrid";
            this.stock_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stock_datagrid.Size = new System.Drawing.Size(870, 226);
            this.stock_datagrid.TabIndex = 0;
            this.stock_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.stock_datagrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "S.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Weight";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quanity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // stock_type
            // 
            this.stock_type.FormattingEnabled = true;
            this.stock_type.Items.AddRange(new object[] {
            "Old",
            "New",
            "Medium"});
            this.stock_type.Location = new System.Drawing.Point(308, 40);
            this.stock_type.Name = "stock_type";
            this.stock_type.Size = new System.Drawing.Size(67, 21);
            this.stock_type.TabIndex = 2;
            // 
            // DatePicker
            // 
            this.DatePicker.AutoSize = true;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(24, 15);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(45, 17);
            this.DatePicker.TabIndex = 2;
            this.DatePicker.Text = "Date :";
            // 
            // stock_proname
            // 
            this.stock_proname.Location = new System.Drawing.Point(119, 41);
            this.stock_proname.Name = "stock_proname";
            this.stock_proname.Size = new System.Drawing.Size(163, 20);
            this.stock_proname.TabIndex = 1;
            this.stock_proname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 23);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 21, 22, 10, 42, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProductName.Location = new System.Drawing.Point(116, 18);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(96, 17);
            this.ProductName.TabIndex = 5;
            this.ProductName.Text = "Product Name";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Type.Location = new System.Drawing.Point(305, 15);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(37, 17);
            this.Type.TabIndex = 6;
            this.Type.Text = "Type";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Quantity.Location = new System.Drawing.Point(465, 18);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(62, 17);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Weight.Location = new System.Drawing.Point(384, 15);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(53, 17);
            this.Weight.TabIndex = 10;
            this.Weight.Text = "Weight";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Status.Location = new System.Drawing.Point(552, 20);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(46, 17);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status";
            // 
            // stock_weight
            // 
            this.stock_weight.FormattingEnabled = true;
            this.stock_weight.Items.AddRange(new object[] {
            "1",
            "1.5",
            "5",
            "10",
            "25",
            "50",
            "75"});
            this.stock_weight.Location = new System.Drawing.Point(387, 40);
            this.stock_weight.Name = "stock_weight";
            this.stock_weight.Size = new System.Drawing.Size(69, 21);
            this.stock_weight.TabIndex = 3;
            // 
            // stock_AddProduct
            // 
            this.stock_AddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stock_AddProduct.Location = new System.Drawing.Point(652, 39);
            this.stock_AddProduct.Name = "stock_AddProduct";
            this.stock_AddProduct.Size = new System.Drawing.Size(52, 23);
            this.stock_AddProduct.TabIndex = 6;
            this.stock_AddProduct.Text = "Add";
            this.stock_AddProduct.UseVisualStyleBackColor = true;
            this.stock_AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // stock_status
            // 
            this.stock_status.FormattingEnabled = true;
            this.stock_status.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.stock_status.Location = new System.Drawing.Point(555, 40);
            this.stock_status.Name = "stock_status";
            this.stock_status.Size = new System.Drawing.Size(86, 21);
            this.stock_status.TabIndex = 5;
            this.stock_status.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // stock_DeleteProduct
            // 
            this.stock_DeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stock_DeleteProduct.Location = new System.Drawing.Point(791, 37);
            this.stock_DeleteProduct.Name = "stock_DeleteProduct";
            this.stock_DeleteProduct.Size = new System.Drawing.Size(63, 23);
            this.stock_DeleteProduct.TabIndex = 7;
            this.stock_DeleteProduct.Text = "Delete";
            this.stock_DeleteProduct.UseVisualStyleBackColor = true;
            this.stock_DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click_1);
            // 
            // stock_quantity
            // 
            this.stock_quantity.Location = new System.Drawing.Point(468, 42);
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.Size = new System.Drawing.Size(70, 20);
            this.stock_quantity.TabIndex = 4;
            // 
            // stock_generatereport
            // 
            this.stock_generatereport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stock_generatereport.Location = new System.Drawing.Point(721, 11);
            this.stock_generatereport.Name = "stock_generatereport";
            this.stock_generatereport.Size = new System.Drawing.Size(75, 23);
            this.stock_generatereport.TabIndex = 13;
            this.stock_generatereport.Text = "Report";
            this.stock_generatereport.UseVisualStyleBackColor = true;
            this.stock_generatereport.Click += new System.EventHandler(this.generatereport_Click);
            // 
            // stock_updateproduct
            // 
            this.stock_updateproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stock_updateproduct.Location = new System.Drawing.Point(710, 38);
            this.stock_updateproduct.Name = "stock_updateproduct";
            this.stock_updateproduct.Size = new System.Drawing.Size(75, 23);
            this.stock_updateproduct.TabIndex = 14;
            this.stock_updateproduct.Text = "Update";
            this.stock_updateproduct.UseVisualStyleBackColor = true;
            this.stock_updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 309);
            this.Controls.Add(this.stock_updateproduct);
            this.Controls.Add(this.stock_generatereport);
            this.Controls.Add(this.stock_quantity);
            this.Controls.Add(this.stock_DeleteProduct);
            this.Controls.Add(this.stock_status);
            this.Controls.Add(this.stock_AddProduct);
            this.Controls.Add(this.stock_weight);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stock_proname);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.stock_type);
            this.Controls.Add(this.stock_datagrid);
            this.Name = "ProductWindow";
            this.Text = "PRAVEEN Rice Mandi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stock_datagrid;
        private System.Windows.Forms.ComboBox stock_type;
        private System.Windows.Forms.Label DatePicker;
        private System.Windows.Forms.TextBox stock_proname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox stock_weight;
        private System.Windows.Forms.Button stock_AddProduct;
        private System.Windows.Forms.ComboBox stock_status;
        private System.Windows.Forms.Button stock_DeleteProduct;
        private System.Windows.Forms.TextBox stock_quantity;
        private System.Windows.Forms.Button stock_generatereport;
        private System.Windows.Forms.Button stock_updateproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

