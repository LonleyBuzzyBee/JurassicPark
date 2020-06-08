using Microsoft.EntityFrameworkCore;

namespace JurassicPark.Models
{
    public class JurassicParkContext : DbContext
    {
        public JurassicParkContext(DbContextOptions<JurassicParkContext> options)
            : base(options)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 5, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female" },
                  new Animal { AnimalId = 6, Name = "Rexie", Species = "Dinosaur", Age = 10, Gender = "Female" },
                  new Animal { AnimalId = 7, Name = "Matilda", Species = "Dinosaur", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 24, Name = "Pip", Species = "Sha5", Age = 24, Gender = "Male" },
                  new Animal { AnimalId = 22, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male" }
              );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}