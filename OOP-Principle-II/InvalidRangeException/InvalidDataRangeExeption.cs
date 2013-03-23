using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidDataRangeExeption<T> : ApplicationException
{
    
    private T _min;
    private T _max;

     
    public T Min
    {
        get { return _min; }
        set { _min = value; }
    }
    public T Max
    {
        get { return _max; }
        set { _max = value; }
    }


    public InvalidDataRangeExeption(string message, T min, T max, Exception innerException) 
        : base(message, innerException)
    {
        this.Min = min;
        this.Max = max;
    }

    public InvalidDataRangeExeption(string message, T min, T max)
        : this(message, min, max, null)
    {

    }

    public InvalidDataRangeExeption(T min, T max)
        : this(null, min, max, null)
    {
    
    }

    public override string Message
    {
        get
        {
            string result = String.Format("{0} : {1} - {2}", base.Message, this.Min, this.Max);
            return result;
        }
    }
}