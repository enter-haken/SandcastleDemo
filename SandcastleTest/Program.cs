using SandcastleTest.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandcastleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document
            {
                Title = "Test Title",
                Content = "Test Content"
            };
            doc.Print();

            Console.ReadKey();
        }
    }
}
