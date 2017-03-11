using System;
using static System.Console;
using static System.FormattableString;
using static Common.Math.MathHelper;

namespace HelloPowerOfTwo
{
    using static ParseHelper;

    static class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Hello HelloPowerOfTwo!");

            const string exitCommand = "Exit";

            WriteLine(Invariant($"Input any integer in range from {0} to {int.MaxValue}, or type '{exitCommand}' to exit."));

            string input;
            while (
                !((input = ReadLine()) is null || input.Trim().Equals(exitCommand, StringComparison.OrdinalIgnoreCase))
            )
            {
                if (input.Length == 0)
                    continue;

                var number = TryParseNonnegativeInt32(input);
                if (number is null)
                    continue;

                WriteLine(
                    IsPowerOfTwo(number.Value) ?
                    Invariant($"Number '{number}' is a power of two.") :
                    Invariant($"Number '{number}' is not a power of two.")
                );
            }
        }

    }

}
