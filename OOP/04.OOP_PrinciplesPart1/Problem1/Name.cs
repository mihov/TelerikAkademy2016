using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public abstract class HasName : Inameble
    {
        private string name;

        public HasName(String value)
        {
            this.Name = value;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 1) throw new ArgumentException("Name con't be empty!");
                else
                    this.name = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}