using SandcastleTest.Base;
using SandcastleTest.Generic.DAL.FileSystemStorage;
using SandcastleTest.Generic.POCO;
using System;
using System.Collections.Generic;

namespace SandcastleTest
{
    /// <summary>
    /// A simple test programm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry point of the application
        /// </summary>
        /// <param name="args">are not needed</param>
        static void Main(string[] args)
        {
            var doc = new Document
            {
                Title = "Test Title",
                Content = "Test Content"
            };
            doc.Print();

            var gustav = new Customer
            {
                Id = new Guid("471619aa-5941-4086-a05c-32a4bb46e394"),
                FirstName = "Gustav",
                LastName = "Ganz",
                CustomerNumber = "Test1234"
            };

            var hans = new Customer
            {
                Id = new Guid("38b85e88-5611-423e-b9b4-7d651e404845"),
                FirstName = "Hans",
                LastName = "Wurst",
                CustomerNumber = "Test12345"
            };

            var toiletPaper = new Article
            {
                Name = "Toilet paper",
                BasePrice = 2.0M
            };

            var toothBrush = new Article
            {
                Name = "Toothbrush",
                Description = "electric",
                BasePrice = 40.0M
            };

            var articleAcc = new ArticleAccess();
            articleAcc.Create(toiletPaper);
            articleAcc.Create(toothBrush);

            var order = new Order
            {
                Customer = hans,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Article = toothBrush,
                        Amount = 2
                    },
                    new OrderItem
                    {
                        Article = toiletPaper,
                        Amount = 3
                    }
                }
            };

            var orderAcc = new OrderAccess();
            orderAcc.Create(order);

            var acc = new CustomerAccess();
            acc.Create(hans);
            acc.Create(gustav);

            acc.Delete(gustav);
            acc.Update(gustav);

            hans.LastName = "Wursterich";
            acc.Update(hans);

            var customers = acc.GetList();

            Console.ReadKey();
        }
    }
}
