﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SQL;

namespace CVMaker
{
    public partial class CV : Form
    {


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );

        public CV()
        {
            InitializeComponent();
            this.FormClosing += Save_Logout_Entry;
            CVtopopup1();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }
        public void CVtopopup1()
        {
            pictureBox5.ImageLocation = @"F:\cv maker project\source\repos\CV-Maker\images\cv2.jpg";
            popupCV.dp.ImageLocation = @"F:\cv maker project\source\repos\CV-Maker\images\cv2.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage2.Show();
            button2.BackColor = Color.DeepSkyBlue;
            button6.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DodgerBlue;
            button1.BackColor = Color.DodgerBlue;

        }
        private bool display1WasClicked = false;

        popupCV ab = new popupCV();

        private void displaydoubleclick(object sender, EventArgs e)
        {
            if (ab.IsDisposed == true)
            {
                ab = new popupCV();
            }
            ab.Show();
            CVtopopup1();



        }

        private void displaydoubleclick2(object sender, EventArgs e)
        {
            if (ab.IsDisposed == true)
            {
                ab = new popupCV();
            }
            ab.Show();
            popupCV.dp.ImageLocation = @"F:\cv maker project\source\repos\CV-Maker\images\cv1.jpg";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }

        private void label17_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void saveedu_Click(object sender, EventArgs e)
        {
            panaledu.Height = 50;
            UC person1 = new UC();
            person1.title_edu.Text = edu_name.Text;
            person1.start_edu.Text = edu_st_date.Value.ToString("mm/dd/yyyy");
            person1.end_edu.Text = edu_end_date.Value.ToString("mm/dd/yyyy");
            flowLayoutPaneledu.Controls.Add(person1);
            flowLayoutPaneledu.Controls.IndexOf(person1);

        }

        private void canceledu_Click(object sender, EventArgs e)
        {
            panaledu.Height = 50;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panaledu.Height = 260;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabPage3.Hide();
            tabPage2.Hide();
            tabPage1.Hide();
            tabPage4.Hide();
            tabPage6.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabPage3.Hide();
            tabPage2.Hide();
            tabPage1.Show();
            tabPage4.Hide();
            tabPage6.Hide();
            button2.BackColor = Color.DodgerBlue;
            button6.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.DodgerBlue;
            button1.BackColor = Color.DodgerBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabPage3.Show();
            tabPage2.Hide();
            tabPage1.Hide();
            tabPage4.Hide();
            tabPage6.Hide();
            button2.BackColor = Color.DodgerBlue;
            button6.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DeepSkyBlue;
            button1.BackColor = Color.DodgerBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage3.Hide();
            tabPage2.Hide();
            tabPage1.Hide();
            tabPage4.Show();
            tabPage6.Hide();
            button2.BackColor = Color.DodgerBlue;
            button6.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DodgerBlue;
            button1.BackColor = Color.DeepSkyBlue;
        }
        //skill link
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabPage6.Hide();
            tabPage8.Hide();
            tabPage5.Show();
            tabPage4.Hide();
            tabPage3.Hide();
            tabPage7.Hide();
            tabPage2.Hide();
            tabPage1.Hide();
        }

        private void addskill_Click(object sender, EventArgs e)
        {
            panelskill.Height = 260;
        }

        private void cancelskill_Click(object sender, EventArgs e)
        {
            panelskill.Height = 50;
        }

        private void saveskill_Click(object sender, EventArgs e)
        {
            panelskill.Height = 50;
            skill person1 = new skill();
            person1.title_skill.Text = Title_Skill.Text;
            flowLayoutPanelskill.Controls.Add(person1);

        }

        private void Basic_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Fetch from Database
        private void CV_Load(object sender, EventArgs e)
        {

            /*for (int i = 0; i < 2; i++)
            {
                UC per = new UC();
                flowLayoutPaneledu.Controls.Add(per);
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabPage6.Hide();
            tabPage8.Hide();
            tabPage5.Hide();
            tabPage4.Hide();
            tabPage3.Hide();
            tabPage7.Show();
            tabPage2.Hide();
            tabPage1.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabPage6.Hide();
            tabPage8.Show();
            tabPage5.Hide();
            tabPage4.Hide();
            tabPage3.Hide();
            tabPage7.Hide();
            tabPage2.Hide();
            tabPage1.Hide();
        }

        private void experinceadd_Click(object sender, EventArgs e)
        {
            exper_panel.Height = 270;
        }

        private void save_exper_Click(object sender, EventArgs e)
        {
            exper_panel.Height = 50;
            Experience person3 = new Experience();
            person3.titleexperience.Text = Experiece_Title.Text;
            flowLayoutPanelexperience.Controls.Add(person3);
        }

        private void cancel_exper_Click(object sender, EventArgs e)
        {
            exper_panel.Height = 50;
        }

        private void flowLayoutPanelskill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to Exit", "Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {

            }
        }


		#region Profile

		#region Save
		private void Save_Profile_Click(object sender, EventArgs e)
		{
            string Gender = "";
			if (Male_Radio.Checked)
			{
                Gender = Male_Radio.Text;
			}
            else if (Female_Radio.Checked)
            {
                Gender = Female_Radio.Text;
            }
            byte[] pic = null;
            if (ProfilePic.Image != null)
			{
                MemoryStream stream = new MemoryStream();
                ProfilePic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = stream.ToArray();
			}
            SQLConnect.SQLCommand(
                SQLConnect.ProcedureQuery("Insert_Profile", First_Name.Text, Last_Name.Text, Gender, Country.Text, City.Text, Phone_Number.Text, "@ProfilePic"),
                "Profile Created and Information Added",
                "User has already created profile",
                null,
                "@ProfilePic",
                pic
            );
		}

        #endregion

        #region Edit

        private void Edit_Profile_Click(object sender, EventArgs e)
        {
            //Update_Profile
            string Gender = "";
            if (Male_Radio.Checked)
            {
                Gender = Male_Radio.Text;
            }
            else if (Female_Radio.Checked)
            {
                Gender = Female_Radio.Text;
            }
            byte[] pic = null;
            if (ProfilePic.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                ProfilePic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = stream.ToArray();
            }
            SQLConnect.UpdateSQLCommand(
                SQLConnect.ProcedureQuery("Update_Profile", First_Name.Text, Last_Name.Text, Gender, Country.Text, City.Text, Phone_Number.Text, "@ProfilePic"),
                null,
                "@ProfilePic",
                pic
            );
        }

        #endregion

        private void Upload_ProfilePic_Click(object sender, EventArgs e)
		{
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpe; *.jpeg; *.bmp) | *.jpg; *.jpeg; *.bmp";

			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				try
				{
                    if((stream = openFileDialog.OpenFile()) != null)
					{
                        string Filename = openFileDialog.FileName;
                        if(stream.Length > 512000)
						{
                            MessageBox.Show("File size limit reached!"); ;
						}
						else
						{
                            ProfilePic.Load(Filename);
						}
					}
				}
				catch
				{
                    MessageBox.Show("Error");
				}
			}
		}
		#endregion

		#region Logout
		private void Logout_User_Click(object sender, EventArgs e)
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
	}
}
