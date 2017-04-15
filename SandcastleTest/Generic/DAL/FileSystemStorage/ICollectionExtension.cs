using SandcastleTest.Generic.POCO;
using System.Collections.Generic;
using System.Linq;

namespace SandcastleTest.Generic.DAL.FileSystemStorage
{
    /// <summary>
    /// <see cref="IList{T}"/> extensions
    /// </summary>
    public static class ICollectionExtension
    {
        /// <summary>
        /// Replaces a <paramref name="entity"/> in a <paramref name="list"/>
        /// </summary>
        /// <typeparam name="T">type of the list items</typeparam>
        /// <param name="list">the list of poco items</param>
        /// <param name="entity">the list item to replace</param>
        /// <returns>replacement has succeeded?</returns>
        public static bool Replace<T>(this IList<T> list, T entity) where T : PocoBase
        {
            if (list == null)
                return false;

            var possibleMatch = list.FirstOrDefault(x => x.Id == entity.Id);
            if (possibleMatch != null)
            {
                var indexOfPossibleMatch = list.IndexOf(possibleMatch);
                list[indexOfPossibleMatch] = entity;
                return true;
            }

            return false;
        }
    }
}
