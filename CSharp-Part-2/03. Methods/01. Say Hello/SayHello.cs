using System;

class SayHello
{
    static void Main()
    {
        PrintSayHello(Console.ReadLine());
    }

    static void PrintSayHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}
