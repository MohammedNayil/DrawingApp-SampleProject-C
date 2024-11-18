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
    public partial class PercentageOfBooking : Form
    {
        public PercentageOfBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMainPage f1 = new AdminMainPage();
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
            try
            {
                string sql = "select Flight_id, Serial_Number_Plane from Flight";
               
                MySqlCommand cmd = new MySqlCommand(sql, ((LogIn)this.Parent).conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<String> dates0 = new List<String>();
                List<String> dates = new List<String>();

                while (reader.Read())
                {
                    


                    dates0.Add(reader[0] + "");
                    dates.Add(reader[1] + "");
                }

                reader.Close();

                int index = 0;

                List<String> values = new List<String>();   
                foreach (String item in dates0)
                {
                    string sql2 = "select count(*) from ticket where Flight_id = '" + item + "' and status = 1";
                    
                    MySqlCommand cmd2 = new MySqlCommand(sql2, ((LogIn)this.Parent).conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    String x = reader2[0]+"";
                    reader2.Close();

                    
                    string sql3 = "select count(*) from Seat where Serial_Number_Plane= '" + 4 + "'";
                    
                    MySqlCommand cmd3 = new MySqlCommand(sql3, ((LogIn)this.Parent).conn);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    reader3.Read();
                    String y = reader3[0] + "";
                    reader3.Close();


                     values.Add(item + " " + (Convert.ToInt32(x) / Convert.ToInt32(y))) ;

                    index++;

                }

                if (false) { }

                foreach (String H in values)
                {
                    listBox1.Items.Add(H);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("wrong");
            }
        }
    }
}
