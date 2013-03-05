using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework
{

    public delegate void TestDelegate(string mesage);

    class Program
    {
        static void Main(string[] args)
        {

            DummyClas myDummyClass = new DummyClas();

            TestDelegate td = new TestDelegate(myDummyClass.CallDelegate);

            td("georgi");

            


        }

        
    }
}
