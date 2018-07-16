using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI.Entities
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Technology> Technologies { get; set; }
    }
}
