/*
 Ask the user for an X value and a Y value. These are coordinates
of the enemy relative to the watchtower's location.
 
 Using the image on the right, if statements, and relational
operators, display a message about what direction the enemy is
coming from. For example, “The enemy is to the northwest!” or
“The enemy is here!
*/

/*
The image:
        x < 0   X = 0   X > 0
Y > 0   [NW]    [N]     [NE]
Y = 0   [W]     [!]     [E]
Y < 0   [SW]    [S]     [SE]
*/

Console.WriteLine("Input X and Y coordinates of enemy relative to your current");
Console.Write("X: ");
// ReadLine() is used here to grab actual user input
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// East 
 if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Enemies at North East");
    }
    if (y == 0)
    {
        Console.WriteLine("Enemies at East");
    }
    if (y < 0)
    {
        Console.WriteLine("Enemies at South East");
    }
}
// West
else if (x < 0)
{
    if (y > 0)
    {
        Console.WriteLine("Enemies at North West");
    }
    if (y == 0)
    {
        Console.WriteLine("Enemies at West");
    }
    if (y < 0)
    {
        Console.WriteLine("Enemies at South West");
    }
}
// North, South, Current
else if (x == 0)
{
    if (y > 0)
    {
        Console.WriteLine("Enemies at North");
    }
    if (y == 0)
    {
        Console.WriteLine("Enemies at here");
    }
    if (y < 0)
    {
        Console.WriteLine("Enemies at South");
    }
}
