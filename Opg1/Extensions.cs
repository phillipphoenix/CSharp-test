using System;
using System.Collections.Generic;

namespace Opg1
{
    /// <summary>
    /// Implement the missing method(s).
    /// Your implementation must pass as many tests as possible.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Finds the nearest to a given value and returns it.
        /// If multiple matches are found the first is returned.
        /// </summary>
        /// <param name="list">List to look through.</param>
        /// <param name="value">Value to find nearest for.</param>
        /// <returns>The nearest value.</returns>
        public static T Nearest<T>(this IEnumerable<T> list, T value)
            where T : struct
        {
            // Your implementation goes here!
            // GL HF
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches for a given value and returns the found element.
        /// </summary>
        /// <typeparam name="THaystack">Type of the haystack.</typeparam>
        /// <typeparam name="TNeedle">Type of the needle.</typeparam>
        /// <param name="haystack">Haystack to look through.</param>
        /// <param name="needle">Needle to search for.</param>
        /// <returns>The found element, if not found returns default value.</returns>
        public static TNeedle Find<THaystack, TNeedle>(this IEnumerable<THaystack> haystack, TNeedle needle)
        {
            // Your implementation goes here!
            // GL HF
            throw new NotImplementedException();
        }
    }
}
