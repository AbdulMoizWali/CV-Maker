using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;

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

		private void register_Click(object sender, EventArgs e)
		{
            bool user = SQLConnect.SearchinTable("select username from [User]", "username", textBox1);
            bool pass = SQLConnect.SearchinTable("select password from [User]", "password", textBox2);
            if(user && pass)
			{
                string role = SQLConnect.GetValueFromTable(
                    "select Role from [User] where username = '" +
                    textBox1.Text + "' and password = '" + textBox2.Text + "'",
                    "Role"
                );


                SQLConnect.InsertSQLCommand(
                    SQLConnect.ProcedureQuery("Insert_LoginLogs", textBox1.Text, textBox2.Text, DateTime.Now.ToString()),
                    false
                );

                if(role == "Admin")
				{
                    adminForm2 admin = new adminForm2();
                    admin.Show();
				}
				else
				{
                    CV cV = new CV();
                    cV.Show();
				}
                this.Close();
			}
			else
			{
                MessageBox.Show("Username or Password incorrect!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void checkboxpass_CheckedChanged(object sender, EventArgs e)
		{
			if (checkboxpass.Checked)
			{
                textBox2.PasswordChar = '\0';
            }
			else
			{
                textBox2.PasswordChar = '*';
			}
		}
	}
}
