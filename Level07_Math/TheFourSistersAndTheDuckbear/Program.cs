/*
Console.WriteLine("Hello, World!");
int aBigNumber = int.MaxValue;

double infinity = double.PositiveInfinity;

Console.WriteLine(aBigNumber);
Console.WriteLine(infinity);
*/

// Four sisters
//  All four sisters get an equal number of chocolate eggs every day, and the remainder is fed to their pet duckbear

Console.WriteLine("How many chocolate eggs did chocolate chicken gives for the day:");
int numEggs = Convert.ToInt32(Console.ReadLine());
int sisters = 4;

int splitToFour = numEggs / sisters;
int dbEggs = numEggs % sisters;

Console.WriteLine($"The number of eggs each sister gets: {splitToFour}");
Console.WriteLine($"The number of eggs duckbear gets: {dbEggs}");