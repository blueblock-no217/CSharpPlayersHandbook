Console.WriteLine("Hello, World!");

CountDown(10);
int CountDown(int num)
{ 
    if (num == 0)
        return 0;

    Console.WriteLine(num);
    return CountDown(num - 1);
}