using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class ProductWindow : Form
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stock_status.SelectedIndex = 0;
            stock_proname.Focus();
            //SqlConnection con = new SqlConnection(@"Data Source=192.168.43.72,69\ChandiranRM;User ID = sa;Password = praveen;Initial Catalog=Stock Maintenance;Integrated Security=False"); 
            //con.Open();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean ProductExists(SqlConnection con, string productname)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from [ProductsList] where [ProductName] = '" + productname + "';", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            string currentdate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string currentdates = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            SqlConnection con = new SqlConnection(@"Data Source=192.168.43.72,69\ChandiranRM;User ID = sa;Password = praveen;Initial Catalog=Stock Maintenance;Integrated Security=False");
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RiceMandy;Integrated Security=True");
            con.Open();
            var sqlquery = "";
            sqlquery = @"INSERT INTO [dbo].[ProductsList]([Date],[ProductName],[Type],[Weight],[Quantity],[Status]) 
                        VALUES ('" + currentdate + "','" + stock_proname.Text + "','" + stock_type.Text + "','" + stock_weight.Text + "','" + stock_quantity.Text + "','" + stock_status.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Write the datas into datagridview
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.43.72,69\ChandiranRM;User ID = sa;Password = praveen;Initial Catalog=Stock Maintenance;Integrated Security=False");
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RiceMandy;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM[dbo].[ProductsList]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            stock_datagrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = stock_datagrid.Rows.Add();
                stock_datagrid.Rows[n].Cells[0].Value = n + 1;
                stock_datagrid.Rows[n].Cells[1].Value = item["Date"].ToString();
                stock_datagrid.Rows[n].Cells[2].Value = item["ProductName"].ToString();
                stock_datagrid.Rows[n].Cells[3].Value = item["Type"].ToString();
                stock_datagrid.Rows[n].Cells[4].Value = item["Weight"].ToString();
                stock_datagrid.Rows[n].Cells[5].Value = item["Quantity"].ToString();
                stock_datagrid.Rows[n].Cells[6].Value = item["Status"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dateTimePicker1.Text = stock_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            stock_proname.Text = stock_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            stock_type.Text = stock_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            stock_weight.Text = stock_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            stock_quantity.Text = stock_datagrid.SelectedRows[0].Cells[5].Value.ToString();
            stock_status.Text = stock_datagrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void generatereport_Click(object sender, EventArgs e)
        {
            Generate_Report report = new Generate_Report();
            report.Show();
        }

        private void DeleteProduct_Click_1(object sender, EventArgs e)
        {
            string currentdate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            SqlConnection con = new SqlConnection(@"Data Source=192.168.43.72,69\ChandiranRM;User ID = sa;Password = praveen;Initial Catalog=Stock Maintenance;Integrated Security=False");
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RiceMandy;Integrated Security=True");
            con.Open();
            var sqlquery = "";
            if (ProductExists(con, stock_proname.Text))
            {
                sqlquery = @"DELETE FROM [dbo].[ProductsList] WHERE [Date] like '" + currentdate + "' and [ProductName] = '" + stock_proname.Text + "' and [Type] = '" + stock_type.Text + "' and [Weight] = '" + stock_weight.Text + "' and [Quantity] = '" + stock_quantity.Text + "' and [Status] = '" + stock_status.Text + "'; "; 
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Select any row to delete..");
            }
            //Write the datas into datagridview
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.43.72,69\ChandiranRM;User ID = sa;Password = praveen;Initial Catalog=Stock Maintenance;Integrated Security=False");
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=RiceMandy;Integrated Security=True");
            var sqlquery = "";
            string currentdate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            if (ProductExists(con, stock_proname.Text))
            {
                sqlquery = @"UPDATE [ProductsList] SET [Date] = '" + currentdate + "',[Type] = '" + stock_type.Text + "' ,[Weight] = '" + stock_weight.Text + "',[Quantity] ='" + stock_quantity.Text + "' ,[Status] = '" + stock_status.Text + "' WHERE [ProductName] ='" + stock_proname.Text + "';";
            }
            else
            {
                sqlquery = @"INSERT INTO [dbo].[ProductsList]([Date],[ProductName],[Type],[Weight],[Quantity],[Status]) 
                        VALUES ('" + currentdate + "','" + stock_proname.Text + "','" + stock_type.Text + "','" + stock_weight.Text + "','" + stock_quantity.Text + "','" + stock_status.Text + "')";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
