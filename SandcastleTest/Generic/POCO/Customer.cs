using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// A customer
    /// </summary>
    public class Customer : Person
    {
        /// <summary>
        /// A customer number 
        /// </summary>
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Overrides the <see cref="ToString"/> method
        /// </summary>
        /// <returns>a string representation of a customer</returns>
        public override string ToString()
        {
            return $"Customer: {CustomerNumber} ({base.ToString()})";
        }
    }
}
