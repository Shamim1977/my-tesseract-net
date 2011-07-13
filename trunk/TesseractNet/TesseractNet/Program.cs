using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace TesseractNet
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                printUsage("");
                return;
            }
            if ((args.Length == 1 && args[0] == "-v") || (args.Length == 1 && args[0] == "--version"))
            {
                Console.WriteLine(string.Format("tesseract-{0}",TessBaseAPI.Version()));
                Console.ReadKey();
                return;
            }

            string lang = "eng";
            string image = "";
            string output = "";

            PageSegMode pagesegmode = PageSegMode.PSM_AUTO;
            int arg = 0;
            int argc = args.Length;
            while (arg < argc && (output == string.Empty || args[arg].StartsWith("-")))
            {
                if (args[arg] == "-l" && arg + 1 < argc)
                {
                    lang = args[arg + 1];
                    ++arg;
                }
                else if (args[arg] == "-psm" && arg + 1 < argc)
                {
                    //assign pagesegmode                  

                    ++arg;
                }
                else if (image == string.Empty)
                {
                    image = args[arg];
                }
                else if (output == string.Empty) 
                {
                    output = args[arg];
                }
                ++arg;
            }

            if (string.IsNullOrEmpty(output))
            {
                printUsage(args[0]);
                return;
            }

            TessBaseAPI api = new TessBaseAPI();

            api.SetOutputName(output);
            api.SetPageSegMode(pagesegmode);
            api.Init(args[0],
                lang,
                OcrEngineMode.OEM_DEFAULT,
                args[arg-1],
                argc-arg,
                null,
                null,
                false);
            Console.WriteLine(string.Format("Tesseract Open Source OCR Engine v{0} with Leptonica\n",
                TessBaseAPI.Version()));

            string text_out=string.Empty;
            if (!api.ProcessPages(image, null, 0, ref text_out))
            {
                Console.WriteLine("Error during processing.\n");
            }

            bool output_hocr = false;
            api.GetBoolVariable("tessedit_create_hocr", ref output_hocr);
            bool output_box = false;
            api.GetBoolVariable("tessedit_create_boxfile", ref output_box);
            string outfile = output;

            outfile += output_hocr ? ".html" : output_box ? ".box" : ".txt";

            File.WriteAllText(outfile, text_out);

        }

        private static void printUsage(string name)
        {
            Console.WriteLine(string.Format("Usage:{0} imagename outputbase [-l lang] [-psm pagesegmode] [configfile...]\n",
                   name));

            Console.WriteLine("pagesegmode values are:\n" +
                "0 = Orientation and script detection (OSD) only.\n" +
                "1 = Automatic page segmentation with OSD.\n" +
                "2 = Automatic page segmentation, but no OSD, or OCR\n" +
                "3 = Fully automatic page segmentation, but no OSD. (Default)\n" +
                "4 = Assume a single column of text of variable sizes.\n" +
                "5 = Assume a single uniform block of vertically aligned text.\n" +
                "6 = Assume a single uniform block of text.\n" +
                "7 = Treat the image as a single text line.\n" +
                "8 = Treat the image as a single word.\n" +
                "9 = Treat the image as a single word in a circle.\n" +
                "10 = Treat the image as a single character.\n");

            Console.WriteLine("-l lang and/or -psm pagesegmode must occur before any configfile.\n");
            Console.ReadKey();
            return;
        }
    }
}
