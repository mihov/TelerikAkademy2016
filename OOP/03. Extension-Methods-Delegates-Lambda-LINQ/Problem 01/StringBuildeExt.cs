using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    public static class StringBuildeExt
    {
        public static StringBuilder Substring(this StringBuilder theInput, int index, int length)
        {
            return new StringBuilder(theInput.ToString().Substring(index, length));
        }
    }
}
