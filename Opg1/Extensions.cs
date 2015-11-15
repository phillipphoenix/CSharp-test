using System;
using System.Collections;
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

            int? current = null; // The currently closest value.
            int distance = int.MaxValue; // The distance from the searched for value to the current closest value.

            foreach (int n in list)
            {
                // Check if the absolute value between value and the current number in the list is less than the currently saved distance.
                if (Math.Abs(n - value) < distance)
                {
                    // If so, save the current number in the list as the closest one and save its distance to the value searched for.
                    current = n;
                    distance = Math.Abs(n - value);
                }
            }

            // Return the value found (if any) or null, if no values found.
            return current;
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
            if (predicate(node)) // If the current node satisfies the predicate, return it.
            {
                return node;
            }
            else // If not, call the function on all the children and return the result if they satisfied the predicate.
            {
                IEnumerable<Node<T>> children = next(node);
                foreach (Node<T> child in children)
                {
                    Node<T> result = child.FindWhere(predicate, next);
                    if (result != null)
                    {
                        return result;
                    }
                }
                // If no children (or children's children) satisfied the predicate, return null.
                return null;
            }
        }
    }
}
