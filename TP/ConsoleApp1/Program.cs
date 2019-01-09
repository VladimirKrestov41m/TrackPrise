using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            ToDb(@"https://www.lamoda.ru/p/mp002xm0ygu0/shoes-alessionesca-slipony/");


          Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


        public static void ToDb(string link)
        {
            Product p = new Product();
            ProductContext pdb = new ProductContext();
            p.Link = link;
            double pn = Double.Parse(Parser(link));
            p.PriceNow = pn;
            p.DesiredPrice = pn;
            p.UserId = 2;
            pdb.Products.Add(p);
            pdb.SaveChanges();
        }
        public static string Parser(string path)
        {
            WebClient wc = new WebClient();
            string Response = wc.DownloadString(path);
            string Rate = System.Text.RegularExpressions.Regex.Match(Response, @"price : { current: '([0-9]+\.[0-9]+)").Groups[1].Value;
            return Rate;
        }
    }
}
