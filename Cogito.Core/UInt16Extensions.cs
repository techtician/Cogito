﻿namespace Cogito
{

    /// <summary>
    /// Provides extensions against <see cref="ushort"/> values.
    /// </summary>
    public static class UInt16Extensions
    {

        /// <summary>
        /// Calculates the number of trailing zeros in the given unsigned short.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountLeadingZeros(this ushort n)
        {
            if (n == 0)
                return 16;

            return ((uint)n).CountLeadingZeros() - 16;
        }

    }

}
