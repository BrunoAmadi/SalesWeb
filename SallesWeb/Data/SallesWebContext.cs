using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWeb.Models;

namespace SallesWeb.Data
{
    public class SallesWebContext : DbContext
    {
        public SallesWebContext (DbContextOptions<SallesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
