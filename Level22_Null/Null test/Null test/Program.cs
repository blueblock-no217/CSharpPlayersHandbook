Console.WriteLine("Hello, World!");


// if null is provided, it will return "(No input provided)" instead of throwing an exception
// ?? is a null-coalescing operator that returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand.
string text = Console.ReadLine() ?? "(No input provided)";
//Console.WriteLine(text.Length);
Console.WriteLine($"You write {text}");