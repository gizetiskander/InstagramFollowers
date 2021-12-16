﻿using System;
using System.Text.RegularExpressions;

namespace InstLibrary.Extensions
{
    internal static class StringExtensions
    {
        public static string UrlEncode(this string input)
        {
            return Uri.EscapeDataString(input);
        }

        public static bool ContainsWhiteSpace(this string str)
        {
            var regEx = new Regex("\\s");
            var match = regEx.Match(str);
            return match.Success;
        }
    }
}
