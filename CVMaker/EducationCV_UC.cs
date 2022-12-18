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
    public partial class EducationCV_UC : UserControl
    {
        public string title, institute, start_date, end_date;
        public EducationCV_UC()
        {
            InitializeComponent();

        }
        public EducationCV_UC(string title, string institute, string start_date, string end_date)
        {
            InitializeComponent();
            title_edu_CV.Text = title;
            institute_edu_CV.Text = institute;
            start_edu_CV.Text = start_date;
            end_edu_CV.Text = end_date;
        }

    }
}
