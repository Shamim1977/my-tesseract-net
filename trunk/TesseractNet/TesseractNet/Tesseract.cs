using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet
{
    public class Tesseract
    {
        private PageSegMode mode;
        private string language;

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public void set_value(PageSegMode mode)
        {
            this.mode = mode;
        }

        public void end_tesseract()
        {
            Wordrec.end_recog();
        }
    }
}
