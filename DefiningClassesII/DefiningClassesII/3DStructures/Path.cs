using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DStructures
{
    class AddPoint
    {

        private List<Point> _pointsList = new List<Point>();


        public List<Point> PointsList
        {
            get { return _pointsList; }
            set { _pointsList = value; }
        }
        
    }
}
