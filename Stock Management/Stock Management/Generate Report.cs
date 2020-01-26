using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class Generate_Report : Form
    {
        public Generate_Report()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string reportdate = report_dateTimePicker2.Value.ToString("dd/MM/yyyy");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RiceMandy;Integrated Security=True");
            string sqlquery = @"select [ProductName],[Type],[Weight],sum(Quantity) as Quantity 
                                from ProductsList
                                where Status = 'Active'
                                and Date <= '"+ reportdate +"' group by ProductName, type , weight";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            report_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = report_dataGridView1.Rows.Add();
                report_dataGridView1.Rows[n].Cells[0].Value = n + 1;
                //dataGridView1.Rows[n].Cells[1].Value = item["Date"].ToString();
                report_dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                report_dataGridView1.Rows[n].Cells[2].Value = item["Type"].ToString();
                report_dataGridView1.Rows[n].Cells[3].Value = item["Weight"].ToString();
                report_dataGridView1.Rows[n].Cells[4].Value = item["Quantity"].ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void print_Click(object sender, EventArgs e)
        {
            int height = report_dataGridView1.Height;
            report_dataGridView1.Height = report_dataGridView1.RowCount * report_dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(report_dataGridView1.Width, report_dataGridView1.Height);
            report_dataGridView1.DrawToBitmap(bmp, new Rectangle(0,0,report_dataGridView1.Width, report_dataGridView1.Height));
            report_dataGridView1.Height = height;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void report_export2excel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application application = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Report" + DateTime.Now.ToShortDateString();


                worksheet.Cells[1, 1] = "S.No";
                worksheet.Columns.ColumnWidth = 25;
                worksheet.Cells[1, 2] = "Product Name";
                worksheet.Cells[1, 3] = "Type";
                worksheet.Cells[1, 4] = "Weight";
                worksheet.Cells[1, 5] = "Quantity";
                for (int i = 0; i < report_dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < report_dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = report_dataGridView1.Rows[i].Cells[j].ToString();
                    }
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.RestoreDirectory = true;
                saveFile.DefaultExt = "xlsx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName);
                }
                application.Visible = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message + Environment.NewLine + "Try installing MS Office");
            }
        }
    }
}