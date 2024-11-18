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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String choice = comboBox1.Text;
            

            if (choice.Equals("Current active flight"))
            {
                CurrentActiveFlight f1 = new CurrentActiveFlight();
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
            else if (choice.Equals("Percentage of booking"))
            {
                PercentageOfBooking f1 = new PercentageOfBooking();
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
            else if (choice.Equals("Confirmed payments"))
            {
                ConfirmedPayments f1 = new ConfirmedPayments();
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
            else if (choice.Equals("Waitlisted passengers"))
            {
                WaitListedPassengers f1 = new WaitListedPassengers();
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
            else if (choice.Equals("Average load factor"))
            {
                AverageLoadFactor f1 = new AverageLoadFactor();
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
            else if (choice.Equals("Ticket cancelled"))
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

                f1.reload();
            }
        }
    }
}
