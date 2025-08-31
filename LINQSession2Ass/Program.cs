using Day_01_G03;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading;

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

        }
    }
}