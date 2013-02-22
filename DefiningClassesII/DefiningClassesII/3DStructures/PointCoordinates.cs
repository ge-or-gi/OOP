using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point
{
    public int PointX { get; set; }
    public int PointY { get; set; }
    public int PointZ { get; set; }

    public Point(int PointX, int PointY, int PointZ) :this()
    {
        this.PointX = PointX;
        this.PointY = PointY;
        this.PointZ = PointZ;
    }


    private static readonly Point _zeroPoint = new Point(0, 0, 0); // създава нулева точка, поле което не може да се променя

    public static Point ZeroPoint
    {
        get 
        { 
            return Point._zeroPoint; // връща нулевата точка с координати 0,0,0
        }
    } 
  
    
    public  override string ToString()
    {
        string pointAsString = this.PointX + " " + this.PointY + " " + this.PointZ;
        return pointAsString;
    }

}
