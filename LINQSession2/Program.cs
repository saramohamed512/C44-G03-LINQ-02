using System.Collections;
using System.Threading;

namespace LINQSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Operators
            #region Get product out of stoc
            //List<Product> products = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, String> Results = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID,P=>P.ProductName);
            //HashSet<Product> Products = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();
            //OfType()
            //ArrayList obj = new ArrayList() { 
            //    "Ali",
            //    "sara",
            //    "mohamed",
            //    1,
            //    2, 3,
            //};
            //var Result = obj.OfType<int>();
            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #endregion
            #region Generation Operators
            //var Result = Enumerable.Range(0, 100);
            //Result = Enumerable.Repeat(3, 100);
            //var List=Enumerable.Empty<Product>();
            //List<Product> list = new List<Product>();
            
            //foreach (var result in Result) { 
            //    Console.Write($"{result} ");
            
            //}
            #endregion
        }
    }
}