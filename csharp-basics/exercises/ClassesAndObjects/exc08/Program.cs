class Point
{
    public int x { get; set; }

    public int y { get; set; }

    public Point(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
}

class Program
{
    public static Point p1 = new Point(5, 2);
    public static Point p2 = new Point(-3, 6);

    private static void Main(string[] args)
    {
        
        //Point p1 = new Point(5, 2); //didn't swapped in this scope
        //Point p2 = new Point(-3, 6); //didn't swapped in this scope

        Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
        Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        
        SwapPoints(p1, p2);

        //Console.Clear();

        Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
        Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
    }

    //public static (Point, Point) SwapPoints(Point p1a, Point p2a)
    public static void SwapPoints(Point p1a, Point p2a)
    {
        //Point p1b = p2a;
        //Point p2b = p1a;
        
        p1 = p2a;
        p2 = p1a;
        
        //return (p1b, p2b);
    }
}
