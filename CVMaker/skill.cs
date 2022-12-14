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
    public partial class skill : UserControl
    {
        public skill()
        {
            InitializeComponent();
        }

        public skill(string Title, string level)
        {
            InitializeComponent();
            title_skill.Text = Title;
            level_skill.Text = level;
        }

        private void deleteskill_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }

        private void level_skill_Click(object sender, EventArgs e)
        {

        }

        private void skillbuttonclick(object sender, EventArgs e)
        {
            if (roundedpanelskill.Location.X <= 2)
            {
                for (int i = 0; i < 130; i += 2)
                {
                    roundedpanelskill.Location = new Point(i, 0);

                }
            }
            else
            {
                for (int i = 70; i > 0; i -= 2)
                {
                    roundedpanelskill.Location = new Point(i, 0);
                }
            }
        }

        private void panelskill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
