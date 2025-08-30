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
            #region Set Operators [Union Family]
            //var Seq01=Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var Result= Seq01.Union(Seq02);
            //Result= Seq01.Concat(Seq02);
            ////Result = Seq01.Except(Seq02);
            ////Result= Seq01.Intersect(Seq02);
            //Result= Result.Distinct();
            //foreach (var item in Result) { 
            //Console.Write($"{item} ");
            //}
            #endregion
            #region Quantifire Operators
            //var Result = ListGenerator.ProductsList.Any();
            //var Result = ListGenerator.ProductsList.Any(P=>P.UnitsInStock>0);

            //var Result = ListGenerator.ProductsList.All(P => P.UnitsInStock == 0);
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);
            //var Result= Seq01.SequenceEqual(Seq02);
            //Console.WriteLine(Result);
            #endregion
            #region Zipping Operators
            //string[] Names = { "Ali", "Sara", "Mohamed", "Menna" };
            //int[] Numbers=Enumerable.Range(1, 10).ToArray();
            //char[] Chars = { 'a', 'b', 'c', 'd' , 'e'};
            ////var Result=Names.Zip(Chars);
            //var Result = Names.Zip(Numbers,Chars);
            //foreach (var item in Result) {
            //Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            //Groupby
            #region Get Products Grouped By Category
            //var Result = ListGenerator.ProductsList.GroupBy(P => P.Category);
            //var Result = from P in ListGenerator.ProductsList
            //             group P by P.Category;
            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"     {product.ProductName}");
            //    }

            //}

            #endregion
            #region Get Products That Out of Stock Grouped By Category
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).GroupBy(P => P.Category);
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock == 0
            //             group P by P.Category;
            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"     {product.ProductName}");
            //    }

            //}
            #endregion
            #region Get Products In Stock Grouped By Category That Contain More Than 10 Products
            //var Result =ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0)
            //                                       .GroupBy(P=>P.Category)
            //                                       .Where(P=>P.Count()>10);  
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into category
            //             where category.Count()>10
            //             select category;
            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"     {product.ProductName}");
            //    }

            //}
            #endregion
            #region Get Caategory Name Of Products In Stock That Contain More Than 10 Products and Number of Products in Each Category
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0)
            //                                       .GroupBy(P => P.Category)
            //                                       .Where(P => P.Count() > 10)
            //                                       .Select(X=> new
            //                                       {
            //                                           CategoryNmae=X.Key,
            //                                           CountOfProducts=X.Count(),
            //                                       });
            //foreach (var item in Result) { 
            //Console.WriteLine(item);
            //}

            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into category
            //             where category.Count() > 10
            //             select new
            //             {
            //                 CategoryNmae = category.Key,
            //                 CountOfProducts = category.Count(),
            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region Partitioning Operators
            //var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock==0).Take(10);
            //var Result = ListGenerator.ProductsList.Skip(10).Skip(10);
            //var Result = ListGenerator.ProductsList.TakeLast(10);
            //var Result = ListGenerator.ProductsList.SkipLast(10);

            //=============================================================================
            //var Page01= ListGenerator.ProductsList.Take(10);
            //var Page02 = ListGenerator.ProductsList.Skip(10).Take(10);
            //var Page03 = ListGenerator.ProductsList.Skip(10).Skip(10).Take(10);
            //Console.WriteLine("=====================Page01=====================");

            //foreach (var item in Page01)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=====================Page02=====================");

            //foreach (var item in Page02)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=====================Page03=====================");

            //foreach (var item in Page03)
            //{
            //    Console.WriteLine(item);
            //}
            //=============================================================================
            //int[] Numbers = { 5, 6, 7, 1, 2, 4, 8 };
            ////var Result = Numbers.TakeWhile ((N, I) => N > I);
            //var Result = Numbers.SkipWhile(N => N % 3!=0);
            //foreach (var N in Result) {
            //    Console.WriteLine(N);
            //}
            #endregion
        }
    }
}