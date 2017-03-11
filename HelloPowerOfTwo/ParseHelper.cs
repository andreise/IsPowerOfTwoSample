using System;
using System.Globalization;

namespace HelloPowerOfTwo
{

    static class ParseHelper
    {

        private static IFormatProvider FormatProvider => NumberFormatInfo.InvariantInfo;

        private static int ParseInt32Internal(string s, NumberStyles style) => int.Parse(s, style, FormatProvider);

        public static int ParseInt32(string s) => int.Parse(s, FormatProvider); // NumberStyles.Integer used by default

        public static int ParseNonnegativeInt32(string s) => ParseInt32Internal(s, NumberStyles.Integer & ~NumberStyles.AllowLeadingSign);

        private static int? TryParseInt32Internal(string s, Func<string, int> parse)
        {
            try
            {
                return parse(s);
            }
            catch (Exception e) when (e.IsIntegerParsingException())
            {
                return null;
            }
        }

        public static int? TryParseInt32(string s) => TryParseInt32Internal(s, ParseInt32);

        public static int? TryParseNonnegativeInt32(string s) => TryParseInt32Internal(s, ParseNonnegativeInt32);

    }

}
