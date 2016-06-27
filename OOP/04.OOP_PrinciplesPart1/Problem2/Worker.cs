using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    public class Worker : Human
    {
        public Worker(String fName, String lName) : base(fName, lName)
        {

        }

        public decimal WeekSalary { get; set; }


        public int WorkHoursPerDay { get; set; }


        public decimal MoneyPerHour()
        {
            return this.WeekSalary / WorkHoursPerDay / 8M;
        }
    }
}