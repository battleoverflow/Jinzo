using System;
using JinzoUtilities;

namespace JinzoConversion
{
    class PdfConversion
    {
        public static void Convert(string htmlFile, string outputFile)
        {
            // Validate HTML file exists
            if (FileValidation.ValidateHtml(htmlFile)) {
                // Check operating system runtime
                if (JinzoUtilities.OsValidation.GetOS("Windows")) {
                    var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                    htmlToPdf.GeneratePdfFromFile(htmlFile, null, outputFile);
                } else {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
