using apiApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiApp.Context
{
    public class MovieInfoContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }

        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
            .HasData(
            new Movie
            {
                Id = 1,
                Name = "Película 1",
                Description = "Descripción de la película 1"
            },
            new Movie
            {
                Id = 2,
                Name = "Película 2",
                Description = "Descripción de la película 2"
            },
            new Movie
            {
                Id = 3,
                Name = "Película 3",
                Description = "Descripción de la película 3"
            }
            );

            modelBuilder.Entity<Cast>()
           .HasData(
           new Cast
           {
               Id = 1,
               Name = "Cast 1",
               Character = "Personaje Cast 1",
               MovieId = 1
           },
           new Cast
           {
               Id = 2,
               Name = "Cast 2",
               Character = "Personaje Cast 2",
               MovieId = 1
           },
           new Cast
           {
               Id = 3,
               Name = "Cast 3",
               Character = "Personaje Cast 3",
               MovieId = 1
           },
           new Cast
           {
               Id = 4,
               Name = "Cast 4",
               Character = "Personaje Cast 4",
               MovieId = 2
           },
           new Cast
           {
               Id = 5,
               Name = "Cast 5",
               Character = "Personaje Cast 5",
               MovieId = 2
           },
           new Cast
           {
               Id = 6,
               Name = "Cast 6",
               Character = "Personaje Cast 6",
               MovieId = 2
           },
           new Cast
           {
               Id = 7,
               Name = "Cast 7",
               Character = "Personaje Cast 7",
               MovieId = 3
           },
           new Cast
           {
               Id = 8,
               Name = "Cast 8",
               Character = "Personaje Cast 8",
               MovieId = 3
           },
           new Cast
           {
               Id = 9,
               Name = "Cast 9",
               Character = "Personaje Cast 9",
               MovieId = 3
           }
           );

            base.OnModelCreating(modelBuilder);
        }
    }
}