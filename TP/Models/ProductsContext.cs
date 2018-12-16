using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}