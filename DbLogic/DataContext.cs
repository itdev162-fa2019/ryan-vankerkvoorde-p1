using Domain;
using Microsoft.EntityFrameworkCore;

namespace DbLogic
{
    public class DataContext : DbContext
    {
        public DbSet <Value> Values { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { ID = 1, Name = "Value1"},
                new Value { ID = 2, Name = "Value2"},
                new Value { ID = 3, Name = "Value3"}
            );
        }
    }
}