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
    public partial class ExperienceCV_UV : UserControl
    {
        public ExperienceCV_UV()
        {
            InitializeComponent();
        }

        public ExperienceCV_UV(string title, string company_name, string description, string start_date, string end_date)
        {

            InitializeComponent();
            start_dateCV.Text = start_date;
            end_dateCV.Text = end_date;
            company_nameCV.Text = company_name;
            titleCV.Text = title;
            descriptionCV.Text = description;
        }
    }
}
