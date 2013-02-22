using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Point myPoint = new Point();
            myPoint.PointX = 3;
            myPoint.PointY = 4;
            myPoint.PointZ = 5;

            Console.WriteLine(myPoint.ToString());

        }
    }
}
