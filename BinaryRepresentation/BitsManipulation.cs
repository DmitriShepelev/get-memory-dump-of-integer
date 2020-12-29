using System;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            long mask = 0x01;
            var result = new char[64];
            for (int i = 0; i < 64; i++)
            {
                if ((number & mask) == 0)
                {
                    result[i] = '0';
                }
                else
                {
                    result[i] = '1';
                }

                mask <<= 1;
            }

            Array.Reverse(result);
            return new string(result);
        }
    }
}
