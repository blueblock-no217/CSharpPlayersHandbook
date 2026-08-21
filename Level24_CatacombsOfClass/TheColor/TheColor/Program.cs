/*
 The color consists of three parts or channels: red, green, and blue, which indicate how much those
channels are lit up. Each channel can be from 0 to 255. 0 means completely off; 255 means completely
on.
The pedestal also includes some color names, with a set of numbers indicating their specific values for
each channel. These are commonly used colors: White (255, 255, 255), Black (0, 0, 0), Red (255, 0, 0),
Orange (255,165, 0), Yellow (255, 255, 0), Green (0, 128, 0), Blue (0, 0, 255), Purple (128, 0, 128).
Objectives:
• Define a new Color class with properties for its red, green, and blue channels.
• Add appropriate constructors that you feel make sense for creating new Color objects.
• Create static properties to define the eight commonly used colors for easy access.
• In your main method, make two Color-typed variables. Use a constructor to create a color instance
and use a static property for the other. Display each of their red, green, and blue channel values
 */



Colors RGB = new Colors();
//Console.WriteLine($"RGB {RGB}");
// Select your own color
RGB = new Colors(255,60,0);
Console.WriteLine($"R: {RGB.R} G: {RGB.G}, B: {RGB.B}");

// Predetermined color
Colors fixedColor = Colors.Red;
Console.WriteLine($"R={fixedColor.R} G={fixedColor.G} B={fixedColor.B}");

public class Colors
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    
    public Colors(int m_r, int m_g, int m_b)
    {
        R = m_r;
        G = m_g;
        B = m_b;
    }

    public Colors() : this(0,0,0) { }

    public static Colors White
    {
        get => new Colors(255, 255, 255);
    }
    public static Colors Black { get; } = new Colors    (0, 0, 0);
    public static Colors Red            => new Colors   (255, 0, 0);
    public static Colors Orange         => new Colors   (255, 165, 0);
    public static Colors Yellow         => new Colors   (255, 255, 0);
    public static Colors Green          => new Colors   (0, 128, 0);
    public static Colors Blue           => new Colors   (0, 0, 255);
    public static Colors Purple         => new Colors   (128, 0, 128);
}
