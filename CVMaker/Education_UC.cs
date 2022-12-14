using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVMaker
{
    public partial class Education_UC : UserControl
    {
        public Education_UC()
        {
            InitializeComponent();
        }

        public Education_UC(string title, string start_date, string end_date)
        {
            InitializeComponent();
            title_edu.Text = title;
            start_edu.Text = start_date;
            end_edu.Text = end_date;
        }

        private void pnlperson(object sender, EventArgs e)
        {
            
            if (roundedpanel1.Location.X <= 2)
            {
                for (int i = 0; i < 130; i += 2)
                {
                    roundedpanel1.Location = new Point(i, 0);
                    
                }
            }
            else
            {
                for (int i =70; i > 0; i -= 2)
                {
                    roundedpanel1.Location = new Point(i, 0);
                }
            }
        }

        private void deletebtnclick(object sender, EventArgs e)
        {
            this.Controls.Clear();
                this.Dispose();
          
            
        }

        private void panelll_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void roundedpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
