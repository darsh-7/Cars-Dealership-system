using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_X
{
    public partial class supplies : Form
    {
        SqlConnection con = new SqlConnection(Program.sqlConnection);
        SqlCommand cmd;

        string[] tables = { "cars", "CarsModels", "CarsImages"};
        string tableSelected = "cars";

        public supplies()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand($"select * from {tables[0]} ;", con);
            newTableData(cmd);

            TableName.Text = tableSelected;
            HideViewLables(2);
            HideViewLables(1, 6);
            label1.Text = "ID";
            label2.Text = "Model";
            label3.Text = "color";
            label4.Text = "cost";
            label5.Text = "offer";
            label6.Text = "quantity";
        }
        private bool checkExsist()
        {

            try
            {
                if (tableSelected == tables[0])
                    cmd = new SqlCommand($"select * from {tableSelected} where id = '{textBox1.Text}';", con);
                else if (tableSelected == tables[1])
                    cmd = new SqlCommand($"select * from {tableSelected} where model = '{textBox1.Text}';", con);

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
        private void HideViewLables(byte stats, byte num = 0)
        {
            if (stats == 1)
            {
                switch (num + 1)
                {
                    case 0:
                        break;
                    case 1:
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;

                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
 
                        break;
                    case 3:
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;

                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;

                        break;
                    case 4:
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;


                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;

                        break;
                    case 5:
                        label5.Visible = false;
                        label6.Visible = false;


                        textBox5.Visible = false;
                        textBox6.Visible = false;

                        break;

                    case 6:
                        label6.Visible = false;


                        textBox6.Visible = false;

                        break;


                }
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

            }
        }
        private void refreshTable()
        {
            SqlCommand cmd = new SqlCommand($"select * from {tableSelected} ;", con);
            newTableData(cmd);
        }
        private void newTableData(SqlCommand cmd)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void cars_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from {tables[0]} ;", con);
            newTableData(cmd);
            tableSelected = tables[0];
            TableName.Text = tableSelected;
            HideViewLables(2);
            HideViewLables(1, 6);
            label1.Text = "ID";
            label2.Text = "Model";
            label3.Text = "color";
            label4.Text = "cost";
            label5.Text = "offer";
            label6.Text = "quantity";

        }
        private void Models_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from {tables[1]} ;", con);
            newTableData(cmd);
            HideViewLables(1, 4);
            tableSelected = tables[1];
            TableName.Text = tableSelected;
            label1.Text = "Model";
            label2.Text = "speed";
            label3.Text = "year";
            label4.Text = "catagoryId";

        }
        private void carsImage_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from {tables[2]} ;", con);
            newTableData(cmd);
            HideViewLables(1, 0);

            tableSelected = tables[2];
            TableName.Text = tableSelected;
            HideViewLables(2);

        }

        private void insert_Click(object sender, EventArgs e)
        {
            bool boxEmpty3 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "";
            bool boxEmpty4 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "";
            bool boxEmpty5 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""
                                 && textBox5.Text != "" ;
            bool boxEmpty6 =   textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""
                                 && textBox5.Text != "" && textBox6.Text != "" ;
            if (boxEmpty4)
            {

                 if (!checkExsist() && boxEmpty6)
                {
                    try
                    {

                        cmd = new SqlCommand($"INSERT INTO {tableSelected} VALUES ('{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("car added");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data not valied");
                        con.Close();
                    }

                }
                else if (!checkExsist() && boxEmpty4)
                {
                    try
                    {
                        cmd = new SqlCommand($"INSERT INTO {tableSelected} VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("model created");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data not valied");
                        con.Close();
                    }

                }
/*                else if (!checkExsist(tables[2]) && tableSelected == tables[2] && boxEmpty6)
                {
                    try
                    {
                        cmd = new SqlCommand($"INSERT INTO {tableSelected} VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("customer created");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data not valied");
                        con.Close();
                    }

                }
*/                else
                {
                    MessageBox.Show("primary key is used or data not valed");
                }
            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }
            refreshTable();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            bool boxEmpty3 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "";
            bool boxEmpty4 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "";
            bool boxEmpty5 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""
                                 && textBox5.Text != "";
            bool boxEmpty6 = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""
                                 && textBox5.Text != "" && textBox6.Text != "";


            if (boxEmpty4)
            {
                if (!checkExsist())
                {
                    MessageBox.Show("ID not exist");
                }
                else
                {
                    try
                    {
                        if (tableSelected == tables[0])
                            cmd = new SqlCommand($"UPDATE {tableSelected} SET model = '{textBox2.Text}', color = '{textBox3.Text}'" +
                                $", cost = '{textBox4.Text}', offer = '{textBox5.Text}', quantity = '{textBox6.Text}' WHERE id = '{textBox1.Text}';", con);
                        else if (tableSelected == tables[1])
                            cmd = new SqlCommand($"UPDATE {tableSelected} SET model = '{textBox1.Text}', speed = '{textBox2.Text}'" +
                                $", year = '{textBox3.Text}', catagoryId = '{textBox4.Text}' WHERE model = '{textBox1.Text}';", con);


/*                        else if (tableSelected == tables[2])
                            cmd = new SqlCommand($"UPDATE {tableSelected} SET Date = '{textBox2.Text}', userAccount = '{textBox3.Text}'" +
                                $", customer_Ssn = '{textBox4.Text}', carId = '{textBox5.Text}' WHERE id = '{textBox1.Text}';", con);
*/                       

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("row Updated");
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("pls enter valed data");
                    }
                }
            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }
            refreshTable();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (checkExsist())
                {
                    if (tableSelected == tables[0])
                        cmd = new SqlCommand($"delete from {tableSelected} where id = '{textBox1.Text}';", con);
                    else if (tableSelected == tables[1])
                        cmd = new SqlCommand($"delete from {tableSelected} where model = '{textBox1.Text}';", con);
                    else if (tableSelected == tables[2])
                        cmd = new SqlCommand($"delete from {tableSelected} where imageID = '{textBox1.Text}';", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("delete done");
                }
                else
                {
                    MessageBox.Show("error : row not exists or related to other table");
                    return;
                }

            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }
            refreshTable();
        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void back_Click(object sender, EventArgs e)
        {
            Car_list frm2 = new Car_list();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();

            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (tableSelected == tables[0])
                cmd = new SqlCommand($"select * from {tableSelected} WHERE model LIKE '%{searchBox.Text}%' or id LIKE '%{searchBox.Text}%';", con);
            else if (tableSelected == tables[1])
                cmd = new SqlCommand($"select * from {tableSelected} WHERE model LIKE '%{searchBox.Text}%' or catagoryId LIKE '%{searchBox.Text}%';", con);

            else if (tableSelected == tables[2])
                cmd = new SqlCommand($"select * from {tableSelected} WHERE modelid LIKE '%{searchBox.Text}%'d or model LIKE '%{searchBox.Text}%';", con);

            newTableData(cmd);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

