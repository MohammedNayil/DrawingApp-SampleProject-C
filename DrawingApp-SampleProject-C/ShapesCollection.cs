using System;

public class ShapesCollection
{
    private List<Shape> shapes = new List<Shape>();
    public ShapesCollection()
	{
	}

    public void addShape(Shape s)
    {
        shapes.Add(s);
    }
    public List<Shape> getList()
    {
        List<Shape> newList = new List<Shape>(shapes);
        return newList;
    }
}
