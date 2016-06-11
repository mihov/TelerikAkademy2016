using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSMCallHistoryTest
    {
        private GSM myTestGsm = new GSM("Nexus 4", "Google", 345, "Spartac");
        
        private const decimal PricePerMinute = 0.37m;

        public void Functionality()
        {
            Console.WriteLine("\t\tCall history test");
            Console.WriteLine(myTestGsm);
            myTestGsm.AddCall(new Call(new DateTime(2015, 03, 09, 12, 30, 05), "0887 12 34 56", 123));
            myTestGsm.AddCall(new Call(new DateTime(2015, 03, 10, 13, 03, 55), "0888 33 44 55", 234));
            myTestGsm.AddCall(new Call(new DateTime(2015, 03, 10, 14, 13, 05), "0889 55 66 77", 345));
            myTestGsm.AddCall(new Call(new DateTime(2015, 03, 14, 22, 03, 25), "0886 77 99 88", 456));
            myTestGsm.AddCall(new Call(new DateTime(2015, 03, 16, 22, 03, 05), "0885 66 44 22", 567));

            Console.WriteLine(myTestGsm.CallHistoryInfo());
            Console.WriteLine("Total price: {0:f2} BGN", myTestGsm.CalculateTotalCallPrice(PricePerMinute));

            Call longestCall = myTestGsm.CallHistory.OrderByDescending(x => x.Duration).First();

            myTestGsm.DelCall(longestCall);

            Console.WriteLine(
                "Total price after removing longest call is {0:f2} BGN",
                myTestGsm.CalculateTotalCallPrice(PricePerMinute));

            myTestGsm.ClearHistory();

            Console.WriteLine(myTestGsm.CallHistoryInfo());
        }
    }
}
