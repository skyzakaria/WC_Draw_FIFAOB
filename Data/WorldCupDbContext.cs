using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WC_Draw_FIFAOB.Models;

namespace WC_Draw_FIFAOB.Data
{
    public class WorldCupDbContext : DbContext
    {
        public DbSet<Team> Teams => Set<Team>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WorldCupDrawDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            modelBuilder.Entity<Team>().Property(t => t.Name).IsRequired().HasMaxLength(100);
        }
    }
}
