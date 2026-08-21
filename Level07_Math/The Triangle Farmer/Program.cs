// Calculate the area of a triangle
Console.WriteLine("Input the base of the triangle: ");

// Convert.ToInt32 converts string to int data type
// Another method int.Parse(variable)
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the height of the triangle: ");
int h = Convert.ToInt32(Console.ReadLine());

double Area = (b * h) / 2.0;

Console.WriteLine("The Area of the triangle is: ");
Console.WriteLine($"{Area}m^2");
