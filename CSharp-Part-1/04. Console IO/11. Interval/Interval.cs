using System;

class Interval
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()) + 1;
        int m = int.Parse(Console.ReadLine());

        int counter = 0;
               
        for (int i = n; i < m; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        
        Console.WriteLine(counter);
    }
}
