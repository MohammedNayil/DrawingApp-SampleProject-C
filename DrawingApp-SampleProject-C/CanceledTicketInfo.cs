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
    public partial class CanceledTicketInfo : Form
    {
        public CanceledTicketInfo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicketCanceled f1 = new TicketCanceled();
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

        private void CanceledTicketInfo_Load(object sender, EventArgs e)
        {

        }

        public void reload()
        {
            try
            {



                string sql = "select Wieght, price, TimeIssued, seatNumber, MissingFlightFee, CancelationFee, Flight_id from Ticket where ticketID = '" + label11.Text+"'";
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                label10.Text = reader[2] + "";
                label8.Text = reader[0] + "";
                label9.Text = reader[3] + "";

                label6.Text = reader[5] + "";
                label7.Text = reader[4] + "";
                label5.Text = reader[1] + "";
                label1.Text = reader[6] + "";
                label2.Text = reader[1] + "";




                reader.Close();
                string sql2 = "select date, source, Destination from Flight where Flight_id = '" + label1.Text + "'";
                
                MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();

                label2.Text = reader2[0] + "";
                label3.Text = reader2[1] + "";
                label4.Text = reader2[2] + "";
                reader2.Close();



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }
        }
    }
}
