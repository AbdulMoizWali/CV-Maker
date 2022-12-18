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
    public partial class Experience : UserControl
    {
        public Experience()
        {
            InitializeComponent();
        }
        string exp_ID;
        public Experience(string Title, string start_date, string end_date)
        {
            InitializeComponent();
            titleexperience.Text = Title;
            start_experience.Text = start_date;
            end_experience.Text = end_date;
        }

        public Experience(string Title, string start_date, string end_date, string Exp_id)
        {
            InitializeComponent();
            titleexperience.Text = Title;
            start_experience.Text = start_date;
            end_experience.Text = end_date;
            expid.Text = Exp_id;
            exp_ID = expid.Text;
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
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\git\\CV-Maker\\CVMaker\\Cvmakerdb.mdf;Integrated Security=True";

            sqlcon.Open();
            this.Controls.Clear();
            this.Dispose();
            string query = "delete from Experience where ExperienceID = '" + exp_ID + "'";
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
