using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserContext : DbContext
    {
        public UserContext() : base("Model1")
        { }
        public DbSet<User> Users { get; set; }
    }
}
