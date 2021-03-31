using AlifLesson22HW30._03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlifLesson22HW30._03.DataContext
{
    public class MarketDBContext : DbContext
    {
        public MarketDBContext(DbContextOptions options) : base(options)
        {
        }

        protected MarketDBContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
