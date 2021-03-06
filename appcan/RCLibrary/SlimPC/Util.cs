/*(c)opyright 2013 b6d27bbb0f9ffeafa084af169e90610f767bbf5a
If you modify and distribute source files please be sure to indicate that they have been modified.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RCLibrary.SlimPC
{
    /// <summary>
    /// Set of common functions used by the Disruptor
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// Calculate the next power of 2, greater than or equal to x.
        /// </summary>
        /// <param name="x">Value to round up</param>
        /// <returns>The next power of 2 from x inclusive</returns>
        public static int CeilingNextPowerOfTwo(int x)
        {
            var result = 2;

            while (result < x)
            {
                result *= 2;
            }

            return result;
        }
    }
}
