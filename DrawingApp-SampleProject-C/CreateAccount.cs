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
