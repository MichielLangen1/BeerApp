using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using back_end.Models;

namespace back_end.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Normal Tables
            modelBuilder.Entity<Beer>().ToTable("Beer");
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<User>().ToTable("User");

            //Many to Many table
            modelBuilder.Entity<UserBeer>()
                .HasKey(ub => new { ub.UserID, ub.BeerId});
            modelBuilder.Entity<UserBeer>()
                .HasOne(ub => ub.User)
                .WithMany(u => u.UserBeers)
                .HasForeignKey(ub => ub.UserID);
            modelBuilder.Entity<UserBeer>()
                .HasOne(ub => ub.Beer)
                .WithMany(b => b.UserBeers)
                .HasForeignKey(ub => ub.BeerId);
        }
    }
}