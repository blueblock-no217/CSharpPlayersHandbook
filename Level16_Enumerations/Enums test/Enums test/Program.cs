Console.WriteLine("Enumerations");

/*
 * Another way of writing this
enum Seasom{
    Winter,
    Summer,
    Spring,
    Fall
}
 */
Season current = Season.Winter;

if (current == Season.Winter || current == Season.Summer)
    Console.WriteLine("Happy Soltice");
else
    Console.WriteLine("Happy Equinox");

// Must be placed at the end of the file or in another file
// Because it marks the end of the main method
enum Season { Winter, Summer, Spring, Fall }
