using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;

namespace CVMaker
{
 
    public partial class adminForm2 : Form
    {
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public adminForm2()
        {
           
            InitializeComponent();
            this.FormClosing += Save_Logout_Entry;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            string TotalUsers = SQLConnect.GetValueFromTable("select count(UserID) as [Users] from [User]", "Users");
            textBox1.Text = TotalUsers;

            string TotalProfile = SQLConnect.GetValueFromTable("select count(ProfileID) as [Profiles] from [Profile]", "Profiles");
            textBox2.Text = TotalProfile;
        }

     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage2.Hide();
            tabPage3.Hide();
            tabPage1.Show();
         

        }

		#region Display

		private void button3_Click(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage3.Hide();
            tabPage2.Show();
            SQLConnect.ShowSQLDataOutputInGridView(
                SQLConnect.ProcedureQuery("Get_LoginLogs"),
                dataGridView1
            );
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SQLConnect.RemoveSQLCommand(
                SQLConnect.ProcedureQuery("Delete_User", richTextBox3.Text),
                null
            );
        }

        #endregion

        #region Admin Password Reset
        private void button5_Click(object sender, EventArgs e)
        {
            SQLConnect.UpdateSQLCommand(
                SQLConnect.ProcedureQuery("Update_User", richTextBox1.Text, richTextBox2.Text)
            );
        }

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage2.Hide();
            tabPage3.Show();
        }
        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
            button1.BackColor = Color.White; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            tabPage3.BackColor = Color.White;
            tabPage3.ForeColor = Color.White;
        
            
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.White;
            tabPage1.ForeColor = Color.White;
          
            
        }
       
            private void tabPage2_Click(object sender, EventArgs e)
        {
            tabPage2.BackColor = Color.White;
            tabPage2.ForeColor = Color.White;
           
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        #region Logout
        private void Logout_Click(object sender, EventArgs e)
        {
            Save_Logout_Entry(sender, e);
            Formlogin formlogin = new Formlogin();
            formlogin.Show();
            this.Close();
        }


        private void Save_Logout_Entry(object sender, EventArgs e)
        {
            SQLConnect.InsertSQLCommand(
                   SQLConnect.ProcedureQuery("Insert_LoginLogs_Logouttime"),
                   false
           );
            this.FormClosing -= Save_Logout_Entry;
        }
		#endregion

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		
	}
}
