/*
    Project: Jinzo (https://github.com/azazelm3dj3d/Jinzo)
    License: BSD 2-Clause
    Author: azazelm3dj3d (https://github.com/azazelm3dj3d)
*/

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
