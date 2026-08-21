Console.WriteLine("There's a chest infront of you!");

Chest ChestState = Chest.Locked;
string user;

while (true)
{
    // In locked state, only unlock can proceed forward
    if (ChestState == Chest.Locked)
    {
        Console.Write("The chest is locked. Do you want to unlock it? ");
        user = Console.ReadLine();

        if (user == "unlock")
        {
            ChestState = Chest.Closed;
        }
        else if (user == "lock")
        {
            Console.WriteLine("It is already locked.");
        }
    }
    // In open, the chest is now opened
    else if (ChestState == Chest.Open)
    {
        Console.Write("The chest is now open. Do you want to close it? ");
        user = Console.ReadLine();

        if (user == "close")
        {
            ChestState = Chest.Closed;
        }
        else if (user == "open")
        {
            Console.WriteLine("The chest is already opened.");
        }
    }
    // In closed, the chest can lock and open but not close or unlock
    else if (ChestState == Chest.Closed)
    {
        Console.Write("The chest is now unlocked/closed. What do you do? ");
        user = Console.ReadLine();

        if (user == "open")
        {
            ChestState = Chest.Open;
        }
        else if (user == "close")
        {
            Console.WriteLine("The chest is already closed");
        }
        else if (user == "lock")
        {
            ChestState = Chest.Locked;
        }
        else if (user == "unlock")
        {
            Console.WriteLine("The chest is already unlocked.");
        }
    }
}

enum Chest { Open, Closed, Locked}