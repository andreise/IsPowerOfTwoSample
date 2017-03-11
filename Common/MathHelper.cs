using System;

namespace Common
{

    public static class MathHelper
    {

        private static class Messages
        {
            public const string NonNegativeValueRequired = "Value must be equals to or greater than zero.";
        }

        /// <summary>
        /// Tests an unsigned 32-bit integer value for a power of two
        /// </summary>
        /// <param name="value">An unsigned 32-bit integer value</param>
        /// <returns>Returns true if the value is a power of two, otherwise returns false</returns>
        /// <remarks>Must be marked as non-public for CLS-compliant class</remarks>
        public static bool IsPowerOfTwo(uint value) => (value & unchecked(value - 1)) == 0 && value > 0;

        /// <summary>
        /// Tests an unsigned 64-bit integer value for a power of two
        /// </summary>
        /// <param name="value">An unsigned 64-bit integer value</param>
        /// <returns>Returns true if the value is a power of two, otherwise returns false</returns>
        /// <remarks>Must be marked as non-public for CLS-compliant class</remarks>
        public static bool IsPowerOfTwo(ulong value) => (value & unchecked(value - 1)) == 0 && value > 0;

        /// <summary>
        /// Tests a signed 32-bit integer value, treated as an unsigned 32-bit integer value, for a power of two
        /// </summary>
        /// <param name="value">A signed 32-bit integer value</param>
        /// <returns>Returns true if the value, treated as unsigned, is a power of two, otherwise returns false</returns>
        public static bool IsPowerOfTwoUnsigned(int value) => IsPowerOfTwo(unchecked((uint)value));

        /// <summary>
        /// Tests a signed 64-bit integer value, treated as an unsigned 32-bit integer value, for a power of two
        /// </summary>
        /// <param name="value">A signed 64-bit integer value</param>
        /// <returns>Returns true if the value, treated as unsigned, is a power of two, otherwise returns false</returns>
        public static bool IsPowerOfTwoUnsigned(long value) => IsPowerOfTwo(unchecked((ulong)value));

        /// <summary>
        /// Tests a signed 32-bit integer value for a power of two
        /// </summary>
        /// <param name="value">A signed 32-bit integer value</param>
        /// <returns>Returns true if the value is a power of two, otherwise returns false</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws if the value is negative</exception>
        public static bool IsPowerOfTwo(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), value, Messages.NonNegativeValueRequired);

            return IsPowerOfTwoUnsigned(value);
        }

        /// <summary>
        /// Tests a signed 64-bit integer value for a power of two
        /// </summary>
        /// <param name="value">A signed 64-bit integer value</param>
        /// <returns>Returns true if the value is a power of two, otherwise returns false</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws if the value is negative</exception>
        public static bool IsPowerOfTwo(long value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), value, Messages.NonNegativeValueRequired);

            return IsPowerOfTwoUnsigned(value);
        }

        /// <summary>
        /// Tests a signed 32-bit integer value for a power of two
        /// </summary>
        /// <param name="value">A signed 32-bit integer value</param>
        /// <returns>Returns true if the value is non-negative and is a power of two, otherwise returns false</returns>
        public static bool IsPowerOfTwoSilent(int value) => value > 0 && (value & unchecked(value - 1)) == 0;

        /// <summary>
        /// Tests a signed 64-bit integer value for a power of two
        /// </summary>
        /// <param name="value">A signed 64-bit integer value</param>
        /// <returns>Returns true if the value is non-negative and is a power of two, otherwise returns false</returns>
        public static bool IsPowerOfTwoSilent(long value) => value > 0 && (value & unchecked(value - 1)) == 0;

    }

}
