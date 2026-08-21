// 08/05/2026

// Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
// gems: a fire gem and an electric gem. Every third turn of a crank, the fire gem activates, and the cannon
// produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an
// electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
// produce a program that can warn the crew about which turns of the crank will produce the different
// blasts before they do it.

// Partial Output 
/*
1: Normal
2: Normal
3: Fire
4: Normal
5: Electric
6: Fire
7: Normal

• Write a program that will loop through the values between 1 and 100 and display what kind of blast
the crew should expect. (The % operator may be of use.)
• Change the color of the output based on the type of blast. (For example, red for Fire, yellow for
Electric, and blue for Electric and Fire).
*/

Console.WriteLine("Every third turn: Fire"); // 
Console.WriteLine("Every fifth turn: Electric");

int N = 100;
for (int i = 1; i <= N; i++)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write($"{i,-3}: ");

    // Fire and Electric
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Fire and Electric");
    }

    // Fire
    else if (i % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Fire");
    }

    // Electric
    else if (i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Electric");
    }

    // Normal
    else 
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Normal");
    }
    Console.ResetColor();
    Console.WriteLine();
}

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;