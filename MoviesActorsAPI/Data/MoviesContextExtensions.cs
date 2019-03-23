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
                        Runtime = 108,  //220 * 328
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/70/Terminator1984movieposter.jpg/220px-Terminator1984movieposter.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=fratdVlBiOM"
                    },
                    new Movie()
                    {
                        Name = "Terminator 2",
                        ReleaseYear = 1991,
                        Genre = "Action",
                        Stars = 5,
                        Runtime = 156,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/85/Terminator2poster.jpg/220px-Terminator2poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=-W8CegO_Ixw"

                    },
                    new Movie()
                    {
                        Name = "Captain Marvel",
                        ReleaseYear = 2019,
                        Genre = "Fantasy",
                        Stars = 4,
                        Runtime = 132,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/8/85/Captain_Marvel_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=Z1BCujX3pw8"
                    },
                    new Movie()
                    {
                        Name = "The Dark Knight Rises",
                        ReleaseYear = 2012,
                        Genre = "Action",
                        Stars = 4,
                        Runtime = 165,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/8/83/Dark_knight_rises_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=GokKUqLcvD8"
                    },
                    new Movie()
                    {
                        Name = "Titanic",
                        ReleaseYear = 1997,
                        Genre = "Drama",
                        Stars = 5,
                        Runtime = 195,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/sco/thumb/2/22/Titanic_poster.jpg/220px-Titanic_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=-iRajLSA8TA"
                    },
                    new Movie()
                    {
                        Name = "Goodfellas",
                        ReleaseYear = 1990,
                        Genre = "Drama",
                        Stars = 5,
                        Runtime = 148,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/7/7b/Goodfellas.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=qo5jJpHtI1Y"
                    },
                    new Movie()
                    {
                        Name = "Avengers: Infinity War",
                        ReleaseYear = 2018,
                        Genre = "Action",
                        Stars = 5,
                        Runtime = 149,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/4/4d/Avengers_Infinity_War_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=6ZfuNTqbHE8"
                    },
                    new Movie()
                    {
                        Name = "The Room",
                        ReleaseYear = 2003,
                        Genre = "Drama",
                        Stars = 1,
                        Runtime = 109,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e1/TheRoomMovie.jpg/220px-TheRoomMovie.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=9-dIdFXeFhs"
                    },
                    new Movie()
                    {
                        Name = "Alien",
                        ReleaseYear = 1979,
                        Genre = "Horror",
                        Stars = 4,
                        Runtime = 117,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Alien_movie_poster.jpg/220px-Alien_movie_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=LjLamj-b0I8"
                    },
                    new Movie()
                    {
                        Name = "John Carter",
                        ReleaseYear = 2012,
                        Genre = "Fantasy",
                        Stars = 3,
                        Runtime = 139,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/aa/John_carter_poster.jpg/220px-John_carter_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=nlvYKl1fjBI"
                    }
                });
                context.SaveChanges();
            }
        }
    }
}