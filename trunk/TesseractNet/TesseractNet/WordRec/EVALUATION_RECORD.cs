using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet.WordRec
{
    public struct EVALUATION_RECORD
    {
        public float match;
        public float certainty;
        public char character;
        public int width;
        public int gap;
    }

    public struct CHUNKS_RECORD
    {
        Matrix ratings;        
        TBlob  chunks;
        Seams splits;
        int x_height;
        WIDTH_RECORD chunk_widths;
        WIDTH_RECORD char_widths;
        Int16 weights;
    }

    public struct Array
{
        uint limit;
        uint top;
        IntPtr[] bases;
} 
    public struct Seams
    {
        Array array;
    }

    public struct WIDTH_RECORD
    {
    }
}

