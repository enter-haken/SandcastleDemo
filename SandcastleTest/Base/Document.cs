using System;
using System.Text;

namespace SandcastleTest.Base
{
    /// <summary>
    /// A document
    /// </summary>
    public class Document : IPrintable
    {
        /// <summary>
        /// Documents title. 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content of a document
        /// </summary>
        public string Content { get; set; }

        /// <inheritdoc/>
        public void Print()
        {
            Console.WriteLine(ToString());
        }

        /// <summary>
        /// Get a string representation of a <see cref="Document"/>
        /// </summary>
        /// <returns>the documents <see cref="Title"/> and the <see cref="Content"/></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Content);

            return sb.ToString();
        }
    }
}
