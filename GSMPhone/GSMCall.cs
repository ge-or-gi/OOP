using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMPhone
{
    class GSMCall
    {

        private TimeSpan _callDuration;
        private int _phoneNumber;

        
        public GSMCall(string callDuration, int phoneNumber)
        {
            this._callDuration = TimeSpan.Parse(callDuration);
            this._phoneNumber = phoneNumber;
        }



        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public TimeSpan CallDuration
        {
            get { return _callDuration; }
            set { _callDuration = value; }
        }




    }
}
