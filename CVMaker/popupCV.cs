using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CVMaker
{
    public partial class popupCV : Form
    {


        public popupCV()
        {
            InitializeComponent();
            dp = displaybox;
            dp.Show();
            
        }
        public static PictureBox dp;
    }
    
}
