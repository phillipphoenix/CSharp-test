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
        /// Find the nearest to a given value and return it.
        /// If multiple matches are found the first is returned.
        /// </summary>
        /// <param name="list">List to look through.</param>
        /// <param name="value">Value to find nearest for.</param>
        /// <returns>The nearest value.</returns>
        public static int? FindNearest(this IEnumerable<int> list, int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find a node that satisfy a given predicate and return it.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="Node{T}"/>.</typeparam>
        /// <param name="node">The current node.</param>
        /// <param name="predicate">The given predicate to satisfy.</param>
        /// <param name="next">Child selector.</param>
        /// <returns>Node satisfying the condtion, else null</returns>
        public static Node<T> FindWhere<T>(this Node<T> node, Func<Node<T>, bool> predicate, Func<Node<T>, IEnumerable<Node<T>>> next)
        {
            throw new NotImplementedException();
        }
    }
}
