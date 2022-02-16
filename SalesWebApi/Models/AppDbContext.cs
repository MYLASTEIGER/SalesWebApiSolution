using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models {
    public class AppDbContext : DbContext {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        //only need one contstructor when using the base 
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
        }
    }   
}

