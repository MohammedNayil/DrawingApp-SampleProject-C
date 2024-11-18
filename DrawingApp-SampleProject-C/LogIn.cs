using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp_SampleProject_C
{
    public partial class LogIn : Form
    {
        public MySqlConnection conn;
        public String currentUser;
        public String type;
        public LogIn()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString = "server=localhost;uid=root;pwd=root123;database=airline";
           
            try
            {

                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();

                /*MySqlCommand cmd = new MySqlCommand(queryString, conn);
                cmd.ExecuteNonQuery();
                SERVER = 127.0.0.1; PORT = 3306; DATABASE = postgres; UID = root; PASSWORD = root123 */




            }
            catch (MySqlException ex)
            {
                MessageBox.Show("fail");
            }


            if (isAdmin(textBox1.Text, textBox2.Text))
            {
                String sql = "select SSN from Admin where username = '"+ textBox1.Text+ "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();   
                reader.Read();

                currentUser = reader[0]+"";
                type = "admin";
                reader.Close(); 
                


                AdminMainPage f2 = new AdminMainPage();
                f2.TopLevel = false;
                f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f2.Size = this.Size;
                f2.BringToFront();
                f2.Visible = true;
                this.BackgroundImage = null;
                this.Controls.Clear();

                if (this.Parent != null)
                {
                    this.Parent.Controls.Add(f2);
                    this.Parent.Controls.Remove(this);
                }
                else { this.Controls.Add(f2); }
            }
            else if (isPassenger(textBox1.Text, textBox2.Text))
            {
                String sql = "select SSN from passenger where username = '" + textBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                currentUser = reader[0]+ "";
                type = "passenger";
                reader.Close();
                

                PasengerMainPage f2 = new PasengerMainPage();
                f2.TopLevel = false;
                f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f2.Size = this.Size;
                f2.BringToFront();
                f2.Visible = true;
                this.BackgroundImage = null;
                this.Controls.Clear();

                if (this.Parent != null)
                {
                    this.Parent.Controls.Add(f2);
                    this.Parent.Controls.Remove(this);
                }
                else { this.Controls.Add(f2); }
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
            }
        }

        private Boolean isAdmin(String username, String password)
        {
            try
            {
                string sql = "select Username, Password from Admin";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    if (reader["Username"].Equals(username) && reader["Password"].Equals(password))
                    {
                        reader.Close();
                        return true;
                        
                    }

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("read fail");

            }


            return false;
        }
        private Boolean isPassenger(String username, String password)
        {
            try
            {
                string sql = "select Username, Password from Passenger";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    if (reader["Username"].Equals(username) && reader["Password"].Equals(password))
                    {
                        reader.Close();
                        return true;
                        
                    }

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("read fail");

            }


            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount f2 = new CreateAccount();
            f2.TopLevel = false;
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Size = this.Size;
            f2.BringToFront();
            f2.Visible = true;
            this.BackgroundImage = null;
            this.Controls.Clear();


            if (this.Parent != null)
            {
                this.Parent.Controls.Add(f2);
                this.Parent.Controls.Remove(this);
            }
            else { this.Controls.Add(f2); }



        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
