using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DStructures
{
    static class DistanceBtwPoints
    {

        public static double Distance(Point pointOne, Point pointTwo)
        {
            double result = 0;
            result = Math.Sqrt(pointOne.PointX * pointTwo.PointX + pointOne.PointY * pointTwo.PointY + pointOne.PointZ * pointTwo.PointZ);

            return result;
        }



    }
}
