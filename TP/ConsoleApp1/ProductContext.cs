using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Model1")
        { }
        public DbSet<Product> Products { get; set; }
    }
}
