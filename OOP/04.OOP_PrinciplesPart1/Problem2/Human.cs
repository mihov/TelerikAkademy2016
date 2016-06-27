using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    public abstract class Human
    {
        public Human(String fName, String lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public String FirstName { get; set; }

        public String LastName { get; set; }

    }
}