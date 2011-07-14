using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet.WordRec
{
    public struct TPoint
    {
        //public void operator +(TPoint other)
        //{
        //    x += other.x;
        //    y += other.y;
        //}
        //void operator /(int divisor, int a)
        //{
        //    x /= divisor;
        //    y /= divisor;
        //}

        public void add(TPoint point)
        {
            this.x = (Int16)(this.x + point.x);
            this.y = (Int16)(this.y + point.y);
        }

        public void div(int divisor)
        {
            this.x = (Int16)(this.x / divisor);
            this.y = (Int16)(this.y / divisor);
        }


        public Int16 x;                       // absolute x coord.
        public Int16 y;                       // absolute y coord.
    }
}
