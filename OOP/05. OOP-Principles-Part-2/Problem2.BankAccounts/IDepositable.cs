using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2.BankAccounts
{
    public interface IDepositable
    {
        void Deposit(decimal deposit);
    }
}