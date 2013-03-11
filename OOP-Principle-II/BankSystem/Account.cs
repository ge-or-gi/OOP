using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public abstract class Account
    {
        private Customer _Customer;

        public Customer Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }

        private int _balance;

        public int Balance
        {
            get { return _balance; }
            set 
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Ballance cant be less than zero");
                    }
                    else
                    {
                        _balance = value;
                    }
                    
                }
        }

        private int _intrestRate;
        
        public int IntrestRate
        {
            get { return _intrestRate; }
            set 
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Intrest Rate Cant be Less than ZERO");
                    }
                    else
                    {
                        _intrestRate = value; 
                    }

                }
        }

        public Account(Customer customer, int balance, int intrestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.IntrestRate = intrestRate;
        }

        public virtual void CalculateIntrestRate(int mounts) 
        {
            if (mounts < 0)
            {
                throw new ArgumentException("Mounts cant be less than zero");
            }
            else
            {
                int result = 0;
                result = (mounts * (this.IntrestRate * this.Balance)) / 100;

                Console.WriteLine(result);
            }
            
        }

    }
}
