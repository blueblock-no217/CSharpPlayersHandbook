Console.Title = "Defense of Consolas";

Console.WriteLine("Press any key to proceed");
Console.ReadKey(true);
Console.WriteLine("Key in the coordinates to defend.");
Console.Write("Target Column, X: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Row, Y: ");

int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Deploy to:");

Console.WriteLine($"{col}, {row + 1}");
Console.WriteLine($"{col}, {row - 1}");
Console.WriteLine($"{col - 1}, {row}");
Console.WriteLine($"{col + 1}, {row}");

// (frequency, duration)
Console.Beep();