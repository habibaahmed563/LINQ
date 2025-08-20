﻿using System.Collections;
using static LINQ.ListGenerator;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LINQ : 40+ Extension Methods 
            //LINQ : 13 Category

            #region filteration Operator - Where / oftype
            // 1.filteration Operator - Where / oftype

            // All Product out stock


            //Fluent syntax
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            //Query syntax [Query Expression]

            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");


            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry" && P.UnitsInStock > 0);


            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //             select P;

            //Indexed Where Valid only in fluent
            //can't be written using Query syntax[Query Expression]
            //var result =ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            // var result =ProductList.Where((P, Index) => Index < 5);
            //var result =ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock > 0);
            //var result =ProductList.Where(p=> p.UnitsInStock>0).Where((P,I) => I<5);


            //ArrayList arraylist = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1, 3, 1, 5, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

            //var result = arraylist.OfType<int>();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region transformation Operators - Select / SelectMany
            //transformation Operators - Select / SelectMany

            //fluent syntax
            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);


            //var result = from P in ProductList
            //             select P.ProductName;

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //            .Select(P=> new 
            //            { P.ProductName,
            //              P.Category,
            //              oldPrice =P.UnitPrice,
            //              newprice =P.UnitPrice*0.1M
            //            });

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 oldPrice = P.UnitPrice,
            //                 newprice = P.UnitPrice * 0.1M
            //             };

            // var result = CustomerList.Select(c => c.CustomerName);
            //var result = CustomerList.SelectMany(c => c.Orders);

            //var result = from c in CustomerList
            //             from O in c.Orders
            //             select c.Orders;

            //Indexed select valid only in fluent syntax
            //can't be written using query syntax
            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region ordering operators 
            // ordering operators 

            //Sorting 

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new { P.ProductName, P.UnitPrice, P.UnitsInStock });
            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //    .Select(P => new
            //    {   P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock 
            //    });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });


            //var result = ProductList.OrderByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //            .Select(P => new
            //            {
            //                P.ProductName,
            //                P.UnitPrice,
            //                P.UnitsInStock
            //            });


            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //            .ThenBy(P=>P.UnitPrice)
            //            .Select(P => new
            //            {
            //                P.ProductName,
            //                P.UnitPrice,
            //                P.UnitsInStock
            //            });


            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //            .ThenByDescending(P => P.UnitPrice)
            //            .Select(P => new
            //            {
            //                P.ProductName,
            //                P.UnitPrice,
            //                P.UnitsInStock
            //            });

            //var result = from P in ProductList
            //             where P.Category=="Meat/Poultry"&& P.UnitsInStock >0
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = ProductList.Reverse<Product>();


            // foreach (var item in result )
            // {
            //     Console.WriteLine(item);
            // }

            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region elements Operators - Imediate Execution
            // elements Operators - Imediate Execution 

            //ProductList = new List<Product>();

            //var result = ProductList.First(); //may throw Exeption [sequance containe no elemwnts]
            //var result = ProductList.Last(); //may throw Exeption [sequance containe no elemwnts]

            //var result = ProductList.First(P=>P.UnitsInStock==1000);//may throw Exeption [sequance containe no elemwnts]
            //var result = ProductList.Last(P=>P.UnitsInStock==0);//may throw Exeption [sequance containe no elemwnts]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName="Default Product"});
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 0);

            //var result = ProductList.ElementAt(1); //May throw Execption
            //var result = ProductList.ElementAtOrDefault(1); 

            //var result = ProductList.Single();//May throw Execption
            //sequance Contains more than one element
            //sequance Contains no element

            //var result = ProductList.Single(P=>P.UnitsInStock==0);//May throw Execption
            //sequance Contains more than one element
            //sequance Contains no element

            //var result = ProductList.SingleOrDefault();//May throw Execption
            //sequance Contains more than one element
            //return Default value [null] if the sequance is Empty

            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Product" });//May throw Execption
            //sequance Contains more than one element
            //return Default value [null] if the sequance is Empty


            //var result = ProductList.SingleOrDefault(P=>P.UnitsInStock==1000);//May throw Execption
            //var result = ProductList.SingleOrDefault(P=>P.ProductID==1);//May throw Execption
            //sequance Contains more than one element
            //sequance Contains no element

            //var result = ProductList.DefaultIfEmpty();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(result?.ProductName?? "Null"); 
            #endregion




        }
    }
}
