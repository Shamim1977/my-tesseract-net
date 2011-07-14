using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet.WordRec
{
    public class TBlob
    {
        public TBlob(TBlob src)
        {
            CopyForm(src);
            string a;
        }

        public  TBlob Copy(TBlob src)
        {
            CopyForm(src);
            return new TBlob(src);
        }

        public static TBlob PolygonalCopy(CBlob src)
        {
            return null;
        }

        private void CopyForm(TBlob src)
        {

        }
        public void Clear()
        {
        }

        public void Normalize(Denorm denorm)
        {
        }

        public void Ratate(Fcoord rotation)
        {
        }

        public void Move(ICoord vec)
        {

        }
        public void Scale(float factor)
        {
        }
        public void ComputeBoundingBoxes()
        {
        }
        public int NumOutlines()
        {
            return 0;
        }

        public Tbox Bounding_box()
        {
            return null;
        }
        public void Plot(ScrollView window,
            Color color,
            Color chile_color)
        {
        }

        public int BbArea()
        {
            int total_area = 0;
            for (TessLine outline = outlines; outline != null; outline = outline.next)
                total_area += outline.BBArea();
            return total_area;
        }

        TessLine outlines;
        public TBlob next;

    }

    public class Tbox
    {
    }
}
