using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DrawingApp_SampleProject_C
{
    public partial class FlightList : Form
    {
        
        
        public FlightList()
        {
            if (this.Parent is LogIn)
            MessageBox.Show("login");
            /*this.currentUser = ((LogIn)this.Parent).currentUser;*/
            InitializeComponent();
        }
        private Boolean isAdmin()
        {
            return true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((((LogIn)this.Parent).type).Equals("admin"))
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


                f1.Controls[0].Text = listBox1.Text;
                f1.reload();

            }
            else
            {
                PassengerFlightInfo f1 = new PassengerFlightInfo();
                f1.TopLevel = false;
                f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f1.Size = this.Size;
                f1.BringToFront();
                f1.Visible = true;
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Parent.Controls.Add(f1);
                this.Parent.Controls.Remove(this);
                f1.Controls[0].Text = listBox1.Text;
                f1.reload();
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                string sql = "select Flight_id from Flight where date = '"+dateTimePicker1.Text+"' and source = '"+comboBox1.Text+ "' and Destination = '"+comboBox2.Text + "'";
                MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    listBox1.Items.Add("Flight: "+reader[0]);

                }
                reader.Close();
            }
            catch(MySqlException ex) {
                MessageBox.Show("wrong date");
            }
        }
    }
}
