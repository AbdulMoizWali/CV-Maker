﻿using System;
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
	public partial class Formregister : Form
	{
		public Point mouseLocation;
        
        public Formregister()
		{
           
            InitializeComponent();
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
                Location = mousePose;
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formlogin f2 = new Formlogin();
            f2.Show();

            
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Formlogin f2 = new Formlogin();
            f2.Hide();
        }
       

        private void mouse_Up(object sender, MouseEventArgs e)
        {
           





        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void Formregister_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timerspa.Start();
        }

        private void timerspa_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else 
            {
                timerspa.Stop();
            }
        }
    }

}
