namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
                {
                    if (context == null || contextMovie == null)
                    {
                        throw new ArgumentNullException("Null context or contextMovie");
                    }

                    if (context.Movie.Any())
                    {
                        return;
                    }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "Interceptor",
                            ReleasDate = DateTime.Parse("2022-06-03"),
                            Genre = "Action",
                            Price = 9.99M,
                        },

                        new Movie 
                        {
                            Title = "Emergency",
                            ReleaseDate = DateTime.Parse("2022-06-1"),
                            Genre = "Drama",
                            Price = 10.99M,
                        },

                        new Movie
                        {
                            Title = "Spiderhead",
                            ReleaseDate = DateTime.Parse("2022-05-15"),
                            Genre = "Action",
                            Price = 15,99M,
                        }

                          new Movie
                        {
                            Title = "365 Days",
                            ReleaseDate = DateTime.Parse("2022-04-15"),
                            Genre = "Suspense",
                            Price = 7,99M,
                        }
                    );
                    context.SaveChanges();
                }
            
        }
    }
}