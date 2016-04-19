using System;

class Sort3Numbers
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int temp;

        if (n1 > n2)
        {
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        if (n2 > n3)
        {
            temp = n2;
            n2 = n3;
            n3 = temp;
        }

        if (n1 > n2)
        {
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        Console.WriteLine("{0} {1} {2}", n3, n2, n1);
    }
}
