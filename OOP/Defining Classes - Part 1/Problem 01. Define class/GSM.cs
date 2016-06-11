using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    internal class GSM
    {
        public static readonly GSM IPhone4S = new GSM("IPhone4S", "Apple", 350, "Jhonatan", new Battery(BatteryType.LiIon, 60, 30), new Display(4.3f, 36000000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        // Problem 2. Constructors
        public GSM(string model, string manufacture)
        {
            this.Model = model;
            this.Manufacturer = manufacture;
            this.Price = null;

        }

        // Problem 2. Constructors
        public GSM(string model, string manufacture, decimal price = 0, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacture;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            return "\n==================================\nModel: " + Model +
                "\nManufacture: " + Manufacturer +
                "\nOwner: " + Owner +
                "\nPrice: $" + Price +
                "\n" + Battery + Display + "\n";
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery { get; set; }
        public Display Display { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            uint totalSeconds = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalSeconds += this.callHistory[i].Duration;
            }

            decimal price = totalSeconds * (pricePerMinute / 60);
            //// decimal price = Math.Ceiling(totalSeconds / 60.0m) * pricePerMinute;

            return price;
        }

        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();



            if (this.callHistory.Count == 0)
            {
                return "Call history is empty!";
            }
            else {
                callHistoryInfo.Append("========================== Call history =========================");
                callHistoryInfo.Append("\n| Date\t\t| ");
                callHistoryInfo.Append("Time \t\t| ");
                callHistoryInfo.Append("Dailed number\t| ");
                callHistoryInfo.Append("Duration\t|\n");
                callHistoryInfo.Append("-----------------------------------------------------------------\n");

                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    callHistoryInfo.Append(this.callHistory[i].ToString());
                    callHistoryInfo.Append("\n");
                }

                return callHistoryInfo.ToString();
            }
        }

        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void DelCall(Call currentCall)
        {
            this.callHistory.Remove(currentCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }


    }
}
