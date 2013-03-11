using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class Company : Customer
    {

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public Company(string fName, string lName, string cName): base(fName, lName)
        {
            this.CompanyName = cName;
        }
    }
}
