using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Link { get; set; }
        public double PriceNow { get; set; }
        public double DesiredPrice { get; set; }

    }
}