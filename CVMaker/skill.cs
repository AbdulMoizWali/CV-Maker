using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CVMaker
{
    public partial class skill : UserControl
    {
        public skill()
        {
            InitializeComponent();
        }
        string skill_ID;
        public skill(string Title, string level)
        {
            InitializeComponent();
            title_skill.Text = Title;
            level_skill.Text = level;
        }

        public skill(string title, string level, string skill_id)
        {
            InitializeComponent();
            title_skill.Text = title;
            level_skill.Text = level;
            skillid.Text = skill_id;
            skill_ID = skillid.Text;
        }

        private void deleteskill_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=DESKTOP-616GIMI;Initial Catalog=\"CV Maker\";Integrated Security=True";

            sqlcon.Open();
            this.Controls.Clear();
            this.Dispose();
            string query = "delete from Skills where SkillID = '" + skill_ID + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();

            if (a != -1)
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
         
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
