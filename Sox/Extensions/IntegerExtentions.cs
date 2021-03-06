namespace Sox.Extensions
{
    /// <summary>
    /// Extension methods for Int32
    /// </summary>
    internal static class IntegerExtensions
    {
        /// <summary>
        /// A helper method for getting the byte count of a KB value
        /// </summary>
        /// <param name="value">The amount of KB</param>
        /// <returns>The number of bytes in the amount of KB supplied</returns>
        internal static int Kilobytes(this int value)
        {
            return value * 1000;
        }

        /// <summary>
        /// A helper method for getting the byte count of a MB value
        /// </summary>
        /// <param name="value">The amount of MB</param>
        /// <returns>The number of bytes in the amount of MB supplied</returns>
        internal static int Megabytes(this int value)
        {
            return value * 1000.Kilobytes();
        }
    }
}