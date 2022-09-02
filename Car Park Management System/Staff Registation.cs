using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Park_Management_System
{
    public partial class frmstaffregister : Form
    {
        public frmstaffregister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=KANIL-PC;Initial Catalog=car_park_management;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            adminpanel from = new adminpanel();
            from.Show();
            this.Hide();
        }

        private void btnstaffsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String Staff_ID = txtstaffid.Text;
                String Name = txtstaffname.Text;
                String Position = txtposts.Text;
                String Username = txtuser.Text;
                String Password = txtpass.Text;
                con.Open();
                String DetailSubmit = "INSERT INTO Staff values('" + Staff_ID + "','" + Name + "','" + Position + "','" + Username + "','" + Password + "')";


                SqlCommand cmd = new SqlCommand(DetailSubmit, con);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully Saved", " ", MessageBoxButtons.OK);

                con.Close();
                adminpanel from = new adminpanel();
                from.Show();
                this.Hide();

            }
            catch (Exception er)
            {

                MessageBox.Show("Error submit" + er);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Staff SET Name=@MBC2,Position=@MBC3,Username=@MBC8,password=@MBC9  WHERE Staff_ID=@MNUC4;", con);
                cmd.Parameters.AddWithValue("@MNUC4", txtstaffid.Text);
                cmd.Parameters.AddWithValue("@MBC2", txtstaffname.Text);
                cmd.Parameters.AddWithValue("@MBC3", txtposts.Text);
                cmd.Parameters.AddWithValue("@MBC8", txtuser.Text);
                cmd.Parameters.AddWithValue("@MBC9", txtpass.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully Edited");


                con.Close();
                


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                
            }

           
        }

        private void frmstaffregister_Load(object sender, EventArgs e)
        {
            txtstaffid.Text = adminpanel.GET4;
            txtstaffname.Text = adminpanel.GET5;
            txtposts.Text = adminpanel.GET6;
            txtuser.Text = adminpanel.GET7;
            txtpass.Text = adminpanel.GET8;
        }
    }
}
