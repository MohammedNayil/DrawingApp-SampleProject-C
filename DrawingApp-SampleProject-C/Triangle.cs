using System;

public class Triangle : Shape
{
    private int width;
    private int hight;

    public Triangle(String name, int x, int y, int width, int hight)
	{
        this.name = name;
        this.x = x;
        this.y = y;
        this.width = width;
        this.hight = hight;
    }
    public override void draw(Graphics g)
    {

        Pen GreenPen = new Pen(Color.Green);
        GreenPen.Width = 3;



        PointF[] points = new PointF[3];
        points[0] = new PointF(x, y);
        points[1] = new PointF(x - width/2, y + hight);
        points[2] = new PointF(x + width / 2, y + hight);


        g.DrawPolygon(GreenPen, points);

    }

    public override String getInfo()
    {
        
            return name + " (x = " + x + ", y = " + y + ", width = " + width + ", hight = " + hight + ")";
        

    }
    public override void select(Graphics g)
    {
        Pen RedPen = new Pen(Color.Red);

        RedPen.Width = 3;
        PointF[] points = new PointF[3];
        points[0] = new PointF(x, y);
        points[1] = new PointF(x - width / 2, y + hight);
        points[2] = new PointF(x + width / 2, y + hight);


        g.DrawPolygon(RedPen, points);
    }
    public override Boolean isSelected(Point p)
    {



        if (Tools.PointInTriangle(p,new Point(x,y), new Point(x - width / 2, y + hight), new Point(x + width / 2, y + hight)))
        {

            return true;
        }
        else
        {

            return false;
        }


    }
    
}
