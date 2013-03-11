using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public abstract class Customer
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Customer(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        
    }
}
