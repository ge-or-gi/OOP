using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalAssistant
{
    public class Gift : Reminder
    {
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Gift(int price, string title, string content)
            :base(title, content)
        { 
            this.Price = price;
        }

    }
}
