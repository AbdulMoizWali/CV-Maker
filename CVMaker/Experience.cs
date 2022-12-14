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
    public partial class Experience : UserControl
    {
        public Experience()
        {
            InitializeComponent();
        }

        public Experience(string Title, string start_date, string end_date)
        {
            InitializeComponent();
            titleexperience.Text = Title;
            start_experience.Text = start_date;
            end_experience.Text = end_date;
        }


        private void expericebtnclick(object sender, EventArgs e)
        {
            if (experiencepanel.Location.X <= 2)
            {
                for (int i = 0; i < 130; i += 2)
                {
                   experiencepanel.Location = new Point(i, 0);

                }
            }
            else
            {
                for (int i =70; i > 0; i -= 2)
                {
                    experiencepanel.Location = new Point(i, 0);
                }
            }
        }

        private void deleteexperience_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }
    }
}
