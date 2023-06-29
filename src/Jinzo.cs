using System;
using JinzoConversion;

namespace Jinzo
{
    public static class Jinzo
    {
        public static void Convert(string htmlFile, string outputFile, string? format = null)
        {
            JinzoConversion.Conversion.Convert(htmlFile, outputFile, format);
        }
    }
}

