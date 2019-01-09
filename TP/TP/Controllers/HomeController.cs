using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TP.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        ProductContext pdb = new ProductContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public bool SignIn(string login, string pass)
        {
            var x = db.Users.Any(t => t.Login == login && t.Password == pass);
            return x;
        }

        public void ToDb(string link)
        {
            Product p = new Product();
            p.Link = link;
            double pn = Double.Parse(Parser(link));
            p.PriceNow = pn;
            p.DesiredPrice = pn;
            p.UserId = 2;
            pdb.Products.Add(p);
            pdb.SaveChanges();
        }
        public string Parser(string path)
        {
            WebClient wc = new WebClient();
            string Response = wc.DownloadString(path);
            string Rate = System.Text.RegularExpressions.Regex.Match(Response, @"price : { current: '([0-9]+\.[0-9]+)").Groups[1].Value;
            return Rate;
        }

        public string ReturnViev()
        {
            List<Product> result = pdb.Products.ToList();
            return JsonConvert.SerializeObject(result);
        }
    }
}