public class Rectangle
{
  public double Width { get; set; }
  public double Height { get; set; }
}

public class Circle : IShape
{
  public double Radius { get; set; }
}

public double Area(object[] shapes)
{
    double area = 0;
    
    foreach (var shape in shapes)
    {
        if (shape is Rectangle)
        {
            var rectangle = (Rectangle)shape;
            area += rectangle.Width * rectangle.Height;
        }
        else
        {
            var circle = (Circle)shape;
            area += circle.Radius * circle.Radius * Math.PI;
        }
    }
 
    return area;
}