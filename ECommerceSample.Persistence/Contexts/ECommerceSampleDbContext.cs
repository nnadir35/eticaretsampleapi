
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceSample.Domain.Entities;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ECommerceSampleDbContext : DbContext
    {
        public ECommerceSampleDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}