﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            foreach (var item in Console.ReadLine())
            {
                Console.Write(@"QU{0:x4}", (int)item);
            }
        }
    }
}
