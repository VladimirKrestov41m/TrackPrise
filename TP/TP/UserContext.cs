using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbModelTp")
        { }
        public DbSet<User> Users { get; set; }
    }
}