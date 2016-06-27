using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public struct AccRec
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public AccRec(decimal amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}