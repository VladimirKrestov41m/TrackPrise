using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DbModelTp")
        { }
        public DbSet<Product> Products { get; set; }
    }
}