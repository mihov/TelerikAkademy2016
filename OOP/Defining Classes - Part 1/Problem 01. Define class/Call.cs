using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Call
    {
        public Call(DateTime dateTime, string phoneNumber, uint duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToLongTimeString();
            this.DiledTo = phoneNumber;
            this.Duration = duration;
        }

        public string Date { get; private set; }
        public string Time { get; private set; }
        public string DiledTo { get; private set; }
        public uint Duration { get; private set; }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("| " + this.Date + "\t| ");
            result.Append(this.Time + " \t| ");
            result.Append(this.DiledTo + "\t| ");
            result.Append(this.Duration + "s\t\t|");
            return result.ToString();
        }


    }
}
