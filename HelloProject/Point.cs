public class Point
{
    public double x;
    public double y;

    public enum ReflectionType {
        X,
        Y,
        Origin
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Point() : this(1.0, 1.0) { } //WHY DO WE NEED THIS?

    public double DistanceToOrigin()
    {
        return Math.Sqrt(x * x + y * y);
    }
    public double DistanceTo(Point other)
    {
        double deltaX = other.x - this.x;
        double deltaY = other.y - this.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY); //ASK ABOUT THE DIFFERENCE BETWEEN THIS AND OTHER
    }
    public static double Distance(Point p1, Point p2)
    {
        double deltaX = p2.x - p1.x;
        double deltaY = p2.y - p1.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
    public static string ToString(Point point1)
    {
        return $"({point1.x}, {point1.y})";
    }
    public void Reflect(ReflectionType type)
    {
        switch (type)
        {
            case ReflectionType.X:
                this.y = -this.y;
                break;
            case ReflectionType.Y:
                this.x = -this.x;
                break;
            case ReflectionType.Origin:
                this.x = -this.x;
                this.y = -this.y;
                break;
        }
    }

}