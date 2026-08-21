Console.WriteLine("input number for tick and tock");
Console.WriteLine("Even number gets Tick");
Console.WriteLine("Odd number gets Tock");

//Console.Write("Number: ");
//int num = Convert.ToInt32(Console.Read());

// Achieved using for loop
for (int num = 0; num < 12; num++)
{
    Console.Write($"Number {num + 1}: ");
    if (num % 2 == 0)
    {
        Console.WriteLine("Tick");
    }
    else
    {
        Console.WriteLine("Tock");
    }
}
