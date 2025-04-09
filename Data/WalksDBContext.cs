using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WalkManagementSystem.Models.Domain;

namespace WalkManagementSystem.Data
{
    public class WalksDBContext : DbContext
    {
        public WalksDBContext(DbContextOptions<WalksDBContext> options) : base(options)
        {
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Difficulty> Difficulty { get; set; }
    }
}
