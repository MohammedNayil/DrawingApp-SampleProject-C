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
   
    public partial class CreateAccount : Form
    {
        MySqlConnection conn;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (incorrectInfo())
            {

            }
            else
            {
                String gender;
                if ((comboBox1.Text).Equals("Male"))
                {
                    gender = "m";
                   
                }
                else
                {
                    gender = "f";
                   
                }
                   
               
                String connString = "server=localhost;uid=root;pwd=root123;database=airline";
/*                String queryString = "INSERT INTO passenger (SSN, Username, Password, FirstName, LastName, BirthDate, Sex) VALUES ('9','u9','p9','a','a','gg','f')";
*/                             String queryString = "INSERT INTO passenger ( Username, Password, FirstName, LastName, BirthDate, Sex) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+ "','"+textBox4.Text + "','" + dateTimePicker1.Text + "','" + gender + "')";
                
                try
                {
/*                    "INSERT INTO pass (id, Username, Password, name) VALUES (" + 9 + "," + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ")"
*/
                    conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(queryString, conn);
                    cmd.ExecuteNonQuery();

                    String sql = "select SSN from passenger where username = '" + textBox1.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    reader.Read();

                    ((LogIn)this.Parent).currentUser = reader[0] + "";
                    ((LogIn)this.Parent).type = "passenger";
                    reader.Close();
                    

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Account not created, make sure your informations are correct");
                }

                
            }
            
        }

        private Boolean incorrectInfo()
        {
            return false;
        }
    }
}
