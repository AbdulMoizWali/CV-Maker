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

namespace CVMaker
{
    public partial class SocialUC : UserControl
    {
        public SocialUC()
        {
            InitializeComponent();
        }
        string social_ID;
        public SocialUC(string Title)
        {
            InitializeComponent();
            title_social.Text = Title;

        }

        public SocialUC(string title, string social_id)
        {
            InitializeComponent();
            title_social.Text = title;
            socialid.Text = social_id;
            social_ID = socialid.Text;
        }

        private void roundedpanelsocial_Click(object sender, EventArgs e)
        {
            if (roundedpanelsocial.Location.X <= 2)
            {
                for (int i = 0; i < 130; i += 2)
                {
                    roundedpanelsocial.Location = new Point(i, 0);

                }
            }
            else
            {
                for (int i = 70; i > 0; i -= 2)
                {
                    roundedpanelsocial.Location = new Point(i, 0);
                }
            }
        }

        private void deletesocial_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=DESKTOP-616GIMI;Initial Catalog=\"CV Maker\";Integrated Security=True";

            sqlcon.Open();
            this.Controls.Clear();
            this.Dispose();
            string query = "delete from Social where SocialID = '" + social_ID + "'";
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
    }
}
