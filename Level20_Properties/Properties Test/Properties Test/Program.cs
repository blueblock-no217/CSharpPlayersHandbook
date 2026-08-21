Console.WriteLine("Hello, World!");

// Object instance
Rectangle shape = new Rectangle(1,1);

// Properties can directly change the private values
shape.GetWidth = 100;

Console.WriteLine($"Width: {shape.GetWidth}, Height: {shape.GetHeight()}");

// class blueprint
public class Rectangle
{
    // Anything inside the class is a member of the class
    private float width = 10000;
    private float height = 10;

    // property method
    public float GetWidth
    {
        // obtain the value from the class member
        get => width;
        // manually set the value outside of the class
        set => width = value;
    }
    //  a Method
    public float GetHeight() => height;

    // Constructor requires 2 input parameters to produce a rectangle
    // Cronstructor to make an object
    public Rectangle (float _width, float _height)
    {
        width = GetWidth;
        height = GetHeight();
    }
}