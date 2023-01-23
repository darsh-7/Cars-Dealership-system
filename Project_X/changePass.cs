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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_X
{
    public partial class changePass : Form
    {
        SqlConnection con = new SqlConnection(Program.sqlConnection);
        SqlCommand cmd;



        public changePass()
        {
            InitializeComponent();
            label1.Text = "user: "+Program.name;
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"update usersAccounts set Password = '{password.Text}' where name = {Program.name};", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();

                    MessageBox.Show("password changed");
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter valed data");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("password not right");
            }
        }
        private bool checkuser()
        {

            try
            {
                SqlCommand cmd = new SqlCommand($"select * from usersAccounts  where name = {Program.name} and  Password = '{password.Text}';", con);
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                return ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            }
            catch (Exception)
            {
                MessageBox.Show("Enter valed data");
                con.Close();
            }

            return false;


        }
    }
}
