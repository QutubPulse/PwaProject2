using Microsoft.EntityFrameworkCore;
using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<PwaUsers> PwaUsers { get; set; }
        public DbSet<UserSessionDetail> UserSessionDetail { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.inId);
            modelBuilder.Entity<PwaUsers>().HasKey(p => p.inUserId);
            modelBuilder.Entity<UserSessionDetail>().HasKey(p => p.inId);
            base.OnModelCreating(modelBuilder);
        }
    }
}