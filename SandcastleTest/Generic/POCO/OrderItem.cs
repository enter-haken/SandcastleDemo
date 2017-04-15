using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// An <see cref="OrderItem"/> for an order
    /// </summary>
    public class OrderItem : PocoBase
    {
        /// <summary>
        /// A <see cref="OrderItem"/>s <see cref="Article"/>
        /// </summary>
        public Article Article { get; set; }

        /// <summary>
        /// How many <see cref="Article"/>s are purchased?
        /// </summary>
        public int Amount { get; set; }
    }
}
