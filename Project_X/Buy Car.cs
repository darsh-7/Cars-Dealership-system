using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_X
{
    public partial class Buy_Car : Form
    {
        SqlConnection con = new SqlConnection(Program.sqlConnection);
        SqlCommand cmd;
        DateTime today = DateTime.Today;
        string carID;
        bool nameValed = false;
        bool idValed = false;
        bool phoneValed = false;
        bool emailValed = true;
        bool addressValed = false;
        public Buy_Car(string carID)
        {
            InitializeComponent();
            datelabel.Text = DateTime.Today.ToShortDateString();
            this.carID = carID;
            selar.Text = Program.name;
            radioMale.Checked = true;
        }
        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            Regex id = new Regex(@"^[0-9]{14}$");
            if (id.IsMatch(IDBox.Text))
            {
                IDBox.BackColor = Color.LightGreen;
                idValed = true;
            }
            else
            {
                IDBox.BackColor = Color.LightYellow;
                idValed = false;
            }

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            Regex name = new Regex("^[a-zA-Z - ]+$");
            if (name.IsMatch(nameBox.Text) && nameBox.Text.Length >= 11)
            {
                nameBox.BackColor = Color.LightGreen;
                nameValed = true;
            }
            else
            {
                nameBox.BackColor = Color.LightYellow;
                nameValed = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex name = new Regex("^[a-zA-Z - 1-9]+$");
            if (name.IsMatch(addressBox.Text) && addressBox.Text.Length >= 10)
            {
                addressBox.BackColor = Color.LightGreen;
                addressValed = true;
            }
            else
            {
                addressBox.BackColor = Color.LightYellow;
                addressValed = false;
            }

        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        private void emaiBbox_TextChanged(object sender, EventArgs e)
        {
            Regex validate_emailaddress = email_validation();
            if (validate_emailaddress.IsMatch(emaiBbox.Text))
            {
                emaiBbox.Focus();
                emaiBbox.BackColor = Color.LightGreen;
                emailValed = true;
            }
            else
            {
                emaiBbox.BackColor = Color.LightYellow;
                emailValed = false;
            }
            if (emaiBbox.Text == "")
            {
                emaiBbox.BackColor = Color.LightGreen;
                emailValed = true;
            }

        }

        private bool checkIDExsist()
        {

            try
            {
                SqlCommand cmd = new SqlCommand($"select * from customers where ssn = '{IDBox.Text}';", con);

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
        private bool checkCarExsist()
        {

            try
            {
                SqlCommand cmd = new SqlCommand($"select * from cars where id = '{carID}';", con);

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



        private void buy_Click(object sender, EventArgs e)
        {
            bool checkBoxs = nameBox.Text != "" && IDBox.Text != ""
                             && phoneBox.Text != "" && addressBox.Text != "";

            if (nameValed&& idValed && phoneValed && emailValed && addressValed && checkBoxs)
            {
                string radioValue = "";
                bool isChecked = radioMale.Checked;
                if (isChecked)
                    radioValue = radioMale.Text;
                else
                    radioValue = radioFemale.Text;

                if (!checkIDExsist())
                {
                    try
                    {
                        cmd = new SqlCommand($"INSERT INTO Customers VALUES ('{IDBox.Text}','{nameBox.Text}','{phoneBox.Text}','{addressBox.Text}','{emaiBbox.Text}','{radioValue}')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //MessageBox.Show("user created");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error cannot add the customer");
                        con.Close();
                        return;
                    }
                }
                if (!checkCarExsist())
                {
                    MessageBox.Show("Error wrong valuse carID not found");
                    return;
                }
                try
                {
                    SqlCommand cmd = new SqlCommand($"select * from cars where id = {carID} and quantity > 0;", con);
                    con.Open();

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();

                    if (!((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0)))
                    {
                        return;
                    } 

                }
                catch (Exception)
                {
                    MessageBox.Show("the car is not Exsist or out of stoke check later");
                    con.Close();
                    return;
                }

                try
                {
                    cmd = new SqlCommand($"UPDATE cars SET quantity = quantity-1 WHERE id = {carID};", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("error cannot find the car");
                    con.Close();
                    return;
                }

                try
                {
                    cmd = new SqlCommand($"INSERT INTO bills VALUES ('{today}','{Program.name}','{IDBox.Text}','{carID}')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("bill saved");
                    Close();
                }
                catch (Exception)
                {
                    cmd = new SqlCommand($"UPDATE cars SET quantity = quantity+1 WHERE id = {carID};", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("error cannot save the bill");
                }


            }
            else
            {
                MessageBox.Show("pls enter valed data");
            }

        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

            Regex phone = new Regex(@"^[0-9]{11}$");
            if (phone.IsMatch(phoneBox.Text))
            {
                phoneBox.BackColor = Color.LightGreen;
                phoneValed = true;
            }
            else
            {
                phoneBox.BackColor = Color.LightYellow;
                phoneValed = false;
            }
            /*            int result;
                        if (phoneBox.Text != "")
                        {
                            if (!int.TryParse(phoneBox.Text, out result))
                            {
                                phoneBox.Text = phoneBox.Text.Remove(phoneBox.Text.Length - 1, 1);
                                if (phoneBox.Text.Length>12)
                                {
                                    phoneBox.Text = phoneBox.Text.Remove(phoneBox.Text.Length - 1, 1);
                                }
                                if (true)
                                {

                                }
                                dataValed = false;
                            }
                        }
            */
        }

    }
}
