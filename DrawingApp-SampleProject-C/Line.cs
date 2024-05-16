using System;

public class Line : Shape
{
    private int endX;
    private int endY;

	public Line(String name, int x, int y, int EndX, int EndY)
	{
        this.name = name;
        this.x = x;
        this.y = y;
        this.endX = EndX;
        this.endY = EndY;
    
    }
    public override void draw(Graphics g)
    {

        Pen GreenPen = new Pen(Color.Green);
        GreenPen.Width = 3;


        g.DrawLine(GreenPen , new Point(x,y), new Point(endX, endY));
    }
    public override String getInfo()
    {

        return name + " (x1 = " + x + ", y1 = " + y + ", x2 = " + endX + ", y2 = " + endY +")";

    }
    public override void select(Graphics g)
    {
        Pen RedPen = new Pen(Color.Red);

        RedPen.Width = 3;
        g.DrawLine(RedPen, new Point(x, y), new Point(endX, endY));

    }
    public override Boolean isSelected(Point p)
    {
        if (Math.Abs((Tools.GetDistance(x,y,p.X,p.Y) + Tools.GetDistance(endX, endY, p.X, p.Y)) - Tools.GetDistance(x,y,endX,endY)) < 5)
        {
            return true;
        }
        else
        {
            return false;
        }

        

    }
}
