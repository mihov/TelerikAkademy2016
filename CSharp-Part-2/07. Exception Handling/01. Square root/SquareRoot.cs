using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("{0:f3}",Sqrt(double.Parse(Console.ReadLine())));
        }
        catch(Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }

    static double Sqrt(double value)
    {
        if (value < 0)
            throw new System.ArgumentOutOfRangeException(
               "Sqrt for negative numbers is undefined!");

        return Math.Sqrt(value);
    }
}
