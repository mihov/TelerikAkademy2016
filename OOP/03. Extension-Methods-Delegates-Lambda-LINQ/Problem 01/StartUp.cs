using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    class StartUp
    {

        static void Main(string[] args)
        {
            // Problem 1. Test
            StringBuilder text = new StringBuilder("Hello, how are you?");
            Console.WriteLine(text);
            Console.WriteLine(text.Substring(7, 11));

            // Problem 2. Test
            IEnumerable<int> result = from value in Enumerable.Range(1, 5) select value;
            Console.WriteLine(IEnumerableExtensions.ExtPrint(result));
            Console.WriteLine(result.ExtSum());
            Console.WriteLine(result.ExtProduct());
            Console.WriteLine(result.ExtMin());
            Console.WriteLine(result.ExtMax());
            Console.WriteLine(result.ExtAverage());
        }
    }
}
