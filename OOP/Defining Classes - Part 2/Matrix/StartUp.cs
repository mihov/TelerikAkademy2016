namespace Matrix
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            var firstMatrix = new Matrix<int>(3, 5);
            firstMatrix.FillMatrix();
            Console.WriteLine(firstMatrix);

            var secondMatrix = new Matrix<int>(3, 5);
            secondMatrix.FillMatrix();
            secondMatrix[1, 1] = 0;
            Console.WriteLine(secondMatrix);

            var thirdMatrix = new Matrix<int>(9, 3);
            thirdMatrix.FillMatrix();
            Console.WriteLine(thirdMatrix);

            Console.WriteLine($"Addition:\n{firstMatrix + secondMatrix}");
            Console.WriteLine($"Subtraction :\n{firstMatrix - secondMatrix}");
            Console.WriteLine($"Multiplication:\n{firstMatrix * thirdMatrix}");

            var isTrue = firstMatrix ? "True" : "False";
            Console.WriteLine(isTrue);

            isTrue = secondMatrix ? "True" : "False";
            Console.WriteLine(isTrue);

        }
    }
}
