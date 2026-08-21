/*
The fourth pedestal demands constructing a door class with a locking mechanism that requires a unique
numeric code to unlock. You have done something similar before without using a class, but the locking
mechanism is new. The door should only unlock if the passcode is the right one. The following statements
describe how the door works.
• An open door can always be closed.
• A closed (but not locked) door can always be opened.
• A closed door can always be locked.
• A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if
the code supplied matches the door’s current passcode.
• When a door is created, it must be given an initial passcode.
• Additionally, you should be able to change the passcode by supplying the current code and a new
one. The passcode should only change if the correct, current code is given.
Objectives:
• Define a Door class that can keep track of whether it is locked, open, or closed.
• Make it so you can perform the four transitions defined above with methods.
• Build a constructor that requires the starting numeric passcode.
• Build a method that will allow you to change the passcode for an existing door by supplying the
current passcode and new passcode. Only change the passcode if the current passcode is correct.
• Make your main method ask the user for a starting passcode, then create a new Door instance. Allow
the user to attempt the four transitions described above (open, close, lock, unlock) and change the
code by typing in text commands.
*/


Console.WriteLine("Hello, World!");

// Input a passcode and it will clear the screen
Console.WriteLine("What is the initial passcode for the door");
int InitCode = Convert.ToInt32(Console.ReadLine());

Console.Clear();

// Create and object called door and pass in the passcode
Door theDoor = new Door(InitCode);

while(true)
{
    Console.WriteLine($"The door is currently at {theDoor.DoorState}. Do you want to open, close, lock, unlock the door or change passcode");
    Console.WriteLine("Door is closed when: Open => Close or Locked => Unlock");
    Console.WriteLine("Door is locked when: Close => Locked");
    Console.WriteLine("Door is unlock when: passcode is correct");
    Console.WriteLine("Passcode can be changed when previous passcode is correct");
    string Input = Console.ReadLine().ToLower();

    switch(Input)
    {
        case "open":
            theDoor.OpenDoor();
            break;
        case "close":
            theDoor.CloseDoor();
            break;
        case "lock":
            theDoor.LockDoor();
            break;
        case "unlock":
            Console.WriteLine("Input the code to open the door");
            int PassCode = Convert.ToInt32(Console.ReadLine());
            theDoor.UnlockDoor(PassCode);
            break;
        case "change":
            Console.WriteLine("What is the current passcode");
            int currPass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the new passcode");
            int newPass = Convert.ToInt32(Console.ReadLine());
            theDoor.ChangePasscode(currPass, newPass);
            break;
    }
    Console.Clear();
}

// Door class and constructor
public class Door
{
    private int Passcode;

    // This means that DoorState can be view anywhere and can only be modified within the class
    public State DoorState { get; private set; }

    // Constructor to initialize door
    public Door(int code) 
    {
        Passcode = code;
        DoorState = State.Locked;
    }

    public void OpenDoor()
    {
        if(DoorState == State.Closed)
            DoorState = State.Open;  
    }

    public void CloseDoor() 
    {
        if(DoorState == State.Open)
            DoorState = State.Closed; 
    }
    public void LockDoor()
    {
        if (DoorState == State.Closed)
            DoorState = State.Locked;
    }
    public void UnlockDoor(int code)
    {
        if (code == Passcode && DoorState == State.Locked)
        {
            DoorState = State.Closed;
        }
        else
        {
            Console.WriteLine("Door is not locked or Wrong Passcode, Type 0 to exit");
        }
    }

    public void ChangePasscode(int currPass, int newPass)
    {
        if (currPass == Passcode)
        {
            Passcode = newPass;
            Console.WriteLine("Passcode is changed");
        }
        else
        {
            Console.WriteLine("Wrong passcode");
        }
    }
}

public enum State { Closed, Open, Locked}