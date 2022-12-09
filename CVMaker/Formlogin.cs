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
    public partial class Formlogin : Form
    {
        public Point mouseLocation;
        public Formlogin()
        {
            InitializeComponent();
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formregister f1 = new Formregister();
            f1.Show();
            f1.Opacity = 100;

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePose;
            }
            
        }

        private void checkboxpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       /* private void label4_Click(object sender, EventArgs e)
        {
            Formregister f2 = new Formregister();
            f2.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }*/
    }
}
