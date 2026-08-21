// The point

// Store a point in 2 dimension
// Each point has x,y distance away from the origin

/*
• Define a new Point class with properties for X and Y.
• Add a constructor to create a point from a specific x- and y-coordinate.
• Add a parameterless constructor to create a point at the origin (0, 0).
• In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
console window in the format (x, y) to illustrate that the class works.
• Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
*/

Point Coor1 = new Point(1, 2);
Point Coor2 = new Point(7, 8);
Point Coor3 = new Point(); // default constructor

Console.WriteLine($"Coordinate 1: {Coor1.X}, {Coor1.Y}");
Console.WriteLine($"Coordinate 2: {Coor2.X}, {Coor2.Y}");
Console.WriteLine($"Coordinate origin: {Coor3.X}, {Coor3.Y}");

Console.WriteLine("Hello world");

public class Point
{
    // Properties method X & Y to store the coordinates
    // The properties are immutable because they only have a getter and no setter, meaning their values cannot be changed after the object is created.
    public int X { get; set; } // mutable version with set;
    public int Y { get; set; }

    // Constructor blueprint that requires 2 input parameters to produce a point
    public Point(int _x, int _y)
    {
        X = _x;
        Y = _y;
    }

    // Reused the other constructor to create a point at the origin as default
    // Same as passing Point(0, 0)
    public Point() : this(0, 0) { }
}