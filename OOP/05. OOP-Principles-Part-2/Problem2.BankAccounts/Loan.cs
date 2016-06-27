using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public class Loan:Account
    {
        public Loan(Customers customer, String owner) : base(customer, owner)
        {

        }

        public override void CalculateInterest(int period)
        {
            if (this.Customer == Customers.Individuals)
            {
                if (Bank.MonthDifference(Bank.VirtualDate, this.DateOfCreation) > 3)
                {
                    this.Balance = this.Balance * (1 + (this.InterestRate * period));
                }
            }
            else
            {
                if (Bank.MonthDifference(Bank.VirtualDate, this.DateOfCreation) > 2)
                {
                    this.Balance = this.Balance * (1 + (this.InterestRate * period));
                }
            }
        }
    }


}