namespace Problem2.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StartUp
    {
        static void Main()
        {
            Bank cCB = new Bank("CCB");

            Deposit ivanDepositAccount = new Deposit(Customers.Individuals, "Ivan Ivanov");
            ivanDepositAccount.Deposit(1200.00m);
            ivanDepositAccount.PrintDeposits();

            cCB.PrintAccounts();

            cCB.AddAccount(ivanDepositAccount);

            cCB.PrintAccounts();

            cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").Deposit(300.00m);
            cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").PrintDeposits();
        }
    }
}
