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

            // Define bank CCB and FIB
            Bank cCB = new Bank("CCB");
            Bank fIB = new Bank("FIB");

            // Define Deposit AccountS
            Deposit ivanDepositAccount = new Deposit(Customers.Individuals, "Ivan Ivanov");
            ivanDepositAccount.Deposit(1200.00m);
            ivanDepositAccount.InterestRate = 3.3m;

            Deposit ibmDepositAccount = new Deposit(Customers.Companies, "IBM");
            ibmDepositAccount.Deposit(56789.00m);
            ibmDepositAccount.InterestRate = 5m;

            // Define Mortgage AccountS
            Mortgage georgiMortgageAccount = new Mortgage(Customers.Individuals, "Georgi Geogiev");
            georgiMortgageAccount.Deposit(1500.00m);
            georgiMortgageAccount.InterestRate = 4.3m;

            Mortgage hpMortgageAccount = new Mortgage(Customers.Companies, "HP");
            hpMortgageAccount.Deposit(54321.00m);
            hpMortgageAccount.InterestRate = 5m;

            // Define Loan AccountS
            Loan vasilLoanAccount = new Loan(Customers.Individuals, "Vasil Vasilev");
            vasilLoanAccount.Deposit(1500.00m);
            vasilLoanAccount.InterestRate = 2.3m;

            Deposit hondaDepositAccount = new Deposit(Customers.Companies, "Honda");
            hondaDepositAccount.Deposit(55555.00m);
            hondaDepositAccount.InterestRate = 6m;

            // Add accounts to the bank
            cCB.AddAccount(ivanDepositAccount);
            cCB.AddAccount(ibmDepositAccount);
            cCB.AddAccount(georgiMortgageAccount);
            cCB.AddAccount(hpMortgageAccount);
            cCB.AddAccount(vasilLoanAccount);
            cCB.AddAccount(hondaDepositAccount);

            // Print all accounts
            cCB.PrintAccounts();

            // Do some deposits
            cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").Deposit(300.00m);
            cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").Deposit(400.00m);

            cCB.SelectAccount(Customers.Companies, "IBM").Deposit(3000.00m);
            cCB.SelectAccount(Customers.Companies, "IBM").Deposit(1000.00m);

            cCB.SelectAccount(Customers.Individuals, "Georgi Geogiev").Deposit(320.00m);
            cCB.SelectAccount(Customers.Individuals, "Georgi Geogiev").Deposit(430.00m);

            cCB.SelectAccount(Customers.Companies, "HP").Deposit(3500.00m);
            cCB.SelectAccount(Customers.Companies, "HP").Deposit(1400.00m);

            cCB.SelectAccount(Customers.Individuals, "Vasil Vasilev").Deposit(530.00m);
            cCB.SelectAccount(Customers.Individuals, "Vasil Vasilev").Deposit(530.00m);

            cCB.SelectAccount(Customers.Companies, "Honda").Deposit(3500.00m);
            cCB.SelectAccount(Customers.Companies, "Honda").Deposit(5500.00m);

            // Print all accounts after deposits
            cCB.PrintAccounts();

            cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").PrintDeposits();
            Console.WriteLine(cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").Balance);


            (cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov") as Deposit).WithDraw(333);
            (cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov") as Deposit).PrintWithDraws();
            Console.WriteLine(cCB.SelectAccount(Customers.Individuals, "Ivan Ivanov").Balance);

        }
    }
}
