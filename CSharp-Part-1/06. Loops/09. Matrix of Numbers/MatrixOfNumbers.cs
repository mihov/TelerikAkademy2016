using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < row + n; col++)
            {
                Console.Write("{0}{1}",col," ");
            }
            Console.WriteLine();
        }
    }
}
