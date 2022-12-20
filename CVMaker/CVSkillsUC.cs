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
    public partial class CVSkillsUC : UserControl
    {
        public CVSkillsUC()
        {
            InitializeComponent();
        }
        public CVSkillsUC(string title, string level)
        {
            InitializeComponent();
            Skilltitle.Text = title;
            Skilllevel.Text = level;
        }
    }
}
