using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    public class Student:Human
    {
        private decimal grade;

        public Student(String fName, String lName):base(fName, lName)
        {
           
        }

        public decimal Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                this.grade = value;
            }
        }


    }


}