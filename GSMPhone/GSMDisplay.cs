using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMPhone
{
    class GSMDisplay
    {

        private int _xPixelSize;

        public int X_PixelSize
        {
            get { return _xPixelSize; }
          private  set { _xPixelSize = value; }
        }

        private int _yPixelSize;

        public int Y_PixelSize
        {
            get { return _yPixelSize; }
           private set { _yPixelSize = value; }
        }

        private int _colors;

        public int Colors
        {
            get { return _colors; }
          private  set { _colors = value; }
        }

        public GSMDisplay(int X_PixelSize, int Y_PixelSize, int Colors)
        {
            this.X_PixelSize = X_PixelSize;
            this.Y_PixelSize = Y_PixelSize;
            this.Colors = Colors;
        }
                
        
        

    }
}
