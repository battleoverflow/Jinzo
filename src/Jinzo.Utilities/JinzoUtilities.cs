/*
    Project: Jinzo (https://github.com/azazelm3dj3d/Jinzo)
    License: BSD 2-Clause
    Author: azazelm3dj3d (https://github.com/azazelm3dj3d)
*/

using System;
using HtmlAgilityPack;

namespace Jinzo.Utilities;

class OsValidation
{
    public static bool GetOS(string os)
    {
        string osInfo = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

        if (osInfo.Contains(os)) {
            return true;
        } else {
            return false;
        }
    }
}

class FileValidation
{
    public static bool ValidateHtml(string htmlFile)
    {
        if (System.IO.File.Exists(htmlFile)) {
            return true;
        } else {
            Console.WriteLine("Unable to locate file");
            return false;
        }
    }
}

class ReadFileContents
{
    public static string HtmlContent(string htmlFile)
    {
        // Load the HTML file
        var htmlDoc = new HtmlDocument();
        htmlDoc.Load(htmlFile);
        return htmlDoc.DocumentNode.OuterHtml;
    }
}
