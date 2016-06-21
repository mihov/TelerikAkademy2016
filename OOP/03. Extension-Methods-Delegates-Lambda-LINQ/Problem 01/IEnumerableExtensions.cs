using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    public static class IEnumerableExtensions
    {
        public static int ExtSum<T>(this IEnumerable<T> theInput)
        {
            var result = theInput.Select(x => Convert.ToInt32(x)).Sum();
            return result;
        }

        public static int ExtProduct<T>(this IEnumerable<T> theInput)
        {
            int result = 1;
            var intList = theInput.Select(x => Convert.ToInt32(x)).ToList();

            foreach (var item in intList)
            {
                result *= item;
            }

            return result;
        }

        public static int ExtMin<T>(this IEnumerable<T> theInput)
        {
            var result = theInput.Select(x => Convert.ToInt32(x)).Min();

            return result;
        }

        public static int ExtMax<T>(this IEnumerable<T> theInput)
        {
            var result = theInput.Select(x => Convert.ToInt32(x)).Max();

            return result;
        }

        public static decimal ExtAverage<T>(this IEnumerable<T> theInput)
        {
            var result = theInput.Select(x => Convert.ToDecimal(x)).Average();

            return result;
        }

        public static string ExtPrint<T>(IEnumerable<T> theInput)
        {
            return string.Join(" ", theInput);
        }

    }
}
