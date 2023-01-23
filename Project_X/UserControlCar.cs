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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project_X
{
    public partial class UserControlCar : UserControl
    {
        public UserControlCar()
        {
            InitializeComponent();
        }
        public UserControlCar(string carID, string CarQuantity, string CarName, string CarCost, string CarColor, string offer)
        {
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        public string CarID
        { get; set; }
        public string carSpeed
        { get; set; }

        public string carYear
        {
            get => lbl_year.Text;
            set => lbl_year.Text = value;
        }
    

        public string CarModel
        {
            get => lbl_name.Text;
            set => lbl_name.Text = value;
        }

        public string CarQuantity
        {
            get => lbl_quantity.Text;
            set
            {
                if (value == "0")
                {
                    lbl_quantity.Text = "out of stock";
                    lbl_quantity.ForeColor = Color.Red;
                }
                else
                {
                    lbl_quantity.Text = value;
                }
            }
        }
        public string CarColors
        {
            get => lbl_color.Text;
            set => lbl_color.Text = value;
        }
        public string CarCost
        {
            get => lbl_price.Text;
            set => lbl_price.Text = value;
        }
        public string offer
        {
            get => lbl_offer.Text;
            set
            {
                if ((value != null))
                {
                    lbl_offer.Visible = true;
                    label4.Visible = true;
                    lbl_offer.Text = value + " $";
                    Font fnt = new Font(lbl_price.Font, FontStyle.Strikeout);
                    lbl_price.Font = fnt;
                    
                }
            }
        }

        public Image image
        {
            get => pictureBox1.BackgroundImage;
            set => pictureBox1.BackgroundImage = value;
        }
        private void refreshData(string cmdString)
        {
            SqlConnection conn = new SqlConnection(Program.sqlConnection);
            SqlCommand cmmd = new SqlCommand(cmdString, conn);

            conn.Open();
            SqlDataReader rdr = cmmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    CarModel = rdr["model"].ToString();
                    CarQuantity = rdr["quantity"].ToString();
                    CarCost = rdr["cost"].ToString();
                }
            }
            else
            {
                lbl_name.ForeColor = Color.Red;
                //NoData.VisibleChanged(true);
            }
            conn.Close();
        }


        private void product_control_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowCar Check = new ShowCar(CarID, CarModel, CarQuantity, CarCost, carSpeed, carYear, CarColors, image, offer);
            Check.ShowDialog();
            refreshData($"select * from CarsDetails where id = {CarID};");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowCar Check = new ShowCar(CarID, CarModel, CarQuantity, CarCost, carSpeed, carYear, CarColors, image,offer);
            Check.ShowDialog();
            refreshData($"select * from CarsDetails where id = {CarID};");

        }

        private void button48_Click(object sender, EventArgs e)
        {
            ShowCar Check = new ShowCar(CarID, CarModel, CarQuantity, CarCost, carSpeed, carYear, CarColors, image, offer);
            Check.ShowDialog();
            refreshData($"select * from CarsDetails where id = {CarID};");

        }

    }
}

