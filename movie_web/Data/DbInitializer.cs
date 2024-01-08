using movie_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Actors.Any())
            {
                return;
            }
            var Actors = new Actor[]
            {
                 new Actor
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictueUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictueUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                           ProfilePictueUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictueUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictueUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
            };
            foreach (Actor a in Actors)
            {
                context.Actors.Add(a);
            }
            context.SaveChanges();

            if (context.Cinemas.Any())
            {
                return;
            }
            var Cinemas = new Cinema[]
            {
                 new Cinema
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
            };
            foreach (Cinema c in Cinemas)
            {
                context.Cinemas.Add(c);
            }
            context.SaveChanges();

            if (context.Produsers.Any())
            {
                return;
            }
            var Produsers = new Produser[]
            {
                new Produser
                        {
                            fullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Produser
                        {
                            fullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Produser
                        {
                            fullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Produser
                        {
                            fullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Produser
                        {
                            fullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
            };
            foreach (Produser p in Produsers)
            {
                context.Produsers.Add(p);
            }
            context.SaveChanges();

            if (context.Movies.Any())
            {
                return;
            }
            var Movies = new Movie[]
            {
                 new Movie
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProduserID = 3,
                            MovieCatagory= MovieCatagory.Documentary
                        },
                        new Movie
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProduserID = 1,
                            MovieCatagory = MovieCatagory.Action
                        },
                        new Movie
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProduserID = 4,
                            MovieCatagory = MovieCatagory.Horror
                        },
                        new Movie
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProduserID = 2,
                            MovieCatagory = MovieCatagory.Documentary
                        },
                        new Movie
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProduserID = 3,
                            MovieCatagory = MovieCatagory.Cartoon
                        },
                        new Movie
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProduserID = 5,
                            MovieCatagory = MovieCatagory.Drama
                        }
            };
            foreach (Movie m in Movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();

            if (context.Actors_Movies.Any())
            {
                return;
            }
            var Actors_Movies = new Actor_Movie[]
            {
                new Actor_Movie
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new Actor_Movie
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new Actor_Movie
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new Actor_Movie
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new Actor_Movie
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new Actor_Movie
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new Actor_Movie
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new Actor_Movie
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new Actor_Movie
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new Actor_Movie
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new Actor_Movie
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new Actor_Movie
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new Actor_Movie
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new Actor_Movie
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new Actor_Movie
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new Actor_Movie
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new Actor_Movie
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
            };
            foreach (Actor_Movie am in Actors_Movies)
            {
                context.Actors_Movies.Add(am);
            }
            context.SaveChanges();
        }
    }
}
