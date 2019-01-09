using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace TP.Controllers
{
    public class ProductController
    {
        public void ToDb(string link)
        {
            int priceNow = Int32.Parse(Parser(link));
           
        }
        public string Parser(string path)
        {
            WebClient wc = new WebClient();
            string Response = wc.DownloadString(path);
            string Rate = System.Text.RegularExpressions.Regex.Match(Response, @"price : { current: '([0-9]+\.[0-9]+)").Groups[1].Value;
            return Rate;
        }
    }
}