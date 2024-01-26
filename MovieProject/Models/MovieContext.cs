using Microsoft.EntityFrameworkCore;
namespace MovieProject.Models
{
    public class MovieContext : DbContext
    {
        // DbSet<Movie> Movies is a property that represents the collection of all Movie objects
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre() { GenreId = "D", Name = "Drama" },
                new Genre() { GenreId = "C", Name = "Comedy" },
                new Genre() { GenreId = "A", Name = "Action" },
                new Genre() { GenreId = "H", Name = "Horror" },
                new Genre() { GenreId = "M", Name = "Musical" },
                new Genre() { GenreId = "S", Name = "SciFi" },
                new Genre() { GenreId = "R", Name = "RomCom" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { MovieId = 1, Name = "The Godfather", Year = 1972, Rating = 5, GenreId = "D" },
                new Movie() { MovieId = 2, Name = "The Shawshank Redemption", Year = 1994, Rating = 4, GenreId = "D" },
                new Movie() { MovieId = 3, Name = "Schindler's List", Year = 1993, Rating = 3, GenreId = "D" },
                new Movie() { MovieId = 4, Name = "The Matrix", Year = 1980, Rating = 2, GenreId = "S" }
                );
        }
    }

}
