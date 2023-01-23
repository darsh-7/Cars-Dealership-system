using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_X
{
    public partial class ShowCar : Form
    {
        string carID;
        List<UserControlImg> carImages = new List<UserControlImg>();
        string CarYear;
        string CarModel;

        public ShowCar(string carID, string CarModel, string CarQuantity, string CarCost, string CarSpeed, string CarYear, string CarColor, Image Image, string offer)
        {
            InitializeComponent();
            if ((offer != "offer"))
            {
                lbl_offer.Visible = true;
                label8.Visible = true;
                lbl_offer.Text = offer ;
                Font fnt = new Font(carcost.Font, FontStyle.Strikeout);
                carcost.Font = fnt;
            }
            if (Program.accountAccs > 2)
                Buy.BackColor = Color.DimGray;

            DateTime today = DateTime.Today;
            Date.Text = DateTime.Today.ToShortDateString();
            this.carID = carID;
            this.CarModel = CarModel;
            this.CarYear = CarYear;
            IDlabel.Text = carID;
            carModel.Text = CarModel;
            if (CarQuantity == "0")
            {
                quantity.Text = "out of stock";
                quantity.ForeColor = Color.Red;
            }
            else
                quantity.Text = CarQuantity;
            carSpeed.Text = CarSpeed;
            carYear.Text = CarYear;
            carcost.Text = CarCost;
            colorlabel.Text = CarColor;

            // picture.Image = Image;
            getImages();
        }
        private void getImages()
        {
            string cmdString = $"SELECT * FROM CarsImages where model ='{CarModel}';";
            SqlConnection conn = new SqlConnection(Program.sqlConnection);
            SqlCommand cmmd = new SqlCommand(cmdString, conn);

            conn.Open();
            SqlDataReader reader = cmmd.ExecuteReader();
            UserControlImg userControl;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userControl = new UserControlImg();

                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])((byte[])reader["img"]);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);

                    userControl.image = System.Drawing.Image.FromStream(ms);

                    carImages.Add(userControl);
                }

            }
            else
            {
                nodata.ForeColor = Color.Red;
                nodata.Visible = true;
            }
            conn.Close();

            foreach (UserControlImg item in carImages)
            {
                flowLayoutPanel1.Controls.Add(item);
            }

        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (Program.accountAccs > 2)
            {
                return;
            }
            else if (quantity.Text == "out of stock")

            {
                MessageBox.Show("the car is out of stock check later");
            }
            else
            {
                Buy_Car BuyCar = new Buy_Car(carID);
                BuyCar.ShowDialog();
                this.Hide();
            }
        }

    }
}
