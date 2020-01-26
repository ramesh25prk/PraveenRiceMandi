namespace Stock_Management
{
    partial class Generate_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Report));
            this.report_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.report_print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.report_export2excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // report_dataGridView1
            // 
            this.report_dataGridView1.AllowUserToAddRows = false;
            this.report_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.report_dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.report_dataGridView1.Name = "report_dataGridView1";
            this.report_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report_dataGridView1.Size = new System.Drawing.Size(772, 226);
            this.report_dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "S.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 56;
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
            // report_dateTimePicker2
            // 
            this.report_dateTimePicker2.AllowDrop = true;
            this.report_dateTimePicker2.Checked = false;
            this.report_dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.report_dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.report_dateTimePicker2.Location = new System.Drawing.Point(72, 16);
            this.report_dateTimePicker2.Name = "report_dateTimePicker2";
            this.report_dateTimePicker2.ShowUpDown = true;
            this.report_dateTimePicker2.Size = new System.Drawing.Size(92, 23);
            this.report_dateTimePicker2.TabIndex = 13;
            this.report_dateTimePicker2.Value = new System.DateTime(2020, 1, 21, 22, 10, 42, 0);
            this.report_dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DatePicker
            // 
            this.DatePicker.AutoSize = true;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(21, 16);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(45, 17);
            this.DatePicker.TabIndex = 14;
            this.DatePicker.Text = "Date :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // report_print
            // 
            this.report_print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.report_print.Location = new System.Drawing.Point(628, 16);
            this.report_print.Name = "report_print";
            this.report_print.Size = new System.Drawing.Size(75, 23);
            this.report_print.TabIndex = 15;
            this.report_print.Text = "Print";
            this.report_print.UseVisualStyleBackColor = true;
            this.report_print.Click += new System.EventHandler(this.print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // report_export2excel
            // 
            this.report_export2excel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.report_export2excel.Location = new System.Drawing.Point(412, 16);
            this.report_export2excel.Name = "report_export2excel";
            this.report_export2excel.Size = new System.Drawing.Size(120, 23);
            this.report_export2excel.TabIndex = 16;
            this.report_export2excel.Text = "Export to Excel";
            this.report_export2excel.UseVisualStyleBackColor = true;
            this.report_export2excel.Click += new System.EventHandler(this.report_export2excel_Click);
            // 
            // Generate_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 301);
            this.Controls.Add(this.report_export2excel);
            this.Controls.Add(this.report_print);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.report_dateTimePicker2);
            this.Controls.Add(this.report_dataGridView1);
            this.Name = "Generate_Report";
            this.Text = "Generate_Report";
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView report_dataGridView1;
        private System.Windows.Forms.DateTimePicker report_dateTimePicker2;
        private System.Windows.Forms.Label DatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button report_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button report_export2excel;
    }
}