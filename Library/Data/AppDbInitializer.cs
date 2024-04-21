using eTickets.Data.Enums;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Penn Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "See our movies in highest quality using IMAX"
                        },
                        new Cinema()
                        {
                            Name = "Movie House",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Oldest Cinema. We serve KFC and beers!"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Newest cinema on the block. Give it a try"
                        },
                        new Cinema()
                        {
                            Name = "State Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "Owned by the government. Always expensive."
                        },
                        new Cinema()
                        {
                            Name = "Nazareth Cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Has all the scary movies you dare to watch."
                        },
                        new Cinema()
                        {
                            Name = "Heron City",
                            Logo = "https://www.fastighetsvarlden.se/wp-content/uploads/2011/03/Kvadraten2.jpg",
                            Description = "The biggest cinema in Sweden"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tom Hanks",
                            Bio = "Famous for Forrest Gump, Cast Away, and much more",
                            ProfilePictureUrl = "https://media.themoviedb.org/t/p/w500/xndWFsBlClOJFRdhSt4NBwiPq2o.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Morgan Freeman",
                            Bio = "Famous for Shawshank Redemption, Bruce Almighty, and much more",
                            ProfilePictureUrl = "https://m.media-amazon.com/images/M/MV5BMTc0MDMyMzI2OF5BMl5BanBnXkFtZTcwMzM2OTk1MQ@@._V1_FMjpg_UX1000_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Brad Pitt",
                            Bio = "Famous for Fight Club, Troy, and much more",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/1200px-Brad_Pitt_2019_by_Glenn_Francis.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Leonardo DiCaprio",
                            Bio = "Famous for Titanic, Inception, and much more",
                            ProfilePictureUrl = "https://cdn.britannica.com/65/227665-050-D74A477E/American-actor-Leonardo-DiCaprio-2016.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Johnny Depp",
                            Bio = "Famous for Pirates of the Caribbean, Edward Scissorhands, and much more",
                            ProfilePictureUrl = "https://m.media-amazon.com/images/M/MV5BOTBhMTI1NDQtYmU4Mi00MjYyLTk5MjEtZjllMDkxOWY3ZGRhXkEyXkFqcGdeQXVyNzI1NzMxNzM@._V1_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Ella Purnell",
                            Bio = "Famous for Fallout",
                            ProfilePictureUrl = "https://m.media-amazon.com/images/M/MV5BN2UxMTFkNGYtNDUyNy00ZGUzLWE1MzMtM2QxZGRlY2I0MmUyXkEyXkFqcGdeQXVyMTI2Nzk2MjQ1._V1_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Matt LeBlanc",
                            Bio = "One of the stars of Friends",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Chris Tucker",
                            Bio = "Famous for Rush Hour and much more",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "Simply famous, known for a lot, example Maleficent",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Jim Carrey",
                            Bio = "The Grinch, The Mask, Truman Show, and alot more",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Will Smith",
                            Bio = "Men In Black, no need to say more.",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Frank Marshall",
                            Bio = "Indiana Jones producer",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "Schindlers List, Jurassic Park and much more",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "Pulp Fiction, Django Unchained, Inglorious Basterds and more",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Spike Lee",
                            Bio = "Simply known producer    ",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Geoffrey Rush",
                            Bio = "Pirates of the Caribbean and more",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Christopher Nolan",
                            Bio = "Inception, Interstellar, The Dark Knight and more",
                            ProfilePictureUrl = "https://cdn.britannica.com/37/255737-050-9BB3FEDA/Christopher-Nolan-Movie-film-director-Oppenheimer-UK-premiere-2023.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Fallout Episode 1-8",
                            Description = "In a future, post-apocalyptic Los Angeles brought about by nuclear decimation, citizens must live in underground bunkers to protect themselves from radiation, mutants and bandits.",
                            Price = 399.50,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjQ0YjAyNWQtMjRjMC00NzMxLTlkNjEtYWQzNmQwNGRlMGJkXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "The Dark Knight",
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Price = 199.50,
                            ImageUrl = "https://m.media-amazon.com/images/I/91KkWf50SoL._AC_UF1000,1000_QL80_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 6,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Pulp Fiction",
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Price = 99.50,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 6,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Life",
                            Description = "A team of scientists aboard the International Space Station discover a rapidly evolving life form that caused extinction on Mars and now threatens all life on Earth.\r\n\r\n",
                            Price = 79.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
                            Price = 89.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "After a young man is murdered, his spirit stays behind to warn his lover of impending danger, with the help of a reluctant psychic.",
                            Price = 49.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "Jesse Owens' quest to become the greatest track and field athlete in history thrusts him onto the world stage of the 1936 Olympics, where he faces off against Adolf Hitler's vision of Aryan supremacy.",
                            Price = 119.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "Scooby and the gang face their most challenging mystery ever.",
                            Price = 139.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "Paul is an actor who feels bogged down by his participation in a production of Chekov's play, Vanya (PARODY).",
                            Price = 69.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 7
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
