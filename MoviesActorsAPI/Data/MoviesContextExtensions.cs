using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesActorsAPI.Data
{
    public static class MovieContextExtensions
    {

        public static void EnsureDatabaseSeeded(this MoviesContext context)
        {
            if (!context.Movie.Any())
            {
                context.AddRange(new Movie[] {
                    new Movie()
                    {
                        Name = "Terminator",
                        ReleaseYear = 1984,
                        Genre = "Action",
                        Stars = 5,
                        Runtime = 108
                    },
                    new Movie()
                    {
                        Name = "Terminator 2",
                        ReleaseYear = 1991,
                        Genre = "Action",
                        Stars = 5,
                        Runtime = 156
                    },
                    new Movie()
                    {
                        Name = "Captain Marvel",
                        ReleaseYear = 2019,
                        Genre = "Fantasy",
                        Stars = 4,
                        Runtime = 132
                    },
                    new Movie()
                    {
                        Name = "The Dark Night Rises",
                        ReleaseYear = 2012,
                        Genre = "Action",
                        Stars = 4,
                        Runtime = 165
                    },
                    new Movie()
                    {
                        Name = "Titanic",
                        ReleaseYear = 1997,
                        Genre = "Drama",
                        Stars = 5,
                        Runtime = 195
                    },
                    new Movie()
                    {
                        Name = "Goodfellas",
                        ReleaseYear = 1990,
                        Genre = "Drama",
                        Stars = 5,
                        Runtime = 148
                    },
                    new Movie()
                    {
                        Name = "Avengers: Infinity War",
                        ReleaseYear = 2018,
                        Genre = "Action",
                        Stars = 5,
                        Runtime = 149
                    },
                    new Movie()
                    {
                        Name = "The Room",
                        ReleaseYear = 2003,
                        Genre = "Drama",
                        Stars = 1,
                        Runtime = 109
                    },
                    new Movie()
                    {
                        Name = "Alien",
                        ReleaseYear = 1997,
                        Genre = "Horror",
                        Stars = 4,
                        Runtime = 195
                    },
                    new Movie()
                    {
                        Name = "John Carter",
                        ReleaseYear = 2012,
                        Genre = "Fantasy",
                        Stars = 3,
                        Runtime = 139
                    }
                });
                context.SaveChanges();
            }
        }
    }
}