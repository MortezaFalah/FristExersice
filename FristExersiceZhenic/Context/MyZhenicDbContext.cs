using FristExersiceZhenic.Models;
using Microsoft.EntityFrameworkCore;

namespace FristExersiceZhenic.Context
{
    public class MyZhenicDbContext : DbContext
    {
        public MyZhenicDbContext(DbContextOptions<MyZhenicDbContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        public DbSet<Product> Products { get; set; }
    }
}
