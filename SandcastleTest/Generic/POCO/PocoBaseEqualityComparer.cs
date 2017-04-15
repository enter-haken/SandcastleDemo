using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// Checks a <see cref="PocoBase"/> for equality
    /// </summary>
    public class PocoBaseEqualityComparer : IEqualityComparer<PocoBase>
    {
        /// <summary>
        /// Checks if two <see cref="PocoBase"/> are equal.
        /// </summary>
        /// <param name="x">first <see cref="PocoBase"/></param>
        /// <param name="y">first <see cref="PocoBase"/></param>
        /// <returns><paramref name="x"/> is equal to <paramref name="y"/></returns>
        public bool Equals(PocoBase x, PocoBase y)
        {
            if (x == null && y == null)
                return true;

            if (x == null ^ y == null)
                return false;

            return x.Id == y.Id;

        }

        /// <summary>
        /// Gets the hashcode for a <see cref="PocoBase"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(PocoBase obj)
        {
            return obj.GetHashCode();
        }
    }
}
