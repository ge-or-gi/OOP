using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class BankSystem
    {
        static void Main(string[] args)
        {


            Individual cu1 = new Individual("Georgi", "Mollov");
            Company co1 = new Company("Dimmo", "Petrov", "DimoPetrov Limited");

            DepositAccount deAcc = new DepositAccount(cu1, 100, 5);
            LoanAccount loAcc = new LoanAccount(cu1, 200, 10);
            MortgageAccount moAcc = new MortgageAccount(cu1, 300, 15);

            DepositAccount companyDeAcc = new DepositAccount(co1, 1000, 0);
            LoanAccount companyLoAcc = new LoanAccount(co1, 2000, 10);
            MortgageAccount companyMoAcc = new MortgageAccount(co1, 3000, 15);

            deAcc.WithdrawMoney(50);
            loAcc.DepositMoney(200);
            moAcc.DepositMoney(300);

            deAcc.CalculateIntrestRate(-3);

            moAcc.CalculateIntrestRate(4);

            companyMoAcc.CalculateIntrestRate(2);

            deAcc.WithdrawMoney(50);

            //loAcc.CalculateIntrestRate(2);
            companyLoAcc.CalculateIntrestRate(1);

            

              



        }
    }
}
