using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet
{
    public enum OcrEngineMode
    {
        OEM_TESSERACT_ONLY,           // Run Tesseract only - fastest
        OEM_CUBE_ONLY,                // Run Cube only - better accuracy, but slower
        OEM_TESSERACT_CUBE_COMBINED,  // Run both and combine results - best accuracy
        OEM_DEFAULT                   // Specify this mode when calling init_*(),
        // to indicate that any of the above modes
        // should be automatically inferred from the
        // variables in the Language-specific config,
        // command-line configs, or if not specified
        // in any of the above should be set to the
        // default OEM_TESSERACT_ONLY.
    };
}
