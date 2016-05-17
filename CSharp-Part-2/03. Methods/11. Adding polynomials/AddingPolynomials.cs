using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddingPolynomials
{
    static void Main()
    {
        Console.ReadLine();
        int[] firstPolynomial = SplitStrToInt(Console.ReadLine());
        int[] secondPolynomial = SplitStrToInt(Console.ReadLine());
        Console.WriteLine(String.Join(" ", AddPly(firstPolynomial, secondPolynomial)));
    }

    private static int[] AddPly(int[] firstPolynomial, int[] secondPolynomial)
    {
        int size = firstPolynomial.GetLength(0);
        int[] result = new int[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }


        return result;
    }

    static int[] SplitStrToInt(string text)
    {
        string[] tokens = text.Split(' ');
        return Array.ConvertAll<string, int>(tokens, int.Parse);
    }


}