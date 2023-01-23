using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_X
{
    public partial class ShowBills : Form
    {
        string table = "bills , customers where Bills.customer_ssn = Customers.ssn";
        SqlConnection con = new SqlConnection(Program.sqlConnection);

        public ShowBills()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand($"select * from {table} ;", con);
            newTableData(cmd);

        }
        private void newTableData(SqlCommand cmd)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("can not Load the bills");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from {table} and  ssn LIKE '%{searchBox.Text}%' or phone LIKE '%{searchBox.Text}%' or " +
                $"name LIKE '%{searchBox.Text}%' or id LIKE '%{searchBox.Text}%'  ;", con);
            newTableData(cmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from {table} ;", con);
            newTableData(cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today.ToShortDateString();
            var lastmonth = DateTime.Today.AddMonths(-1).ToShortDateString();

            SqlCommand cmd = new SqlCommand($"select * from Bills where Date > '{lastmonth}' and Date < '{today}';", con);
            newTableData(cmd);

        }
    }
}
