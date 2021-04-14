using System;
using System.Linq;
using DbTest.DAL.Contexts;

namespace DbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BikeStoresContext();
            var products = (from product in context.Products
                           join category in context.Categories
                           on product.CategoryId equals category.CategoryId
                           where product.ProductName.Contains("Trek")
                           select new { name = product.ProductName,
                               category = category.CategoryName
                           }).Take(10);


            foreach(var p in products)
            {
                Console.WriteLine($"Name: {p.name} Category: {p.category}");
            }

            Console.ReadKey();
        }
    }
}
 