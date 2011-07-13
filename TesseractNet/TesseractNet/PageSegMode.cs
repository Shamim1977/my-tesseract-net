using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet
{
    public enum PageSegMode
    {
        PSM_OSD_ONLY,       ///< Orientation and script detection only.
        PSM_AUTO_OSD,       ///< Automatic page segmentation with orientation and
        ///< script detection. (OSD)
        PSM_AUTO_ONLY,      ///< Automatic page segmentation, but no OSD, or OCR.
        PSM_AUTO,           ///< Fully automatic page segmentation, but no OSD.
        PSM_SINGLE_COLUMN,  ///< Assume a single column of text of variable sizes.
        PSM_SINGLE_BLOCK_VERT_TEXT,  ///< Assume a single uniform block of vertically
        ///< aligned text.
        PSM_SINGLE_BLOCK,   ///< Assume a single uniform block of text. (Default.)
        PSM_SINGLE_LINE,    ///< Treat the image as a single text line.
        PSM_SINGLE_WORD,    ///< Treat the image as a single word.
        PSM_CIRCLE_WORD,    ///< Treat the image as a single word in a circle.
        PSM_SINGLE_CHAR,    ///< Treat the image as a single character.

        PSM_COUNT           ///< Number of enum entries.
    };
}
