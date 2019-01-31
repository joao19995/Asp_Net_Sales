using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asp_Net_Sales.Models
{
    public class Asp_Net_SalesContext : DbContext
    {
        public Asp_Net_SalesContext (DbContextOptions<Asp_Net_SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Net_Sales.Models.Department> Department { get; set; }
    }
}
