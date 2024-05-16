using System;

public class Rectangle : Shape
{
    private int width;
    private int hight;

    public Rectangle(String name, int x, int y, int width, int hight)
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




        System.Drawing.Rectangle rect= new System.Drawing.Rectangle(x, y, width, hight);
        
        g.DrawRectangle(GreenPen, rect);

        
        
        

    }
    public override String getInfo()
    {
        
            return name + " (x = " + x + ", y = " + y + ", width = " + width + ", hight = " + hight + ")";
        
        
    }
    public override void select(Graphics g)
    {
        Pen RedPen = new Pen(Color.Red);

        RedPen.Width = 3;
        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, hight);

        g.DrawRectangle(RedPen, rect);

    }
    public override Boolean isSelected(Point p) {


  
        if (p.X >= x && p.X <= x + width && p.Y >= y && p.Y <= y + hight) {
            
            return true; }
        else
        {
            
            return false;
        }
        
        
         }
}
