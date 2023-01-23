using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_X
{
    public partial class Car_list : Form
    {
        SqlConnection con = new SqlConnection(Program.sqlConnection);
        SqlCommand cmd;
        List<Car> cars = new List<Car>();
        List<UserControlCar> products = new List<UserControlCar>();

        string tableName = "CarsDetails";

        string udsername = Program.name;
        int accountAccs = Program.accountAccs;
        public Car_list()
        {
            InitializeComponent();
            User_Name.Text = $"Welcome {udsername} ({accountAccs})";
            switch (accountAccs)
            {
                case 1:
                    sublayer.Visible = true;
                    bills.Visible = true;
                    admin.Visible = true;
                    break;
                case 2:
                    bills.Visible = true;
                    break;
                case 3:
                    sublayer.Visible = true;
                    break;
            }
            LoadProductsql($"SELECT * FROM {tableName};");

        }
        /// <summary>
        /// get all cars data from the DB
        /// </summary>
        /// <param name="cmdString"></param>
        public void GetListData(string cmdString)
        {
            SqlConnection conn = new SqlConnection(Program.sqlConnection);
            SqlCommand cmmd = new SqlCommand(cmdString, conn);
            conn.Open();
            SqlDataReader rdr = cmmd.ExecuteReader();
            if (rdr.HasRows)
            {
                Car car;
                NoData.Visible = false;

                while (rdr.Read())
                {
                    car = new Car();

                    car.CarID = (int)rdr["id"];
                    car.CarModel = rdr["model"].ToString();
                    car.CarQuantity = (int)rdr["quantity"];
                    car.CarCost = (decimal)rdr["cost"];
                    car.carSpeed = (int)rdr["speed"];
                    car.carYear = (int)rdr["year"];
                    car.CarColors = rdr["color"].ToString();
                    car.offer = (decimal)rdr["offer"];


                    /*                    Byte[] byteBLOBData = new Byte[0];
                                        byteBLOBData = (Byte[])((byte[])rdr["image"]);
                                        System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                                        car.CarImages = System.Drawing.Image.FromStream(ms);
                    */


                    cars.Add(car);
                }
            }
            else
            {
                NoData.ForeColor = Color.Red;
                NoData.Visible = true;
                //NoData.VisibleChanged(true);
            }
            conn.Close();
        }
        private Image Getmages(string year , string carModel)
        {
            SqlConnection connection2 = new SqlConnection(Program.sqlConnection);
            string q = $"select * from CarsImages where model = '{carModel}';";
            connection2.Open();
            SqlCommand cmmd = new SqlCommand(q, connection2);
            SqlDataReader reader = cmmd.ExecuteReader();

            if (reader.Read() && reader.HasRows)
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])((byte[])reader["img"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                connection2.Close();
                return System.Drawing.Image.FromStream(ms);
            }
            else
            {
                connection2.Close();
                string fileName = "nocar.jpeg";
                //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                return Image.FromFile(fileName);
            }

        }
        private void LoadProductsql(string cmdstring)
        {
            cars.Clear();
            products.Clear();
            flowLayoutPanel1.Controls.Clear();
            GetListData(cmdstring);
            if (cars.IsNullOrEmpty()&& NoData.Visible == true)
                return;

            UserControlCar userCar;
            foreach (Car item in cars)
            {
                userCar = new UserControlCar();

                userCar.CarID = item.CarID.ToString();
                userCar.CarModel = item.CarModel;
                userCar.CarQuantity = item.CarQuantity.ToString();
                userCar.CarCost = item.CarCost.ToString() + " $";
                userCar.carSpeed = item.carSpeed.ToString();
                userCar.carYear = item.carYear.ToString();
                userCar.CarColors = item.CarColors;

                if (item.offer == (decimal)-1.00)
                {
                    userCar.offer = null;
                }
                else
                {
                    userCar.offer = item.offer.ToString();
                }


                /*                userCar.image = Image.FromFile("C:\\Users\\ytgsa\\Desktop\\Cars Project\\2022 Mercedes Benz CLA-Class.jpg");
                                               string tt = $"{rdr["model"]}  {rdr["img"]}";
                                                Image img = (Image)rdr["img"];
                                               userCar.image = (Image)rdr["img"];
                */

                //string fileName = "nocar.jpeg";
                //userCar.image = item.CarImages==null ? Image.FromFile(fileName) : item.CarImages;
                userCar.image = Getmages(userCar.carYear, userCar.CarModel);
                products.Add(userCar);

            }

            flowLayoutPanel1.Controls.Clear();
            foreach (UserControlCar item in products)
            {
                flowLayoutPanel1.Controls.Add(item);
            }

        }
        private void logout_Click(object sender, EventArgs e)
        {
            Login_Form frm2 = new Login_Form();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }
        private void admin_Click(object sender, EventArgs e)
        {
            Admin frm2 = new Admin();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            LoadProductsql($"select * from {tableName} WHERE model LIKE '%{searchBox.Text}% ';");
        }

        public void reset_Click(object sender, EventArgs e)
        {
            LoadProductsql($"select * from {tableName}");
        }
        public void rr()
        {
            LoadProductsql($"select * from {tableName};");
        }

        private void closeapp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void higherprice_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} ORDER BY cost DESC;");
        }

        private void lowerprice_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} ORDER BY cost ASC;");
        }
        private void applyYearBox_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProductsql($"SELECT * FROM {tableName} where year > '{yearBox1.Text}' and year < '{yearBox2.Text}' ORDER BY year;");
            }
            catch (Exception)
            {
                LoadProductsql($"select * from {tableName} ;");
                MessageBox.Show("pls enter valed value in year box");
            }
        }
        private void oldest_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} ORDER BY id;");
        }
        private void newest_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} ORDER BY id DESC;");
        }
        private void applyPriceBox_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProductsql($"SELECT *FROM {tableName} where cost > {priceBox1.Text} and cost < {priceBox2.Text} ORDER BY id DESC;");
            }
            catch (Exception)
            {
                LoadProductsql($"select * from {tableName} ;");
                MessageBox.Show("pls enter valed value in price box");
            }
        }
        private void inStokeButton_Click(object sender, EventArgs e)
        {
             LoadProductsql($"SELECT *FROM {tableName} where quantity > 0 ;");
        }
        private void outStokeButton_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} where quantity <= 0  ;");
        }
        private void offersButton_Click(object sender, EventArgs e)
        {
            LoadProductsql($"SELECT *FROM {tableName} where offer >= 0  ;");
        }
        private void closeapp_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void priceBox1_TextChanged(object sender, EventArgs e)
        {
            Regex year = new Regex(@"^[0-9]{4}$");
            if (year.IsMatch(yearBox1.Text))
            {
                yearBox1.BackColor = Color.LightGreen;
            }
            else
            {
                yearBox1.BackColor = Color.LightYellow;
            }

        }

        private void yearBox2_TextChanged(object sender, EventArgs e)
        {
            Regex year = new Regex(@"^[0-9]{4}$");
            if (year.IsMatch(yearBox2.Text))
            {
                yearBox2.BackColor = Color.LightGreen;
            }
            else
            {
                yearBox2.BackColor = Color.LightYellow;
            }

        }
        private void bills_Click(object sender, EventArgs e)
        {
            ShowBills form = new ShowBills();
            form.ShowDialog();
        }

        private void sublayer_Click(object sender, EventArgs e)
        {
            supplies frm2 = new supplies();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            changePass form = new changePass();
            form.ShowDialog();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
