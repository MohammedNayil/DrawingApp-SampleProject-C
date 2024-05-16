using System;

public abstract class Shape
{
	protected String name;
    protected int x;
    protected int y;
	
	public Shape()
	{
	}
	public abstract void draw(Graphics g);
    public abstract String getInfo();
	public String getName() {
	return name;
	}
    

    public abstract void select(Graphics g);
    

    public abstract Boolean isSelected(Point p);
}
