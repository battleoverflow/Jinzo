/*
    Project: Jinzo (https://github.com/battleoverflow/Jinzo)
    License: BSD 2-Clause
    Author: battleoverflow (https://github.com/battleoverflow)
*/

using System;

namespace Jinzo.Conversion;

class FileConversion {
    public static void Convert(string htmlFile, string outputFile, string? format = null) {
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
