using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// An order containing a list of <see cref="OrderItem"/> and a <see cref="Customer"/>
    /// </summary>
    public class Order : PocoBase
    {
        /// <summary>
        /// <see cref="OrderItem"/>s of an order
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// The <see cref="Customer"/> for an order
        /// </summary>
        public Customer Customer { get; set; }
    }
}
