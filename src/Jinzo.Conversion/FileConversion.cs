/*
    Project: Jinzo (https://github.com/azazelm3dj3d/Jinzo)
    License: BSD 2-Clause
    Author: azazelm3dj3d (https://github.com/azazelm3dj3d)
*/

using System;

namespace Jinzo.Conversion;

class FileConversion
{
    public static void Convert(string htmlFile, string outputFile, string? format = null)
    {
        // Approved file types
        // These are complete
        string[] fileTypes = {
            "txt"
        };

        // These are being worked on
        // string[] fileTypes = {
        //     "pdf", "xml", "json", "csv"
        // };
        
        foreach (string f in fileTypes) {
            if (format == "txt") {
                Conversion.TxtConversion.Convert(htmlFile, outputFile);
                break;
            } else {
                throw new NotImplementedException();
            }
        }
    }
}
