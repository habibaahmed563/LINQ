using System.Collections;
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



        }
    }
}
