/*
    Project: Jinzo (https://github.com/battleoverflow/Jinzo)
    License: BSD 2-Clause
    Author: battleoverflow (https://github.com/battleoverflow)
*/

using System;
using Jinzo.Conversion;

namespace Jinzo;

public static class Jinzo {
    public static void Convert(string htmlFile, string outputFile, string? format = null) {
        Conversion.FileConversion.Convert(htmlFile, outputFile, format);
    }
}
