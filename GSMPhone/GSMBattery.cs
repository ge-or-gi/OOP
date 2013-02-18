using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMPhone
{
    class GSMBattery
    {

        public enum BatteryType
        {
            Plastmasova, Jeliazna, Gumena
        }

        private BatteryType _battery;

        internal BatteryType Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }


        private int _idleTime;

        public int IdleTime
        {
            get { return _idleTime; }
          private  set { _idleTime = value; }
        }

        private int _hoursTalk;

        public int HoursTalk
        {
            get { return _hoursTalk; }
           private set { _hoursTalk = value; }
        }



        public GSMBattery(BatteryType Battery, int IdleTime, int HoursTalk)
        {
            this.HoursTalk = HoursTalk;
            this.IdleTime = IdleTime;
            this.Battery = Battery;
        }
        

    }
}
