using System;

namespace JinzoConversion
{
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
                    JinzoConversion.TxtConversion.Convert(htmlFile, outputFile);
                    break;
                } else {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
