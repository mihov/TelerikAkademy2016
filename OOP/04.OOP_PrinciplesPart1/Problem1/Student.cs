using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class Student : People
    {
        private String uCNumber;
        public Student(String name) : base(name)
        {
            UCNumber = "00000000";
        }

        public String UCNumber
        {
            get
            {
                return this.uCNumber;
            }

            set
            {
                if (value.Length < 1) throw new ArgumentException("UC Number con't be empty!");
                else
                    this.uCNumber = value;
            }
        }
    }
}