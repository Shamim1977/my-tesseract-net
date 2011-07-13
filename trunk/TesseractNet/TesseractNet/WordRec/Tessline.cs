using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet.WordRec
{
    public class TessLine
    {
        public TessLine next;
        public TPoint topleft;
        public TPoint botright;

        public int BBArea()
        {
            return (botright.x - topleft.x) * (topleft.y - botright.y);
        }
    }


}
