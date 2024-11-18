using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp_SampleProject_C
{
    public partial class PassengerFlightInfo : Form
    {
        int basicPrice;
        public PassengerFlightInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment f1 = new Payment();
            f1.TopLevel = false;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Size = this.Size;
            f1.BringToFront();
            f1.Visible = true;
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Parent.Controls.Add(f1);
            this.Parent.Controls.Remove(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void reload()
        {
            try
            {
                string sql = "select date, source, Destination, Serial_Number_Plane, price from Flight where Flight_id = '" + label8.Text.Substring(7) + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                label2.Text = reader[0] + "";
                label3.Text = reader[1] + "";
                label4.Text = reader[2] + "";
                label6.Text = reader[3] + "";

                


                label5.Text = (Convert.ToInt32(reader[4]) * 0.3) + "";
                label7.Text = (Convert.ToInt32(reader[4]) * 0.4) + "";
                label1.Text = reader[4] + "";



                basicPrice = Convert.ToInt32(reader[4]);
                reader.Close();





                string sql2 = "select SeatNumber from Seat where Serial_Number_Plane = '" + label8.Text + "' and SeatNumber not in (select SeatNumber from ticket where Flight_id = '"+label8.Text.Substring(7)+ "' and status = 1)";
                
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                

                while (reader2.Read())
                {
                    comboBox1.Items.Add(reader2[0]);
                }

               
                reader2.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong date");
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlightList f1 = new FlightList();
            f1.TopLevel = false;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Size = this.Size;
            f1.BringToFront();
            f1.Visible = true;
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Parent.Controls.Add(f1);
            this.Parent.Controls.Remove(this);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = basicPrice.ToString();
            label1.Text = (Convert.ToInt32(label1.Text) + Convert.ToInt32(comboBox2.Text)) + "";
            label5.Text = (Convert.ToInt32(label1.Text) * 0.3) + "";
            label7.Text = (Convert.ToInt32(label1.Text) * 0.4) + "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "select price from Seat where Serial_Number_Plane = '" + label8.Text + "' and SeatNumber = '" + comboBox1.Text + "'";
            MessageBox.Show(sql2);
            MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();


            String seatPrice = reader2[0]+ "";

            reader2.Close();

            


        }
    }
}
