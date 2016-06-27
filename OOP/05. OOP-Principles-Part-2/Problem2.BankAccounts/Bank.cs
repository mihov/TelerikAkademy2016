using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public class Bank
    {
        public static DateTime VirtualDate { get; set; }

        private List<Account> accountsList;

        public String Name { get; private set; }

        public Bank(String name)
        {
            this.Name = name;
            accountsList = new List<Account>();
            VirtualDate = DateTime.Now;
        }

        public void AddAccount(Account value)
        {
            this.accountsList.Add(value);
        }

        public Account SelectAccount( Customers customer, String owneName) {
            return accountsList.Find(x => x.Owner == owneName && x.Customer == customer);
        }

        public bool RemoveAccount(Account value)
        {
            return this.accountsList.Remove(value);
        }

        public void PrintAccounts()
        {
            Console.WriteLine("\n ================= All Bank Accounts =================");
            int cnt = 1;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",
                    "No".PadLeft(5),
                    "Name".PadRight(25),
                    "Type".PadRight(15),
                    "Interest Rate".PadLeft(15),
                    "Balance".PadLeft(15)
             );
            foreach (var item in this.accountsList)
            {
                Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",
                    cnt.ToString().PadLeft(5),
                    item.Owner.PadRight(25),
                    item.Customer.ToString().PadRight(15),
                    item.InterestRate.ToString().PadLeft(15),
                    item.Balance.ToString().PadLeft(15)
                    );
                cnt++;
            }

            Console.WriteLine("\n ================= End Of All Bank Accounts =================");
        }
    }
}