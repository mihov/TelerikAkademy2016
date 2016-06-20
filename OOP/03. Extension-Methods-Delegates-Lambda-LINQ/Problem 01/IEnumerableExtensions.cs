using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    public static class IEnumerableExtensions
    {
        public static int Sum<T>(this IEnumerable<T> theInput)
        {
            return theInput.Select( x => Convert.ToInt32(x)).Sum();
        }

    }
}
