//int[] scores = new int[7];
//Console.WriteLine(scores.Length);

/*
 While searching an abandoned storage building containing strange code artifacts, you uncover the
ancient Replicator of D’To. This can replicate the contents of any int array into another array. But it
appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
Objectives:
• Make a program that creates an array of length 5.
• Ask the user for five numbers and put them in the array.
• Make a second array of length 5.
• Use a loop to copy the values out of the original array and into the new one.
• Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
again
 */

int[] numbers = new int[5];

Console.WriteLine("Input 5 number to fill another array.");

int[] copy = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Number {i+1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    copy[i] = numbers[i];
}

Console.WriteLine("First Array:");
for (int n = 0; n < numbers.Length; n++)
{
    Console.WriteLine(numbers[n]);
}

Console.WriteLine("Second Array:");
for (int c = 0; c < numbers.Length; c++)
{
    Console.WriteLine(copy[c]);
}