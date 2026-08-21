// Data Types
int num = 5;                    // 4 byte 
char aLetter = '\u0061';        // Unicode equivalent to 'a'
string msg = "Hello World!";    // String message
float a = 7.55152525525f;       // Floating point, 7 sig num
double d = 52.11111;            // Double type, 15 sig num
decimal c = 52.557m;            // Decimal type, 28-29 sig num
bool isittrue = true;           // bool type

Console.WriteLine($"String message {msg}");
Console.WriteLine($"int number is {num}");
Console.WriteLine($"A char unicode is {aLetter}");
Console.WriteLine($"Floating point number {a}");
Console.WriteLine($"Double point number {d}");
Console.WriteLine($"Decimal point number {c}");
Console.WriteLine($"boolean data type {isittrue}");