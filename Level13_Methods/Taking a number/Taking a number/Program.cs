// Practice
// Calling the fucntion
/*
CountToTen();

Console.WriteLine("");
Console.WriteLine("This is after the local function.");
// Local function
void CountToTen()
{
    for (int current = 1; current <= 10; current++)
        Console.WriteLine(current);
}
*/
// Returning a value from method
/*
int readNumber()
{
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}
*/

// Taking a number

/*
Many previous tasks have required getting a number from a user. To save time writing this code
repeatedly, you have decided to make a method to do this common task.
Objectives:
• Make a method with the signature int AskForNumber(string text). Display the text
parameter in the console window, get a response from the user, convert it to an int, and return it.
This might look like this: int result = AskForNumber("What is the airspeed velocity
of an unladen swallow ? ");.
• Make a method with the signature int AskForNumberInRange(string text, int min, int
max).Only return if the entered number is between the min and max values.Otherwise, ask again.
• Place these methods in at least one of your previous programs to improve it
*/

// Ask for the range between 2 numbers

while(true)
{
    Console.WriteLine("Give me 2 numbers and I will find the difference.");
    int result = AskNumDiff("1st number: ");
    Console.WriteLine($"The difference between your numbers are: {result}");
}


int AskNum(string text)
{
    Console.Write(text);
    if (int.TryParse(Console.ReadLine(), out int num))
        return num;

    Console.WriteLine("Please enter a number");
    return AskNum(text);
}

int AskNumDiff(string text)
{
    int num1 = AskNum(text);
    int num2 = AskNum("2nd number: ");
    int diff = num1 - num2;
    diff = Math.Abs(diff);
    return diff;
}