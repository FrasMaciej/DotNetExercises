using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace homework4.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext (DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<LoanCost> LoansCosts { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
