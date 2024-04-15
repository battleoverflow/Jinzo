/*
    Project: Jinzo (https://github.com/battleoverflow/Jinzo)
    License: BSD 2-Clause
    Author: battleoverflow (https://github.com/battleoverflow)
*/

using System;
using Jinzo.Utilities;

namespace Jinzo.Conversion;

class PdfConversion {
    public static void Convert(string htmlFile, string outputFile) {
        // Validate HTML file exists
        if (FileValidation.ValidateHtml(htmlFile)) {
            // Check operating system runtime
            if (Utilities.OsValidation.GetOS("Windows")) {
                var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                htmlToPdf.GeneratePdfFromFile(htmlFile, null, outputFile);
            } else {
                throw new NotImplementedException();
            }
        }
    }
}