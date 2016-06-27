using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customers customer, String owner) : base(customer, owner)
        {

        }

        public override void CalculateInterest(int period)
        {
            if (this.Customer == Customers.Individuals)
            {
                if (Bank.MonthDifference(Bank.VirtualDate, this.DateOfCreation) > 6)
                {
                    this.Balance = this.Balance * (1 + (this.InterestRate * period));
                }

            }
            else
            {
                if (Bank.MonthDifference(Bank.VirtualDate, this.DateOfCreation) > 12)
                {
                    this.Balance = this.Balance * (1 + (this.InterestRate * period));
                }
                else
                {
                    this.Balance = this.Balance * (1 + (this.InterestRate * period / 2));
                }
            }
        }
    }
}

/*
Mortgage accounts have ½ interest for the first 12 months for companies 
and no interest for the first 6 months for individuals.
*/
