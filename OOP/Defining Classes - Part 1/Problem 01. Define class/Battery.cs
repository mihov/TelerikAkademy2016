using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    internal class Battery
    {
        private BatteryType batType;
        private float? hoursIdle;
        private float? hoursTalk;

        public Battery(BatteryType batType, int hoursIdle, int hoursTalk)
        {
            this.batType = batType;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.batType;
            }

            set
            {
                this.batType = value;
            }
        }

        public float? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle can not be negative.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public float? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Talk can not be negative.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("\nBattery:");
            result.Append("\n\tType: " + this.batType);
            result.Append("\n\tHours Idle: ");
            if (this.hoursIdle == null)
            {
                result.Append("no information");
            }
            else
            {
                result.Append(this.hoursIdle);
            }
            result.Append("\n\tHours Talk: ");
            if (this.hoursTalk == null)
            {
                result.Append("no information");
            }
            else
            {
                result.Append(this.hoursTalk);
            }

            return result.ToString();
        }


    }
}
