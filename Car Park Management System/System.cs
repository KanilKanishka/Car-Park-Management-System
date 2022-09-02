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
    public partial class frmsystem : Form

    {
        Timer t = new Timer();
        public frmsystem()
        {
            InitializeComponent();
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
            display_Parkingdata();
        }

        SqlConnection con2 = new SqlConnection(@"Data Source=KANIL-PC;Initial Catalog=car_park_management;Integrated Security=True");

       

        private void register_Load(object sender, EventArgs e)
        {
               


        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            frmmainmenu from = new frmmainmenu();
            from.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            label1.Text = time;
        }

        public void display_Parkingdata()
        {
            con2.Open();
            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Parking_Details";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
        }
       

        private void btntimein_Click(object sender, EventArgs e)
        {

            try
            {
                con2.Open();
                String VNumber = txtvehicle_number.Text;
                String VType = vehicletype.Text;

                DateTime TimeIn = DateTime.Now;
                
                String Status = "IN"; 

                String DetailSubmit = "INSERT INTO Parking_Details values('" + VNumber + "','" + VType + "','" + TimeIn + "','"+" "+"','" + Status + "')";


                SqlCommand cmd = new SqlCommand(DetailSubmit, con2);
                
                cmd.ExecuteNonQuery();


                slot_increase(VType);

               


            }
            catch (Exception er)
            {

                MessageBox.Show("Error submit" + er);

            }

            con2.Close();
            display_Parkingdata();
            

        }

        private void btntimeout_Click(object sender, EventArgs e)
        {
            con2.Open();
            String bb= "select Time_IN from Parking_Details where Vehicle_Number = '" + txtvehicle_number.Text + "'";
            SqlCommand cmd = new SqlCommand(bb,con2);
            SqlDataReader rdr = cmd.ExecuteReader();
            DateTime d1;
            double hours;
            if (rdr.Read())
            {
                string s = rdr["Time_IN"].ToString();
                d1 = DateTime.Parse(s);
                Console.WriteLine(d1);
                DateTime d2 = DateTime.Now;
    
                TimeSpan ts = d2 - d1;
                double result = ts.TotalHours;

                hours = Math.Round(result, 1);
                Console.WriteLine(hours);
                con2.Close();
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Parking_Details SET Time_OUT='" + d2 + "' WHERE Vehicle_Number='" + txtvehicle_number.Text + "';", con2);
                cmd2.ExecuteNonQuery();
                bill_calculate(hours);
                con2.Close();
                display_Parkingdata();
               

            }


            slot_decrease(vehicletype.Text);










        }

        public void bill_calculate(double hours)
        {
            
            String select_query2 = "select fees from Vehicle_Type  where Vehicle_Type = '" + vehicletype.Text + "'";
            SqlCommand cmd3 = new SqlCommand(select_query2, con2);
            SqlDataReader rdr = cmd3.ExecuteReader();

            if (rdr.Read())
            {
                string f =rdr["Fees"].ToString();
                int fee = int.Parse(f);

                int total_fee = (int)hours * fee;
                lblduration1.Text = hours.ToString();
                lblfees1.Text = total_fee.ToString();



            }

        }

        public void slot_increase(string vehicletype)
        {
            int count;
            int availble;
            
            if (vehicletype == "Bike")
            {
                count = int.Parse(bikeoccupied.Text);
                availble = int.Parse(bikeavailble.Text);
                count++;
                availble--;
                bikeoccupied.Text = count.ToString();
                bikeavailble.Text = availble.ToString();
            }

            if (vehicletype == "Car")
            {
                count = int.Parse(caroccupied.Text);
                availble = int.Parse(caravailble.Text);
                count++;
                availble--;
                caroccupied.Text = count.ToString();
                caravailble.Text = availble.ToString();
            }

            if (vehicletype == "Van")
            {
                count = int.Parse(vanoccupied.Text);
                availble = int.Parse(vanavailble.Text);
                count++;
                availble--;
                vanoccupied.Text = count.ToString();
                vanavailble.Text = availble.ToString();
            }

            if (vehicletype == "Bus")
            {
                count = int.Parse(busoccupied.Text);
                availble = int.Parse(busavailble.Text);
                count++;
                availble--;
                busoccupied.Text = count.ToString();
                busavailble.Text = availble.ToString();
            }


            if (vehicletype == "Lorry")
            {
                count = int.Parse(lorryoccupied.Text);
                availble = int.Parse(lorryavailble.Text);
                count++;
                availble--;
                lorryoccupied.Text = count.ToString();
                lorryavailble.Text = availble.ToString();
            }
        }


        public void slot_decrease(string vehicletype)
        {
            int count;
            int availble;

            if (vehicletype == "Bike")
            {
                count = int.Parse(bikeoccupied.Text);
                availble = int.Parse(bikeavailble.Text);
                count--;
                availble++;
                bikeoccupied.Text = count.ToString();
                bikeavailble.Text = availble.ToString();
            }

            if (vehicletype == "Car")
            {
                count = int.Parse(caroccupied.Text);
                availble = int.Parse(caravailble.Text);
                count--;
                availble++;
                caroccupied.Text = count.ToString();
                caravailble.Text = availble.ToString();
            }

            if (vehicletype == "Van")
            {
                count = int.Parse(vanoccupied.Text);
                availble = int.Parse(vanavailble.Text);
                count--;
                availble++;
                vanoccupied.Text = count.ToString();
                vanavailble.Text = availble.ToString();
            }

            if (vehicletype == "Bus")
            {
                count = int.Parse(busoccupied.Text);
                availble = int.Parse(busavailble.Text);
                count--;
                availble++;
                busoccupied.Text = count.ToString();
                busavailble.Text = availble.ToString();
            }


            if (vehicletype == "Lorry")
            {
                count = int.Parse(lorryoccupied.Text);
                availble = int.Parse(lorryavailble.Text);
                count--;
                availble++;
                lorryoccupied.Text = count.ToString();
                lorryavailble.Text = availble.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = dateTimePicker1.Value;
            TimeSpan ts = d2 - d1;
            double result = ts.TotalHours;

            double ss = Math.Round(result, 1);


            Console.WriteLine(ss);
            
        }

       

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtvehicle_number.Text = dataGridView1.Rows[e.RowIndex].Cells["Vehicle_Number"].FormattedValue.ToString();
                vehicletype.Text = dataGridView1.Rows[e.RowIndex].Cells["Vehicle_Type"].FormattedValue.ToString();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                con2.Open();

                string qry = "delete from Parking_Details  where Vehicle_Number = '" + txtvehicle_number.Text + "'";

                SqlCommand sc = new SqlCommand(qry, con2);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show(" Deleted ");

                con2.Close();
                display_Parkingdata();
            }

            catch (System.Exception exp)
            {
                MessageBox.Show("error is " + exp.ToString());
                
            }
        }
        string A;
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                
                con2.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Parking_Details SET Vehicle_Number=@MBC,Vehicle_Type=@MBC1 WHERE ID=@MNUC;", con2);
                cmd.Parameters.AddWithValue("@MNUC", A);
                cmd.Parameters.AddWithValue("@MBC", txtvehicle_number.Text);
                cmd.Parameters.AddWithValue("@MBC1", vehicletype.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully Edited");


                con2.Close();
                display_Parkingdata();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                MessageBox.Show(Ex.Message);
                }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        
        private void btnprintbill_Click(object sender, EventArgs e)
        {
            try
            {
                con2.Open();
                String VNumber = txtvehicle_number.Text;
                String VType = vehicletype.Text;

                DateTime TimeOUT = DateTime.Now;

                int Amount = int.Parse(lblfees1.Text);

                String DetailSubmit = "INSERT INTO Report values('" + VNumber + "','" + VType + "','" + TimeOUT + "','" +Amount  + "')";


                SqlCommand cmd = new SqlCommand(DetailSubmit, con2);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"INVOICE\nHours:{lblduration1.Text}\nTotal Amount:{Amount}" );





            }
            catch (Exception er)
            {

                MessageBox.Show("Error submit" + er);

            }

            con2.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
