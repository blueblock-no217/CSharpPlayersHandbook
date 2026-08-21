/* 07/05/2026
• Build a program that will allow a user, the pilot, to enter a number.
• If the number is above 100 or less than 0, keep asking.
• Clear the screen once the program has collected a good number.
• Ask a second user, the hunter, to guess numbers.
• Indicate whether the user guessed too high, too low, or guessed right.
• Loop until they get it right, then end the program
 */

// Sets the colors for the text
// Depending on where it is placed it will paint any changes happening to the screen
// Paints the console background to yellow and text black
// Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();

Console.WriteLine("Hello, World!");
Console.WriteLine("Press any key to proceed.");
Console.ReadKey(true); // obtains the key press the user gave


Console.WriteLine("User 1, Input a number between 0 - 100 to be guessed: ");
//int num = Convert.ToInt32(Console.ReadLine());

int num;    // Used in exception handling

// the blcok below is the normal answer
// check the range of numbers given
//while(num > 100 || num < 0)
//{
//    Console.WriteLine("User 1, input must be within 0 - 100");
//    num = Convert.ToInt32(Console.ReadLine());
//}


// with the addition of exception handling
while (true)
{
    string user1 = Console.ReadLine();
    if (!(int.TryParse(user1, out num)))
    {
        Console.WriteLine("Invalid, No alphabets.");
        continue;
    }

    if (num < 0 || num > 100)
    {
        Console.WriteLine("Invalid, numbers between 0 - 100 only.");
    }
    break;
}


int guess;

Console.Clear();

Console.WriteLine("User 2, guess a number between 0 - 100: ");

do
{
    Console.Write("What is your guess?: ");
    string input = Console.ReadLine();

    // if the check is successful, this means the input is an integer number
    // if unsuccessful, it tells the user to input a new number
    if (!(int.TryParse(input, out guess)))
    {
        Console.WriteLine("Invalid, numbers only");
        continue;
    }

    if (guess < num)
    {
        Console.WriteLine($"{guess} is too Low.");
    }
    else if (guess > num)
    {
        Console.WriteLine($"{guess} is too High.");
    }
}
while (guess != num);

Console.WriteLine($"You guess correctly, it's {guess}");