using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X
{
    public partial class UserControlImg : UserControl
    {
        public UserControlImg()
        {
            InitializeComponent();
        }


        public Image image
        {
            get => carImg.BackgroundImage;
            set => carImg.BackgroundImage = value;
        }

    }
}
