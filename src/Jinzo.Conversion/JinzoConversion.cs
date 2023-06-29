using System;

namespace JinzoConversion
{
    class Conversion
    {
        public static void Convert(string htmlFile, string outputFile, string? format = null)
        {
            FileConversion.Convert(htmlFile, outputFile, format);
        }
    }
}
