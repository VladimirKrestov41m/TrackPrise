using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace TP.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        ProductsContext db = new ProductsContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Product> products = db.Products;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Products = products;
            // возвращаем представление
            return View();
        }
    }
}