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

        public DbSet<SallesWeb.Models.Department> Department { get; set; }
    }
}
