using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class MortgageAccount : Account, IDepositable
    {

        public MortgageAccount(Customer customer, int balance, int intrestRate)
            : base(customer, balance, intrestRate)
        { }

       
        public void DepositMoney(int money)
        {
            this.Balance += money;
        }

        public override void CalculateIntrestRate(int mounts)
        {
            int noIntrestForIndividuals = 6;
            
            if (Customer is Individual)
            {
                base.CalculateIntrestRate(mounts - noIntrestForIndividuals);
            }
            else
            {
                if (mounts <= 12)
                {
                    base.CalculateIntrestRate(mounts / 2); //if less then 12 mounts intrest reate is 1/2 => insted 12 mounts half intrest rate - it is 6 full mounts
                }
                else
                {
                    base.CalculateIntrestRate(mounts - 6); //same as above
                }
            }
            
        }
    }
}
