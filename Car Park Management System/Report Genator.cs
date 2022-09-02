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
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace Car_Park_Management_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            display_Parkingdata();
        }
        SqlConnection con2 = new SqlConnection(@"Data Source=KANIL-PC;Initial Catalog=car_park_management;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmainmenu from = new frmmainmenu();
            from.Show();
            this.Hide();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        public void display_Parkingdata()
        {
            con2.Open();
            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Report";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            con2.Open();
            if (type.Text == "All")
            {
                SqlCommand cmd = new SqlCommand("select * from Report where date between @fromdate and @todate", con2);

                cmd.Parameters.AddWithValue("@fromdate", fromdate.Value);
                cmd.Parameters.AddWithValue("@todate", todate.Value);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds, "tbldate");
                dataGridView1.DataSource = ds.Tables["tbldate"];

                SqlDataReader rdr = cmd.ExecuteReader();

                int total_amount = 0;

                while (rdr.Read())
                {
                    total_amount +=  int.Parse(rdr["amount"].ToString());
                }

                Console.WriteLine(total_amount);

            }

            else
            {
                SqlCommand cmd = new SqlCommand("select * from Report where date between @fromdate and @todate AND Vehicle_type=@vtype", con2);
                cmd.Parameters.AddWithValue("@fromdate", fromdate.Value);
                cmd.Parameters.AddWithValue("@todate", todate.Value);
                cmd.Parameters.AddWithValue("@vtype", type.Text);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds, "tbldate");
                dataGridView1.DataSource = ds.Tables["tbldate"];

                SqlDataReader rdr = cmd.ExecuteReader();

                int total_amount = 0;

                while (rdr.Read())
                {
                    total_amount += int.Parse(rdr["amount"].ToString());
                }

                Console.WriteLine(total_amount);
            }

            
            con2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(new Phrase(dcell.Value.ToString()));

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();
                                fileStream.Close();

                            }







                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);
                            Console.WriteLine(ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }
    }
    }

