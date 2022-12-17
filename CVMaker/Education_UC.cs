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
using System.Data.SqlClient;
using System.Data;

namespace CVMaker
{
    public partial class Education_UC : UserControl
    {
        public Education_UC()
        {
            InitializeComponent();
        }
        string eduid1;
        public Education_UC(string title, string start_date, string end_date,string EducationID)
        {
            InitializeComponent();
            title_edu.Text = title;
            start_edu.Text = start_date;
            end_edu.Text = end_date;
            eduid.Text = EducationID;
            eduid1 = eduid.Text;
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
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=DESKTOP-M29OVEL;Initial Catalog=\"CV Maker\";Integrated Security=TrueData Source=DESKTOP-M29OVEL;Initial Catalog=\"CV Maker\";Integrated Security=True";
        
        sqlcon.Open();
            this.Controls.Clear();
            this.Dispose();
            string query = "delete from Education where EducationID = '" + eduid1 + "'";
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

        private void panelll_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void roundedpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
