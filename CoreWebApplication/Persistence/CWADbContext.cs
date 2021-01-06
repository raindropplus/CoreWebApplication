using CoreWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Persistence
{
    public class CWADbContext: DbContext
    {
        public CWADbContext(DbContextOptions<CWADbContext> options)
          : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}
