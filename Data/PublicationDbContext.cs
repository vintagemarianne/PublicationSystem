using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PublicationSystem.Models;

namespace PublicationSystem.Data
{
    public class PublicationDbContext : DbContext
    {
        public PublicationDbContext()
        {
            
        }

        public PublicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderItem>();
            modelBuilder.Entity<Publication>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=PublicationSystem;Integrated Security=True");
        }

        //public DbSet<Order> Order { get; set; }
        //public DbSet<OrderItem> OrderItem { get; set; }
        //public DbSet<Publication> Publication { get; set; }
    }
}
