using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Account
    {
        public int balance = 0;

        // Withdraw money from account
        public void Withdraw(int amount)
        { balance -= amount;  }
        // Deposit money to account
        public void Deposit(int amount)
        { balance += amount; }
        // Return the account balance
        public int GetBalance()
        { return this.balance; }
    }
}
