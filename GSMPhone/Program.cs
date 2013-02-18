using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMPhone
{
    class Program
    {
        static void Main(string[] args)
        {



            GSMBattery LithiumIon = new GSMBattery(GSMBattery.BatteryType.Jeliazna, 128, 24);
            GSMBattery NickelCadmi = new GSMBattery(GSMBattery.BatteryType.Plastmasova, 12, 48);
            GSMBattery MetalnoIonna = new GSMBattery(GSMBattery.BatteryType.Jeliazna, 100, 34);

            GSMDisplay Pixels800X600 = new GSMDisplay(800, 600, 256);
            GSMDisplay Pixles600X400 = new GSMDisplay(600, 400, 16000);

            GSMCall clal1 = new GSMCall("0:22:11", 088888888);
            GSMCall clal2 = new GSMCall("0:06:01", 088877777);
            GSMCall clal3 = new GSMCall("0:01:34", 088866666);

            GSM myFirstGsm = new GSM();
            myFirstGsm.Model = "Xperia";
            myFirstGsm.Make = "SonyEricson";
            myFirstGsm.Owner = "Georgi";
            myFirstGsm.Battery = LithiumIon;
            myFirstGsm.Display = Pixels800X600;
            myFirstGsm.CallHistory = new List<GSMCall>();
            

            GSM mySecondGsm = new GSM();
            mySecondGsm.Model = "HTC ONE";
            mySecondGsm.Make = "HTC";
            mySecondGsm.Owner = "Stefan";
            mySecondGsm.Battery = NickelCadmi;
            mySecondGsm.Display = Pixles600X400;
            mySecondGsm.CallHistory = new List<GSMCall>();

            
            GSM myThirdGsm = new GSM();
            myThirdGsm.Model = "iPhone";
            myThirdGsm.Make = "Apple";
            myThirdGsm.Owner = "Petyr";
            myThirdGsm.Battery = NickelCadmi;
            myThirdGsm.Display = Pixels800X600;
            myThirdGsm.CallHistory = new List<GSMCall>();

            //mySecondGsm.Battery.HoursTalk = 500;

            //Console.WriteLine(myGsm.Battery.Battery);

            //Console.WriteLine(myFirstGsm.printInfo());

            GSM[] Products = new GSM[3];



            myFirstGsm.CallHistory.Add(new GSMCall("0:00:30", 0878714));
            
            mySecondGsm.CallHistory.Add(clal3);
            mySecondGsm.CallHistory.Add(clal2);
            mySecondGsm.CallHistory.Add(clal1);

            Products[0] = myFirstGsm;
            Products[1] = mySecondGsm;
            Products[2] = myThirdGsm;

            foreach (var item in Products)
            {
                Console.WriteLine(item.printInfo());

                TimeSpan totalTime = TimeSpan.Zero;
                int money = 0;
                foreach (var call in item.CallHistory)
                {
                    Console.WriteLine("\t\t\tPhoneCall: {0}", call.CallDuration.ToString());
                    totalTime += call.CallDuration;
                    
                }
                Console.WriteLine("\t\t\tTotal Time in Seconds: {0} - money: {1}", totalTime.TotalSeconds.ToString(), (int)totalTime.TotalSeconds * 1.0M);
            }

            

        }
    }
}
