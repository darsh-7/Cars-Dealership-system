using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_X
{
    public partial class Login_Form : Form
    {
        SqlConnection con = new SqlConnection(Program.sqlConnection);
        SqlCommand cmd;

        public Login_Form()
        {
            InitializeComponent();
        }

        private bool checkuser()
        {

            try
            {
                SqlCommand cmd = new SqlCommand($"select * from usersAccounts where name = '{username.Text}' and Password = '{password.Text}';", con);
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                return ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            }
            catch (Exception)
            {
                //MessageBox.Show("Enter valed data");
                con.Close();
            }

            return false;


        }

/*        private void addUser(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                if (checkuser())
                {
                    MessageBox.Show("username is used");
                }
                else
                {
                    try
                    {
                        cmd = new SqlCommand($"INSERT INTO users VALUES ('{username.Text}','{password.Text}','1')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("user created");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("username is used");
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }
        }
*/

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                if (checkuser())
                {
                    Program.name = username.Text;
                    SqlConnection conn = new SqlConnection(Program.sqlConnection);
                    SqlCommand cmmd = new SqlCommand($"select * from usersAccounts where name = '{username.Text}'", conn);
                    try
                    {
                        conn.Open();
                        SqlDataReader rdr = cmmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                Program.accountAccs = (int)rdr["roleId"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("cannot find your role please call the IT support");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("cannot find your role please call the IT support");
                        return;
                    }
                    conn.Close();
                    Car_list frm2 = new Car_list();
                    frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                    frm2.Show();
                    this.Hide();

                    // Since this.Hide() for some reason doesn't work, i'll have to do this crap
                    //this.WindowState = FormWindowState.Minimized;
                    //this.ShowInTaskbar = false;


                    //Form2 frm2 = new Form2();
                    //this.Hide();           //Hide the main form before showing the secondary
                    //frm2.Show();     //Show secondary form, code execution stop until frm2 is closed
                    //this.Hide();           //When frm2 is closed, continue with the code (show main form)


                    /*                    Form2 form2 = new Form2();
                                        form2.Tag = this;
                                        form2.Show(this);
                                        Hide();
                    */
                    /*                    this.Hide();
                                        Form2 Check = new Form2();
                                        Check.Show();
                    */                    //                        Program.newuser(username.Text, 0);
                                          //          this.close();
                                          //          form2.Show(this);
                }
                else
                {
                    MessageBox.Show("username or password not correct");
                }

            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }



        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
