using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMPhone
{
    class GSM
    {
        private string _make;
        private string _model;
        private string _owner;
        private GSMBattery _battery;
        private GSMDisplay _display;
        private List<GSMCall> _callHistory;

        internal List<GSMCall> CallHistory
        {
            get { return _callHistory; }
            set { _callHistory = value; }
        }

        public GSMDisplay Display
        {
            get { return _display; }
            set { _display = value; }
        }
        

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public GSMBattery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }

        public string printInfo()
        {
            string fullInfo = "";

            fullInfo = Make + " " + Model + " " + Owner + " " + Battery.Battery.ToString() + " " + Battery.HoursTalk + " " + Battery.IdleTime + " " + Display.X_PixelSize + "X" + Display.Y_PixelSize + " " + Display.Colors;
            return fullInfo;
        }
        
        
    }
}
