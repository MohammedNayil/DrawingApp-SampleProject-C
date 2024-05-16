/*using System;
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
    public partial class Form2 : Form
    {
        private List<Shape> shapes;

        public Form2(List<Shape> shapes)
        {
            InitializeComponent();

            this.shapes = shapes;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Shape s in shapes)
            {
                richTextBox1.AppendText(s.getInfo() + "\n");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoModeButton_Click(object sender, EventArgs e)
        {

        }

        private void drawModeButton_Click(object sender, EventArgs e)
        {


            Form1 f1 = new Form1(shapes);
            f1.TopLevel = false;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Size = this.Size;
            f1.BringToFront();
            f1.Visible = true;
            this.Controls.Clear();
            this.Parent.Controls.Add(f1);
            this.Parent.Controls.Remove(this);
            f1.reload();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            richTextBox1.Clear();
        }
    }
}
*/