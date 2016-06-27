using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public class Deposit : Account, IWithDraw
    {
        private List<AccRec> wdRecords;

        public bool WithDraw(decimal withDraw)
        {
            if (this.Balance >= withDraw)
            {
                this.Balance = this.Balance - withDraw;

                DateTime today = DateTime.Now;
                today = Bank.VirtualDate;// Comment this row in real use
                this.wdRecords.Add(new AccRec(withDraw, today));
                return true;
            }
            else
            {
                return false;
            }
        }


        public Deposit(Customers customer, String owner) : base(customer, owner)
        {
            this.wdRecords = new List<AccRec>();
        }

        public void PrintWithDraws(DateTime from, DateTime to)
        {
            Console.Write(this.Owner);
            Console.WriteLine(" with draw records from: {0} to: {1}", from.ToShortDateString(), to.ToShortDateString());

            int cnt = 1;
            Console.WriteLine("|{0}|{1}|{2}|",
                    "No".PadLeft(5, ' '),
                    "Date".PadRight(15),
                    "Amount".PadRight(15)
             );
            foreach (var item in this.wdRecords)
            {
                if (item.Date >= from && item.Date <= to)
                {
                    Console.WriteLine("|{0}|{1}|{2}|",
                        cnt.ToString().PadLeft(5, ' '),
                        item.Date.ToShortDateString().PadRight(15),
                        item.Amount.ToString().PadRight(15)
                        );
                    cnt++;
                }
            }
        }


        public void PrintWithDraws()
        {
            Console.Write(this.Owner);
            Console.WriteLine(" with draw records");

            int cnt = 1;
            Console.WriteLine("|{0}|{1}|{2}|",
                    "No".PadLeft(5, ' '),
                    "Date".PadRight(15),
                    "Amount".PadRight(15)
             );
            foreach (var item in this.wdRecords)
            {

                Console.WriteLine("|{0}|{1}|{2}|",
                    cnt.ToString().PadLeft(5, ' '),
                    item.Date.ToShortDateString().PadRight(15),
                    item.Amount.ToString().PadRight(15)
                    );
                cnt++;

            }
        }

        public override void CalculateInterest(int period)
        {
            if (this.Balance >= 1000)
            {
                this.Balance = this.Balance * (1 + (this.InterestRate * period));
            }

        }
    }
}