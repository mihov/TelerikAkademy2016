using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string colorString = "VIP1";


            Role colorValue = (Role)Enum.Parse(typeof(Role), colorString);

            Console.WriteLine((int)colorValue);

            if (Enum.IsDefined(typeof(Role), colorValue) | colorValue.ToString().Contains(","))
                Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());
            else
                Console.WriteLine("{0} is not an underlying value of the Colors enumeration.", colorString);

        }
    }
}