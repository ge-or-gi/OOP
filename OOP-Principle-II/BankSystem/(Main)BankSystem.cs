using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Условие по задачата
/*
 * A bank holds different types of accounts for its customers:
 * deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money.
 * Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months).
 * In the common case its is calculated as follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
 * Your task is to write a program to model the bank system by classes and interfaces. 
 * You should identify the classes, interfaces, base classes and abstract actions and
 * implement the calculation of the interest functionality through overridden methods.
*/

#endregion

namespace BankSystem
{
    class BankSystem
    {
        static void Main(string[] args)
        {

            Individual customer1 = new Individual("Georgi", "Mollov");
            Company company1 = new Company("Dimmo", "Petrov", "DimoPetrov Limited");

            DepositAccount customerDepositAccpunt = new DepositAccount(customer1, 100, 5);
            LoanAccount customerLoanAccount = new LoanAccount(customer1, 200, 10);
            MortgageAccount customerMorgageAccount = new MortgageAccount(customer1, 300, 15);

            DepositAccount companyDepositAccount = new DepositAccount(company1, 1000, 0);
            LoanAccount companyLoanAccount = new LoanAccount(company1, 2000, 10);
            MortgageAccount companyMorgageAccount = new MortgageAccount(company1, 3000, 15);

            customerDepositAccpunt.WithdrawMoney(50); 

            customerLoanAccount.DepositMoney(200);
            
            customerMorgageAccount.DepositMoney(300);

            customerDepositAccpunt.CalculateIntrestRate(15);

            customerMorgageAccount.CalculateIntrestRate(20);

            companyMorgageAccount.CalculateIntrestRate(10);

            customerDepositAccpunt.WithdrawMoney(50);

            customerLoanAccount.CalculateIntrestRate(5);
            
            companyLoanAccount.CalculateIntrestRate(6);

        }
    }
}
