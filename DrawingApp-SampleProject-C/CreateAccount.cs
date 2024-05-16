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
                String connString = "server=localhost;uid=root;pwd=root123;database=new_schema";
                String queryString = "INSERT INTO pass (id, Username, Password, name) VALUES ('"+textBox3.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox4.Text+"')";
                try
                {
/*                    "INSERT INTO pass (id, Username, Password, name) VALUES (" + 9 + "," + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ")"
*/
                    conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(queryString, conn);
                    cmd.ExecuteNonQuery();
                    




                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Account not created, make sure your informations are correct");
                }



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
            
        }

        private Boolean incorrectInfo()
        {
            return false;
        }
    }
}
