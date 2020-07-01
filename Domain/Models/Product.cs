using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Product
    {
        [Required, Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public static void Map(ModelBuilder modelBuilder)
        {
            var map = modelBuilder.Entity<Product>();
            map.Property(x => x.Id).ValueGeneratedOnAdd();

            map.HasIndex(x => x.Name).IsUnique();
        }
    }
}
