/*
Rebuild the program above on your computer.
Add comments near each of the four variables that describe what they store. You must use at least
one of each comment type (// and /* \*\/)
 */

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();      // An item name

Console.WriteLine("How would you describe it? Big Azure? Tattered?");
string b = Console.ReadLine();      // To describe the item

// The spaces at the start and end of text can be removed if the display have them
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b +" " + a + " of " + c + " " + d + "!");
