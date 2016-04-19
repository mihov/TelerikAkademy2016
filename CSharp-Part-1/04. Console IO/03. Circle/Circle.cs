using System;

class Circle
{
    static void Main()
    {
        float radius = float.Parse(Console.ReadLine());

        Console.WriteLine("{0:f2} {1:f2}", 2 * Math.PI * radius, Math.PI * radius * radius);
    }
}
