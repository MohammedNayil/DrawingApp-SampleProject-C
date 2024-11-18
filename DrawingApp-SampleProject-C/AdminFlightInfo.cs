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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrawingApp_SampleProject_C
{
    public partial class AdminFlightInfo : Form
    {

        public AdminFlightInfo()
        {
            InitializeComponent();

        }

        public void reload()
        {
            try
            {
                string sql = "select date, source, Destination, Serial_Number_Plane from Flight where Flight_id = '" + label7.Text.Substring(7) + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                label2.Text = reader[0] + "";
                label3.Text = reader[1] + "";
                label4.Text = reader[2] + "";
                label1.Text = reader[3] + "";


                reader.Close();

                string sql2 = "select ticket.TicketID, passenger.FirstName from Ticket join passenger on ticket.ssn = passenger.ssn where ticket.Flight_id = '" + label7.Text.Substring(7) + "' and ticket.status = 1";
                
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                

                while (reader2.Read())
                {
                    listBox1.Items.Add(reader2[0] +" "+ reader2[1]);
                }
                reader2.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong date");
            }
        }
        private void Form9_Load(object sender, EventArgs e)
        {
           



            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            ModifyTicket f1 = new ModifyTicket();
            f1.TopLevel = false;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Size = this.Size;
            f1.BringToFront();
            f1.Visible = true;
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Parent.Controls.Add(f1);
            this.Parent.Controls.Remove(this);

            int index = listBox1.Text.IndexOf(" ");
            f1.Controls[5].Text = listBox1.Text.Substring(0,index);

            f1.reload();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
