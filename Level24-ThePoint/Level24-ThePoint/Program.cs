Point myPoint = new Point(2f,3f);
Point myPoint2 = new Point(-4f,0);

myPoint.ShowCordinates();
myPoint2.ShowCordinates();



public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
    public Point() : this(0, 0) { } 
    

    public void ShowCordinates()
    {
        Console.WriteLine($"Cordinates ({this.X}, {this.Y})");
    }

}