using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassShape
{
    abstract class Shape
    {
        protected int Heigh{get; set;}
	    protected int Weight{get; set;}

	    public Shape(int heigh, int weight)
	    {
		    this.Heigh = heigh;
		    this.Weight = weight;
	    }

        public abstract void CalculateSurface();

    }
}
