using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public static class Sort
    {
        public static Human[] SortByFirstAndLastName(Human[] human)
        {
            var result = human
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();
            return result;
        }
    }
}
