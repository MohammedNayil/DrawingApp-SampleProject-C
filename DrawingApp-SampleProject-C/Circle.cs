using System;

public class Circle : Shape
{
    private int r;
    public Circle(String name, int x, int y, int r)
    {
        this.name = name;
        this.x = x;
        this.y = y;
        this.r = r;
    }
    public override void draw(Graphics g)
    {

        Pen GreenPen = new Pen(Color.Green);
        GreenPen.Width = 3;




        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x-r, y, 2 * r, 2 * r);

        g.DrawEllipse(GreenPen, rect);
    }
    public override String getInfo()
    {

        return name + " (x = " + x + ", y = " + y + ", r = " + r + ")";

    }
    public override void select(Graphics g)
    {
        Pen RedPen = new Pen(Color.Red);

        RedPen.Width = 3;
        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x - r, y, 2 * r, 2 * r);

        g.DrawEllipse(RedPen, rect);

    }

    public override Boolean isSelected(Point p)
    {
        double d = Tools.GetDistance(p.X ,p.Y, x, y + r);
        if (d <= r)
        {

            return true;
        }
        else
        {

            return false;
        }


    }
    
}