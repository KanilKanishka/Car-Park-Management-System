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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=KANIL-PC;Initial Catalog=car_park_management;Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {
            frmvehicleregister form = new frmvehicleregister();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmstaffregister form = new frmstaffregister();
            form.Show();
            this.Hide();
        }

        

        private void adminpanel_Load(object sender, EventArgs e)
        {
            display_staffdata();
            display_vehicledata();
        }

        public void display_staffdata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void display_vehicledata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Vehicle_type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void btnmainmenu2_Click(object sender, EventArgs e)
        {
            frmmainmenu from = new frmmainmenu();
            from.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string qry = "delete from Vehicle_Type where Vehicle_Type = '" + GET1 + "'";

                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show("Complete");

                con.Close();
                display_vehicledata();
            }

            catch (System.Exception exp)
            {
                MessageBox.Show("error is " + exp.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();

                string qry = "delete from Staff where Staff_ID = '" + GET4 + "'";

                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show("Complete");

                con.Close();
                display_vehicledata();
            }

            catch (System.Exception exp)
            {
                MessageBox.Show("error is " + exp.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmvehicleregister form = new frmvehicleregister();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmstaffregister form = new frmstaffregister();
            form.Show();
            this.Hide();
        }

        public static string GET1 = "";
        public static string GET2 = "";
        public static string GET3 = "";
        public static string GET4 = "";
        public static string GET5 = "";
        public static string GET6 = "";
        public static string GET7 = "";
        public static string GET8 = "";




        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string A, B, C, G, H;
            try
            {
                A = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                B = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                C = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                G = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                H = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();

                GET1 = A;
                GET2 = B;
                GET3 = C;
                GET2 = G;
                GET3 = H;

                
            }
            catch (System.Exception)
            {
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string D, E, F;
            try
            {
                D = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                E = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                F = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                GET4 = D;
                GET5 = E;
                GET6 = F;
                
            }
            catch (System.Exception)
            {
            }
        }
    }

}
