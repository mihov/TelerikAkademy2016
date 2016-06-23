using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class Discipline : Inameble
    {
        private String name;

        public Discipline(String name)
        {
            throw new System.NotImplementedException();
        }

        public int Lectures { get; set; }

        public int Exercises { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 1) throw new ArgumentException("Name can't be empty!");
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