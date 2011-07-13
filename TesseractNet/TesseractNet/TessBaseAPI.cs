using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet
{
    public class TessBaseAPI
    {
        private static string version = "3.0.1";
        /*
        Tesseract* tesseract_;       ///< The underlying data object.
        Tesseract* osd_tesseract_;   ///< For orientation & script detection.
        ImageThresholder* thresholder_;     ///< Image thresholding module.
        BLOCK_LIST* block_list_;      ///< The page layout.
        PAGE_RES* page_res_;        ///< The page-level data.
        STRING* input_file_;      ///< Name used by training code.
        STRING* output_file_;     ///< Name used by debug code.
        STRING* datapath_;        ///< Current location of tessdata.
        STRING* language_;        ///< Last initialized Language.
        OcrEngineMode last_oem_requested_;  ///< Last ocr Language mode requested.
        bool recognition_done_;   ///< page_res_ contains recognition data.
        TruthCallback* truth_cb_;           /// fxn for setting truth_* in WERD_RES
*/

        protected Tesseract tesseract;
        protected string output_file;
        protected string datapath;
        protected string language;
        protected OcrEngineMode last_oem_requested;

        public static string Version()
        {
            return version;
        }

        public void SetOutputName(string output)
        {
            this.output_file = output;
        }

        public void SetPageSegMode(PageSegMode mode)
        {
            if (this.tesseract == null)
            {
                this.tesseract = new Tesseract();
            }

            tesseract.set_value(mode);
        }

        public int Init(string datapath,
            string language,
            OcrEngineMode oem,
            string configs,
            int configs_size,
            List<string> vars_vec,
            List<string> vars_values,            
            bool set_only_init_params)
        {
     //       if (tesseract_ != NULL &&
     //(datapath_ == NULL || language_ == NULL ||
     // *datapath_ != datapath || last_oem_requested_ != oem ||
     // (*language_ != Language && tesseract_->lang != Language)))
     //       {
     //           tesseract_->end_tesseract();
     //           delete tesseract_;
     //           tesseract_ = NULL;
     //       }
            if (tesseract != null &&
                (string.IsNullOrEmpty(datapath) || string.IsNullOrEmpty(language) ||
                this.datapath != datapath || !last_oem_requested.Equals(oem) ||
                (this.language != language && tesseract.Language != language)))
            {
                tesseract.end_tesseract();
                tesseract = null;
            }

            return 0;
        }

        public bool ProcessPages(string filename,
            string retry_config,
            int timeout_millisec,
            ref string text_out)
        {
            text_out = "un-implemented.";
            return true;
        }

        public bool GetBoolVariable(string name, ref bool value)
        {
            value = false;
            return false;
        }

    }
}
