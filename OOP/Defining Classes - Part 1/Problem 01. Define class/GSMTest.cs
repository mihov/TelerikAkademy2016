using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class GSMTest
    {
        private GSM[] myGSMTest =
        {
            new GSM("S7 Edge", "Samsung"),
            new GSM("S6 Edge", "Samsung", 500, "Ivan Ivanov", new Battery(BatteryType.LiPol, 300, 150), new Display(6.1f, 64000000)),
            new GSM("Nexus 4", "Google", 200, "Chavdar", new Battery(BatteryType.LiPol, 400, 250), new Display(4.1f, 64000000)),
            new GSM("Nexus 5", "Google", 340, "Spas", new Battery(BatteryType.LiIon, 500, 250), new Display(5.2f, 64000000)),
        };

        public void DisplayGsmInformation()
        {
            foreach (var gsm in myGSMTest)
            {
                Console.WriteLine(gsm);

            }

            Console.WriteLine(GSM.IPhone4S);
        }

    }
}
