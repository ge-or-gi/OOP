using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class LoanAccount : Account, IDepositable
    {

        public LoanAccount(Customer customer, int balance, int intrestRate)
            : base(customer, balance, intrestRate)
        { }

        public void DepositMoney(int money)
        {
           this.Balance += money;
        }

        public override void CalculateIntrestRate(int mounts)
        {
            int noIntrestForIndividuals = 3;
            int noIntrestForCompanyes = 2;

            if (Customer is Individual)
            {
                base.CalculateIntrestRate(mounts - noIntrestForIndividuals);
            }
            else
            {
                base.CalculateIntrestRate(mounts - noIntrestForCompanyes);
            }
            
        }
    }
}
