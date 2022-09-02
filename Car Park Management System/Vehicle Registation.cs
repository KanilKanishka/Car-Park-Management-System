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
    public partial class frmvehicleregister : Form
    {
        public frmvehicleregister()
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

        private void btnvehiclesubmit_Click(object sender, EventArgs e)
        {
           
            try
            {
                String VehicleType = txtvehiclecategory.Text;
                int Fees = int.Parse(txtcategoryfees.Text);
                int slots = int.Parse(txtparkingslots.Text);

                String DetailSubmit = "INSERT INTO Vehicle_Type values ('" + VehicleType + "'," + Fees + "," + slots + ")";


                SqlCommand cmd = new SqlCommand(DetailSubmit, con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully Saved"," ",MessageBoxButtons.OK);

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

        private void frmvehicleregister_Load(object sender, EventArgs e)
        {
            txtvehiclecategory.Text = adminpanel.GET1;
            txtcategoryfees.Text = adminpanel.GET2;
            txtparkingslots.Text = adminpanel.GET3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Vehicle_Type SET Fees=@MBC,Slots=@MBC1  WHERE Vehicle_Type=@MNUC;", con);
                cmd.Parameters.AddWithValue("@MNUC", txtvehiclecategory.Text);
                cmd.Parameters.AddWithValue("@MBC", txtcategoryfees.Text);
                cmd.Parameters.AddWithValue("@MBC1", txtparkingslots.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully Edited");


                con.Close();
                


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                
            }

            
        }
    }
}
