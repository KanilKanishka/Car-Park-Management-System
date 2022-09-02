using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Park_Management_System
{
    public partial class login : Form
    {
        double count;
        
        public login()

        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "admin";
            pass = "admin";

            if ((txtusername.Text == user) && (txtpassword.Text == pass))
            {
                frmmainmenu from = new frmmainmenu();
                from.Show();
                this.Hide();
            }
            else
            {
                count = count + 1;
                double maxcount = 5;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Invalid User name or Password");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded");
                    Application.Exit();
                }

            }
        }

        private void btnend_Click(object sender, EventArgs e)
        {
           
            this.Close();

            //this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
