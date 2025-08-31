using Day_01_G03;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQSession2Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region LINQ - Aggregate Operators
            #region 1.Get the total units in stock for each product category.
            //var totalUnitsByCategory = ListGenerator.ProductsList
            //   .GroupBy(p => p.Category)
            //   .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

            //foreach (var item in totalUnitsByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.TotalUnits}");
            //}

            #endregion
            #region 2.Get the cheapest price among each category's products
            //var cheapestPriceByCategory = ListGenerator.ProductsList
            // .GroupBy(p => p.Category)
            // .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });


            //foreach (var item in cheapestPriceByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.CheapestPrice:C}");
            //}

            #endregion
            #region 3.Get the products with the cheapest price in each category(Use Let)

            //var cheapestProductsByCategory = from p in ListGenerator.ProductsList
            //                                 group p by p.Category into categoryGroup
            //                                 let minPrice = categoryGroup.Min(p => p.UnitPrice)
            //                                 from product in categoryGroup
            //                                 where product.UnitPrice == minPrice
            //                                 select new { Category = categoryGroup.Key, Product = product };


            //foreach (var item in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.Product.ProductName} - {item.Product.UnitPrice:C}");
            //}
            #endregion
            #region 4.Get the most expensive price among each category's products.

            //var mostExpensivePriceByCategory = ListGenerator.ProductsList
            //   .GroupBy(p => p.Category)
            //   .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });

            //foreach (var item in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.MostExpensivePrice:C}");
            //}
            #endregion
            #region 5.Get the products with the most expensive price in each category.

            //var mostExpensiveProductsByCategory = from p in ListGenerator.ProductsList
            //                                      group p by p.Category into categoryGroup
            //                                      let maxPrice = categoryGroup.Max(p => p.UnitPrice)
            //                                      from product in categoryGroup
            //                                      where product.UnitPrice == maxPrice
            //                                      select new { Category = categoryGroup.Key, Product = product };

            //foreach (var item in mostExpensiveProductsByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.Product.ProductName} - {item.Product.UnitPrice:C}");
            //}
            #endregion
            #region 6.Get the average price of each category's products.
            //var averagePriceByCategory = ListGenerator.ProductsList
            // .GroupBy(p => p.Category)
            // .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });


            //foreach (var item in averagePriceByCategory)
            //{
            //    Console.WriteLine($"{item.Category}: {item.AveragePrice:C}");
            //}

            #endregion

            #endregion
            #region   LINQ - Set Operators
            #region 1.Find the unique Category names from Product List
            //var uniqueCategories = ListGenerator.ProductsList
            //.Select(p => p.Category)
            //.Distinct();


            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region 2.Produce a Sequence containing the unique first letter from both product and customer names.
            //var productFirstLetters = ListGenerator.ProductsList
            //.Select(p => p.ProductName[0])
            //.Distinct();

            //var customerFirstLetters = ListGenerator.CustomersList
            //    .Select(c => c.CustomerName[0])
            //    .Distinct();

            //var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);

            //foreach (var letter in uniqueFirstLetters.OrderBy(l => l))
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion
            #region 3.Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters);


            //foreach (var letter in commonFirstLetters.OrderBy(l => l))
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion
            #region 4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var productOnlyFirstLetters = productFirstLetters.Except(customerFirstLetters);

            //foreach (var letter in productOnlyFirstLetters.OrderBy(l => l))
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion
            #region 5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var productLastThreeChars = ListGenerator.ProductsList
            //   .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName);

            //var customerLastThreeChars = ListGenerator.CustomersList
            //    .Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName);

            //var allLastThreeChars = productLastThreeChars.Concat(customerLastThreeChars);


            //foreach (var chars in allLastThreeChars)
            //{
            //    Console.WriteLine(chars);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region 1.Get the first 3 orders from customers in Washington
            //var washingtonCustomers = ListGenerator.CustomersList
            //.Where(c => c.Region == "WA");

            //var first3WashingtonOrders = washingtonCustomers
            //    .SelectMany(c => c.Orders)
            //    .Take(3);


            //foreach (var order in first3WashingtonOrders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #region 2.Get all but the first 2 orders from customers in Washington.
            //var allButFirst2WashingtonOrders = washingtonCustomers
            //.SelectMany(c => c.Orders)
            //.Skip(2);

            //foreach (var order in allButFirst2WashingtonOrders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #region 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result3 = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var num in result3)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //var result4 = numbers.SkipWhile(n => n % 3 != 0);


            //foreach (var num in result4)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region 5.Get the elements of the array starting from the first element less than its position.
            var result5 = numbers.SkipWhile((n, index) => n >= index);

          
            foreach (var num in result5)
            {
                Console.WriteLine(num);
            }
            #endregion

            #endregion










        }
    }
}