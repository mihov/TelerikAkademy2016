using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public abstract class Account : IDepositable
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate; // per year
        private DateTime createdOn;
        private List<AccRec> depRecords;

        private String owner;

        public Account(Customers customer, String ownerName)
        {
            DateTime today = DateTime.Now;
            today = Bank.VirtualDate;// Comment this row in real use

            this.Customer = customer;
            this.DateOfCreation = today;
            this.Owner = ownerName;
            this.Balance = 0;
            this.depRecords = new List<AccRec>();

        }

        public String Owner { get; private set; }

        public DateTime DateOfCreation
        {
            get
            {
                return this.createdOn;
            }

            private set
            {
                this.createdOn = value;
            }

        }
        public Customers Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                this.interestRate = value;
            }
        }

        public void CalculateInterest()
        {
            DateTime today = DateTime.Now;
            today = Bank.VirtualDate;// Comment this row in real use
        }

        public void Deposit(decimal deposit)
        {
            DateTime today = DateTime.Now;
            today = Bank.VirtualDate;// Comment this row in real use

            this.Balance += deposit;
            this.depRecords.Add(new AccRec(deposit, today));
        }

        public void PrintDeposits(DateTime from, DateTime to)
        {
            Console.Write(this.Owner);
            Console.WriteLine(" deposits records from: {0} to: {1}", from.ToShortDateString(), to.ToShortDateString());

            int cnt = 1;
            Console.WriteLine("|{0}|{1}|{2}|",
                    "No".PadLeft(5),
                    "Date".PadRight(15),
                    "Amount".PadLeft(15)
             );
            foreach (var item in this.depRecords)
            {
                if (item.Date >= from && item.Date <= to)
                {
                    Console.WriteLine("|{0}|{1}|{2}|",
                        cnt.ToString().PadLeft(5),
                        item.Date.ToShortDateString().PadRight(15),
                        item.Amount.ToString().PadLeft(15)
                    );
                    cnt++;
                }
            }
        }

        public void PrintDeposits()
        {
            Console.Write(this.Owner);
            Console.WriteLine(" deposits records");

            int cnt = 1;
            Console.WriteLine("|{0}|{1}|{2}|",
                    "No".PadLeft(5),
                    "Date".PadRight(15),
                    "Amount".PadLeft(15)
             );
            foreach (var item in this.depRecords)
            {

                Console.WriteLine("|{0}|{1}|{2}|",
                    cnt.ToString().PadLeft(5),
                    item.Date.ToShortDateString().PadRight(15),
                    item.Amount.ToString().PadLeft(15)
                );
                cnt++;
            }
        }
    }
}