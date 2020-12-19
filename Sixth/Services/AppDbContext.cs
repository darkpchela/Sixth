using Microsoft.EntityFrameworkCore;
using Sixth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixth.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
