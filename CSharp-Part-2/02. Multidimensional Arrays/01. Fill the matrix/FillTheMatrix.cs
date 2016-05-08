using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillTheMatrix
{
    static void Main()
    {
        int dimention = int.Parse(Console.ReadLine());
        char mode = Console.ReadLine()[0];
        int[,] theMatrix = new int[dimention, dimention];
        int counter = 1;

        switch (mode)
        {
            case 'a':
                for (int i = 0; i < dimention; i++)
                {
                    for (int j = 0; j < dimention; j++)
                    {
                        theMatrix[j, i] = counter;
                        counter++;
                    }
                }

                PrintMatrix(theMatrix);
                break;
            case 'b':
                break;
            case 'c':
                break;
            case 'd':
                break;

            default:
                break;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}{1}", matrix[i, j], (j + 1 < matrix.GetLength(1)) ? " " : "\n");
            }

        }
    }
}