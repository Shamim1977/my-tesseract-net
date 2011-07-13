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
            this.x = this.x + point.x;
            this.y = this.y + point.y;
        }

        public void div(int divisor)
        {
            this.x = this.x / divisor;
            this.y = this.y / divisor;
        }


        Int16 x;                       // absolute x coord.
        Int16 y;                       // absolute y coord.
    }
}
