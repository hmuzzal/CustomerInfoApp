using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CustomerInfoApp.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
            : base("AppConnectionString")
        {
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}