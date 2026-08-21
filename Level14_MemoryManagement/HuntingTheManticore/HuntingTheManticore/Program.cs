/*
 Objectives:
• Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15.
The game starts at round 1.
• Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen
afterward.
• Run the game in a loop until either the Manticore’s or city’s health reaches 0.
• Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
health.
• Compute how much damage the cannon will deal this round: 10 points if the round number is a
multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to
the player.
• Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too
far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected
amount.
• If the Manticore is still alive, reduce the city’s health by 1.
• Advance to the next round.
• When the Manticore or the city’s health reaches 0, end the game and display the outcome.
• Use different colors for different types of messages.
• Note: This is the largest program you have made so far. Expect it to take some time!
• Note: Use methods to focus on solving one problem at a time.
• Note: This version requires two players, but in the future, we will modify it to allow the computer
to randomly place the Manticore so that it can be a single-player game.
 
 */

// Hot and cold game
// ask player 1 to input the distance of Manticore in the range of 0 - 100
int MantiRange = GetMantiRange();
Console.Clear();

// Player 2 guess the range distance between 0 - 100
int turns = 1;
int cityHealth = 15;
int MantiHealth = 10;

Console.WriteLine("Player 2, it is your turn to guess the distance.");

// Program will run as long as city is up or manticore is alive
while (!(cityHealth <= 0 || MantiHealth <= 0))
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {turns} City: {cityHealth}/15 Manticore: {MantiHealth}/10");

    // Check the amount of damage that will be dealt this round
    int damage = DamageDealt(turns);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    // Check whether the player 2 hits the manticore
    int range = rangeGuess(MantiRange);
    if (range < MantiRange)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ResetColor();
    }
    else if (range > MantiRange)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOOT the target.");
        Console.ResetColor();
    }
    else if (range == MantiRange)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ResetColor();
        MantiHealth = MantiHealth - damage;
    }

    // City health drops if the manticore is still alive
    if (MantiHealth > 0)
        cityHealth--;
    turns++;
}

// Display winning or losing message
if (cityHealth < 0 && MantiHealth > 0)
{
    Console.WriteLine("The city of Consolas has fallen to the Manticore!");
}
else
{
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}


// Player 2 guess the manticore range
int rangeGuess(int MantiRange)
{
    Console.Write("Enter the desired cannon range: ");
    int range = Convert.ToInt32(Console.ReadLine());
    return range;
}

// Damage dealt on this turn 
int DamageDealt(int turns)
{
    int damage = 1;
    if (turns % 3 == 0 && turns % 5 == 0)
    {
        return damage * 10;
    }
    else if (turns % 3 == 0 || turns % 5 == 0)
    {
        return damage * 3;
    }
    else
    {
        return damage;
    }
}

// MantiRange
int GetMantiRange()
{
    int range;
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");

    while (!int.TryParse(Console.ReadLine(), out range)|| range < 0 || range > 100)
    {
        Console.Write("Invalid input, must be within 0 - 100. ");
    }
    return range;
}