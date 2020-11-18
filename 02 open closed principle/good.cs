public interface IShape
{
    double Area();
}

public class Rectangle : IShape
{
  public double Width { get; set; }
  public double Height { get; set; }
  public double Area()
  {
    return Width * Height;
  }
}
 
public class Circle : IShape
{
  public double Radius { get; set; }
  public double Area()
  {
    return Radius * Radius * Math.PI;
  }
}