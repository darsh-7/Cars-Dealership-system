using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_X
{
    internal static class Program
    {
        static public string sqlConnection = "Server=localhost;data Source=.;Database=.;Initial Catalog=MotorEmpire;Trusted_Connection=True;TrustServerCertificate=True;";
        static public string name = "";
        static public int accountAccs = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());
        }
        static public void newuser(string namee, int role)
        {
            name = namee;
            accountAccs = role;
        }

    }
}
