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
        /// Searches for a given value and returns found elements.
        /// Supports tree search.
        /// </summary>
        /// <typeparam name="THaystack">Type of the haystack.</typeparam>
        /// <typeparam name="TNeedle">Type of the needle.</typeparam>
        /// <param name="haystack">Haystack to look through.</param>
        /// <param name="needle">Element to search for.</param>
        /// <returns>The found elements, if not found returns default value.</returns>
        public static TNeedle Find<THaystack,TNeedle>(this IEnumerable<THaystack> haystack, TNeedle needle)
        {
            // Your implementation goes here!
            // GL HF
            throw new NotImplementedException();
        }
    }
}
