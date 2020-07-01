using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Product.Map(modelBuilder);
        }

        public DbSet<Product> produtos { get; set; }
    }
}
