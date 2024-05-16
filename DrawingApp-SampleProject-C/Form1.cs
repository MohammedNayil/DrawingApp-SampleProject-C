/*using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Supabase.Core;
using Supabase;
using MySqlX.XDevAPI;


namespace DrawingApp_SampleProject_C
{
    
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        String connString;
        private Graphics g;
        private List<Shape> shapes;

        public Form1(List<Shape> shapes)
        {
            InitializeComponent();
            this.shapes = shapes;
            g = DrawingPanel.CreateGraphics();
        }

        *//*private void TryDrawingButton_Click(object sender, EventArgs e)
        {
            g = DrawingPanel.CreateGraphics();
            Color timeLineColor = Color.Black;
            Brush timeLineBrush = new SolidBrush(timeLineColor);
            Pen timeLinePen = new Pen(timeLineColor);


            Pen GreenPen = new Pen(Color.Green);
            Brush txtBrush = new SolidBrush(Color.Black);


            Point p1 = new Point(20, 20);
            Point p2 = new Point(200, 200);
            g.DrawLine(GreenPen, p1, p2); // ██████████████████████████████


            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString("Sample Text", TryDrawingButton.Font, txtBrush, p2, sf); //██████████████████████████████


            g.FillRectangle(txtBrush, 30, 300, 300, 10); // ██████████████████████████████
        }*//*

        private void drawRectangleButton_Click(object sender, EventArgs e)
        {


            int counter = 1;
            foreach (Shape s in shapes)
            {
                if (s is Rectangle)
                {
                    counter++;
                }
            }
            Random random = new Random();
            int x = random.Next(0, 700);
            int y = random.Next(0, 400);
            int hight = random.Next(10, 100);
            int width = random.Next(10, 100);

            Rectangle rec = new Rectangle("Rectangle " + counter, x, y, width, hight);
            shapes.Add(rec);
            shapesListBox.Items.Add(rec.getName());
            rec.draw(g);
        }

        private void shapesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadPanal();
            string text = shapesListBox.GetItemText(shapesListBox.SelectedItem);

            foreach (Shape s in shapes)
            {
                if (s.getName().Equals(text))
                {
                    s.select(g);
                }
            }
        }



        public void Form1_Load(object sender, EventArgs e)
        {


        }


        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                reload();
                Point startPoint = e.Location;



                foreach (Shape s in shapes)
                {
                    if (s.isSelected(startPoint))
                    {
                        s.select(g);

                        shapesListBox.SetSelected(shapesListBox.FindString(s.getName()), true);
                        break;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace);
            }
        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {

        }


        private void infoModeButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(shapes);
            f2.TopLevel = false;
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Size = this.Size;
            f2.BringToFront();
            f2.Visible = true;
            this.Controls.Clear();

            if (this.Parent != null)
            {
                this.Parent.Controls.Add(f2);
                this.Parent.Controls.Remove(this);
            }
            else { this.Controls.Add(f2); }





        }

        public void reload()
        {
            shapesListBox.Items.Clear();
            foreach (Shape s in shapes)
            {


                shapesListBox.Items.Add(s.getName());

            }
            foreach (Shape s in shapes)
            {
                s.draw(g);
            }
        }
        public void reloadPanal()
        {

            foreach (Shape s in shapes)
            {
                s.draw(g);
            }
        }
        

        private void drawTriangleButton_Click(object sender, EventArgs e)
        {
            connString = "server=127.0.0.1;uid=root;pwd=root123;database=sakila";
            String queryString = "INSERT INTO `table` (`attr 1`, `attr 2`, `attr 3`) VALUES ('value3', 'value2', 'value3')";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("sucsess");

                *//*MySqlCommand cmd = new MySqlCommand(queryString, conn);
                cmd.ExecuteNonQuery();
                
                 
                 SERVER=127.0.0.1;PORT=3306;DATABASE=postgres;UID=root;PASSWORD=root123*//*
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("fail");
            }






            int counter = 1;
            foreach (Shape s in shapes)
            {
                if (s is Triangle)
                {
                    counter++;
                }
            }
            Random random = new Random();
            int x = random.Next(50, 700);
            int y = random.Next(50, 400);
            int hight = random.Next(10, 100);
            int width = random.Next(10, 100);

            Triangle tri = new Triangle("Triangle " + counter, x, y, width, hight);
            shapes.Add(tri);
            shapesListBox.Items.Add(tri.getName());
            tri.draw(g);
        }

        private void drawSquareButton_Click(object sender, EventArgs e)
        {


            *//*String supabaseUrl = "https://mfusyhcyjpbgoqyectch.supabase.co";
            String supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY");
            Client client = new Client();*//*
    




        int counter = 1;
            foreach (Shape s in shapes)
            {
                if (s is Square)
                {
                    counter++;
                }
            }
            Random random = new Random();
            int x = random.Next(0, 700);
            int y = random.Next(0, 400);
            int side = random.Next(10, 100);


            Square sqr = new Square("Square " + counter, x, y, side);
            shapes.Add(sqr);
            shapesListBox.Items.Add(sqr.getName());
            sqr.draw(g);
        }

        private void drawCircleButton_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (Shape s in shapes)
            {
                if (s is Circle)
                {
                    counter++;
                }
            }
            Random random = new Random();
            int x = random.Next(50, 700);
            int y = random.Next(50, 400);
            int r = random.Next(10, 50);


            Circle sr = new Circle("Circle " + counter, x, y, r);
            shapes.Add(sr);
            shapesListBox.Items.Add(sr.getName());
            sr.draw(g);
        }

        private void drawLineButton_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (Shape s in shapes)
            {
                if (s is Line)
                {
                    counter++;
                }
            }
            Random random = new Random();
            int x = random.Next(0, 700);
            int y = random.Next(50, 400);
            int endX= random.Next(x+ 10, x + 100);
            int endY = random.Next(y - 100, y + 100);

            int r = random.Next(10, 50);


            Line li = new Line("Line " + counter, x, y, endX, endY);
            shapes.Add(li);
            shapesListBox.Items.Add(li.getName());
            li.draw(g);
        }
    }
}*/