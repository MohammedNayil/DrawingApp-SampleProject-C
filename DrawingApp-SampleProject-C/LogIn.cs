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
    public partial class LogIn : Form
    {
        String currentUser;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAdmin(textBox1.Text, textBox2.Text))
            {
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
            else
            {
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
        }

        private Boolean isAdmin(String username, String password)
        {
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
    }
}
