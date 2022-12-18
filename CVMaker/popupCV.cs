using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CVMaker
{
    public partial class popupCV : Profile
    {
            Profile profile = new Profile();


        public popupCV()
        {

            InitializeComponent();

            label21.Text += profile.First_name + profile.Last_name + "\n";
            genderCV.Text += profile.Gender + "\n";
            countryCV.Text += profile.Country + "\n";
            cityCV.Text += profile.City + "\n";
            phoneCV.Text += profile.Phone + "\n";
            pictureBox1.Image = profile.ProfilePic;

            for (int i = 0; i < profile.Socials.Count; i++)
            {
                linkLabel1.Text += profile.Socials[i].Link + "\n";
            }


            for (int i = 0; i < profile.Skills.Count; i++)
            {
                label7.Text += profile.Skills[i].Title + "\n";
                label1.Text += profile.Skills[i].Level + "\n";
            }

            for (int i = 0; i < profile.Experiences.Count; i++)
            {
            
                ExperienceCV_UV exp_UC = new ExperienceCV_UV(profile.Experiences[i].Title,
                    profile.Experiences[i].CompanyName, profile.Experiences[i].Description,
                    profile.Experiences[i].StartingDate, profile.Experiences[i].EndingDate);
                exp_UC.Dock = DockStyle.Top;
                panel4.Controls.Add(exp_UC);
                exp_UC.BringToFront();

            }


            for (int i = 0; i < profile.Educations.Count; i++)
            {
                
                EducationCV_UC edu_UC = new EducationCV_UC(profile.Educations[i].Title, 
                profile.Educations[i].Institute, profile.Educations[i].StartingDate, 
                profile.Educations[i].EndingDate);
                edu_UC.Dock = DockStyle.Top;
                panel3.Controls.Add(edu_UC);
                edu_UC.BringToFront();

            }
           

        }

        
     
     
        private void popupCV_Load(object sender, EventArgs e)
        {
          
        }




        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }


        private Bitmap memoryimp;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimp, 0, this.panel1.Location.Y);
        }

        private void getprintarea(Panel pnl)
        {
            memoryimp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimp, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }
    }
    
}
