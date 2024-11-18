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
    public partial class ModifyTicket : Form
    {
        public ModifyTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update ticket set SeatNumber = '" + comboBox3.Text + "', Wieght = '"+comboBox2.Text +"' where ticketID = '" +label6.Text + "'";
                MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                cmd.ExecuteNonQuery();

                /*string sql2 = "select ticket.TicketID, passenger.FirstName from Ticket join passenger on ticket.ssn = passenger.ssn where ticket.Flight_id = '" + label7.Text.Substring(7) + "'";
                MessageBox.Show(sql2);
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();


                while (reader2.Read())
                {
                    listBox1.Items.Add(reader2[0] + " " + reader2[1]);
                }
                reader.Close();*/

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }







            /*if (isAdmin())
            {



                AdminFlightInfo f1 = new AdminFlightInfo();
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
            else
            {
                BookedFlights f1 = new BookedFlights();
                f1.TopLevel = false;
                f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f1.Size = this.Size;
                f1.BringToFront();
                f1.Visible = true;
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Parent.Controls.Add(f1);
                this.Parent.Controls.Remove(this);
            }*/



        }
        private Boolean isAdmin()
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "Update ticket set Status = " + 0;
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                cmd.ExecuteNonQuery();

                /*string sql2 = "select ticket.TicketID, passenger.FirstName from Ticket join passenger on ticket.ssn = passenger.ssn where ticket.Flight_id = '" + label7.Text.Substring(7) + "'";
                MessageBox.Show(sql2);
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();


                while (reader2.Read())
                {
                    listBox1.Items.Add(reader2[0] + " " + reader2[1]);
                }
                reader.Close();*/

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }




            /*if (isAdmin())
            {
                AdminFlightInfo f1 = new AdminFlightInfo();
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
            else
            {
                BookedFlights f1 = new BookedFlights();
                f1.TopLevel = false;
                f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f1.Size = this.Size;
                f1.BringToFront();
                f1.Visible = true;
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Parent.Controls.Add(f1);
                this.Parent.Controls.Remove(this);
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                AdminFlightInfo f1 = new AdminFlightInfo();
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
            else
            {
                BookedFlights f1 = new BookedFlights();
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

        }

        public void reload()
        {
            try
            {
                string sql = "select Flight_id, wieght,SeatNumber, price, TimeIssued, MissingFlightFee, CancelationFee from Ticket where TicketID = '" + label6.Text + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                label1.Text = reader[0] + "";
                label2.Text = reader[4] + "";
                comboBox2.Text = reader[1] + "";
                comboBox3.Text = reader[2] + "";
                label5.Text = reader[6] + "";
                label7.Text = reader[5] + "";
                label8.Text = reader[3] + "";



                reader.Close();

                /*string sql2 = "select ticket.TicketID, passenger.FirstName from Ticket join passenger on ticket.ssn = passenger.ssn where ticket.Flight_id = '" + label7.Text.Substring(7) + "'";
                MessageBox.Show(sql2);
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();


                while (reader2.Read())
                {
                    listBox1.Items.Add(reader2[0] + " " + reader2[1]);
                }
                reader.Close();*/

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }
        }
        private void ModifyTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
