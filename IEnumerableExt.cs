using System;
using System.Collections.Generic;

namespace ExtMethods
{
    public static class IEnumerableExt
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        { 
            foreach (var item in sequence)
            {
                action(item);
            }
        }
    }
}