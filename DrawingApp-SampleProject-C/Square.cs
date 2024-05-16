using System;

public class Square: Shape
{
    private int side;

    public Square(String name, int x, int y, int side)
	{
        this.name = name;
        this.x = x;
        this.y = y;
        this.side = side;
       
    }
    public override void draw(Graphics g)
    {

        Pen GreenPen = new Pen(Color.Green);
        GreenPen.Width = 3;



        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, side, side);

        g.DrawRectangle(GreenPen, rect);

       
       
    }
    public override String getInfo()
    {

        return name + " (x = " + x + ", y = " + y + ", side = " + side + ")";

    }
    public override void select(Graphics g)
    {
        Pen RedPen = new Pen(Color.Red);

        RedPen.Width = 3;
        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, side, side);

        g.DrawRectangle(RedPen, rect);

    }
    public override Boolean isSelected(Point p)
    {



        if (p.X >= x && p.X <= x + side && p.Y >= y && p.Y <= y + side)
        {

            return true;
        }
        else
        {

            return false;
        }


    }
}
