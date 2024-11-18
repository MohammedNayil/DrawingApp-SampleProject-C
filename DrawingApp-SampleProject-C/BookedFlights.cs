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
    public partial class BookedFlights : Form
    {
        public BookedFlights()
        {
            InitializeComponent();
        }
        public void reload()
        {
            try
            {
                string sql = "select ticketID from Ticket where SSN = '" + ((LogIn)this.Parent).currentUser + "' and status = 1";
                
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0] + "");
                }
               
                reader.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }
        }
        private void Form10_Load(object sender, EventArgs e)
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

            
            f1.Controls[5].Text = listBox1.Text;

            f1.reload();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasengerMainPage f1 = new PasengerMainPage();
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
    }
}
