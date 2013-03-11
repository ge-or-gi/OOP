using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class DepositAccount : Account, IDepositable, IWithdrawabel
    {

        public DepositAccount(Customer name, int balance, int intrestRate) : base(name, balance, intrestRate) { }

        public void DepositMoney(int money) 
        {
            this.Balance += money;
        }

        public void WithdrawMoney(int money)
        {
            this.Balance -= money;
        }

        public override void CalculateIntrestRate(int mounts)
        {
            if (this.Balance >= 1000)
            {
                base.CalculateIntrestRate(mounts);   
            }
            else
            {
                Console.WriteLine("Ballance in this account is less then 1000 - it is exactly - {0}", this.Balance);
            }
        }

    }
}
