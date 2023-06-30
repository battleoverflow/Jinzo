/*
    Project: Jinzo (https://github.com/azazelm3dj3d/Jinzo)
    License: BSD 2-Clause
    Author: azazelm3dj3d (https://github.com/azazelm3dj3d)
*/

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using Jinzo.Utilities;

namespace Jinzo.Conversion;

class TxtConversion
{
    public static void Convert(string htmlFile, string outputFile)
    {
        string htmlContent = ReadFileContents.HtmlContent(htmlFile);

        // Characters and types of data to strip/replace in the HTML
        string[] htmlReplace = {
            "\n", "\t", "\\s+"
        };

        // Characters and types of data to strip/replace in the HTML
        string[] htmlReplaceElements = {
            "<head.*?</head>",
            "<script.*?</script>"
        };

        // This handles new lines, tabs, and whitespace
        foreach (string r in htmlReplace) {
            htmlContent = htmlContent.Replace(r, "");
        }

        // This handles the head and scripts elements
        foreach (string r in htmlReplaceElements) {
            htmlContent = Regex.Replace(htmlContent, r, "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        string[] htmlReplaceSpecialCharsOld = {
            "&nbsp;", "&amp;", "&quot;", "&lt;",
            "&gt;", "&reg;", "&copy;", "&bull;",
            "&trade;", "&#39;"
        };

        string[] htmlReplaceSpecialCharsNew = {
            " ", "&", "\"", "<",
            ">", "®", "©", "â€¢",
            "â„¢", "\'"
        };

        StringBuilder htmlBuilder = new StringBuilder(htmlContent);

        // Replaces html special characters with their counterpart
        for (int s = 0; s < htmlReplaceSpecialCharsOld.Length; s++) {
            htmlBuilder.Replace(htmlReplaceSpecialCharsOld[s], htmlReplaceSpecialCharsNew[s]);
        }

        string[] htmlElementsOld = {
            "<br>", "<br", "<p>"
        };

        string[] htmlElementsNew = {
            "\n<br>", "\n<br", "\n<p"
        };

        // Replaces certain html elements with their counterparts
        for (int e = 0; e < htmlElementsOld.Length; e++) {
            htmlBuilder.Replace(htmlElementsOld[e], htmlElementsNew[e]);
        }

        File.WriteAllText(outputFile, System.Text.RegularExpressions.Regex.Replace(htmlBuilder.ToString(), "<[^>]*>", "\n").Replace(" ", ""));
    }
}
