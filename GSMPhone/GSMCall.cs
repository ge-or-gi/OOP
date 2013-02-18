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
        private DateTime _startTime;

                
        public GSMCall(string startTime, string callDuration, int phoneNumber)
        {
            this._startTime = DateTime.Parse(startTime);
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

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }


    }
}
