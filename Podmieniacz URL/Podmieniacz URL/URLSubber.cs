using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Weryfikator
{
    internal class URLSubber
    {
        internal static string SubURLs(string text)
        {
            string pattern = @"(((https?|ftp):\/\/)|mailto:)([^\s\/\$\?\#\:]+(:[^\s\/\$\?\#]*)?\@)?(www\.)?([^\s\/\$\.\?\#]+(\.[^\s\/\$\.\?\#]+)+)([^\s]*)";
            string replacedText = Regex.Replace(text, pattern, "$7"); //"1 = $1 \n 2 = $2 \n 3 = $3 \n 4 = $4 \n 5 = $5 \n 6 = $6 \n 7 = $7 \n 8 = $8 \n 9 = $9"
            return replacedText;
        }
    }
}