using System;

namespace HelloPowerOfTwo
{

    static class ExceptionExtensions
    {
        public static bool IsIntegerParsingException(this Exception e) => e is ArgumentException || e is FormatException || e is OverflowException;
    }

}
