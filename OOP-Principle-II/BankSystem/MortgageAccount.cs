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
                int chekForNegativeMounts = mounts - noIntrestForIndividuals >= 0 ? mounts - noIntrestForIndividuals : 0; // ajusting mounts

                base.CalculateIntrestRate(chekForNegativeMounts);
            }
            else
            {
                if (mounts < 12)
                {
                    base.CalculateIntrestRate(mounts / 2); //if less then 12 mounts intrest reate is 1/2 => insted calc half for 12 mounts  - we do full for 6
                }
                else
                {
                    base.CalculateIntrestRate(mounts - 6); //same as above
                }
            }
            
        }
    }
}
