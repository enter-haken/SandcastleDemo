using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// An article
    /// </summary>
    public class Article : PocoBase
    {
        /// <summary>
        /// Name of the article
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Further description of an article. This is optional
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Base price for an article
        /// </summary>
        public decimal BasePrice { get; set; }
    }
}
