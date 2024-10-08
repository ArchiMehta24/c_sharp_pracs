#LinqXML.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace LinqProg
{
    internal class LinqXML
    {
        static void Main()
       {
            XDocument pd = XDocument.Load("C:\\Users\\SXC\\source\\repos\\ConsoleApp2\\ConsoleApp2\\myfile.xml");

            //this connects to start or root point that is the table
            var products = pd.Elements();

            ////////////////Q1////////////////
            Console.WriteLine("display products price >40000 using lamda function");
            var result = products.Elements("Product")
                .Where(x => (int) x.Element("price")>40000)
                .Select(x =>
                        new //if you are picking multiple columns then 'new' keyword is compulsary
                        {
                            Name = x.Element("pname").Value,
                            price = x.Element("price").Value,
                            dom = x.Element("dom").Value, //filters the data that has to be printed
                        }
                );

            foreach ( var r in result ) 
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q2////////////////
            Console.WriteLine("display all products using lambda function");
            var result2 = products.Elements("Product")
                .Select(x =>
                new
                {
                    Name = x.Element("pname").Value,
                    price = x.Element("price").Value,
                    dom = x.Element("dom").Value,
                }
              );

            foreach (var r in result2)
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q3////////////////
            Console.WriteLine("display products manufactured after 10-07-14 using lambda function");
            var result3 = products.Elements("Product")
                .Where(x => DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null))
                .Select(x =>
                new
                {
                    Name = x.Element("pname").Value,
                    price = x.Element("price").Value,
                    dom = x.Element("dom").Value,
                }
             );

            foreach (var r in result3)
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q4////////////////
            Console.WriteLine("display product names manufactured after 10-07-14 using query");
            var pr = from x in products.Elements("Product")
                     where DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null)
                     let nm = (string)x.Element("pname")
                                 select nm;

            foreach (var r in pr)
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q5////////////////
            var v = from x in products.Elements("Product")
                    where (int)x.Element("price") > 40000
                    select new { Name = (string)x.Element("pname"), Price = (int)x.Element("price") };

            v.ToList().ForEach(y => Console.WriteLine(y.Name + " " + y.Price));

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

// #myfile.xml
// <?xml version="1.0" encoding="utf-8" ?>
// <Products>
// 	<Product>
// 		<pid>1</pid>
// 		<pname>delllaptop</pname>
// 		<price>80000</price>
// 		<dom>09-07-14</dom>
// 	</Product>
// 	<Product>
// 		<pid>2</pid>
// 		<pname>hplaptop</pname>
// 		<price>35000</price>
// 		<dom>10-07-14</dom>
// 	</Product>
// 	<Product>
// 		<pid>4</pid>
// 		<pname>acerlaptop</pname>
// 		<price>70000</price>
// 		<dom>12-07-14</dom>
// 	</Product>
// </Products>
