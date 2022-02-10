using Microsoft.EntityFrameworkCore;
using MvcMovies.Data;

namespace MvcMovies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostburster",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostburster 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1954-4-15"),
                        Genre = "Wester",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Avenger",
                        ReleaseDate = DateTime.Parse("2020-2-9"),
                        Genre = "Action",
                        Price = 10.99M
                    }

                );
                context.SaveChanges();
            }

        }
    }
}
