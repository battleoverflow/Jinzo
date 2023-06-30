using System;
using Jinzo.Conversion;

namespace Jinzo;

public static class Jinzo
{
    public static void Convert(string htmlFile, string outputFile, string? format = null)
    {
        Conversion.FileConversion.Convert(htmlFile, outputFile, format);
    }
}
