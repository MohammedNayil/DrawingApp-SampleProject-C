﻿using System;
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
    public partial class WaitListedPassengers : Form
    {
        public WaitListedPassengers()
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

        private void button2_Click(object sender, EventArgs e)
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
        }

        private void WaitListedPassengers_Load(object sender, EventArgs e)
        {

        }
    }
}
