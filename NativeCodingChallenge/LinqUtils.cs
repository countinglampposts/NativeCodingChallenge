using System;
using System.Collections.Generic;
using System.Linq;

namespace NativeCodingChallenge
{
    public static class LinqUtils
    {
        public static IEnumerable<int> FilterEven(this IEnumerable<int> enumerable)
        {
            return enumerable
                .Where(n => n % 2 == 0);
        }
    }
}
