using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    public class Display
    {
        private float? size;
        private uint? numnumberOfColors;

        public Display(float? size = null, uint? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }


        public float? Size
        {
            get
            { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size can not be negative!");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public uint? NumberOfColors
        {
            get
            {
                return this.numnumberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors can not be negative!");
                }
                else
                {
                    this.numnumberOfColors = value;
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("\nDisplay:\n\tSize: ");
            if (this.size == null)
            {
                result.Append("no information");
            }
            else
            {
                result.Append(this.size);
            }
            result.Append("\n\tColors: ");
            if (this.size == null)
            {
                result.Append("no information");
            }
            else
            {
                result.Append(this.numnumberOfColors);
            }

            return result.ToString();
        }
    }
}
