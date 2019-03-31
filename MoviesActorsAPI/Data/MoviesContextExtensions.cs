using System.Linq;

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
                    },
                    new Movie()
                    {
                        Name = "The American",
                        ReleaseYear = 2010,
                        Genre = "Crime",
                        Stars = 1,
                        Runtime = 105, 
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/The_American_2010_poster.png/220px-The_American_2010_poster.png",
                        TrailerUrl = "https://www.youtube.com/watch?v=hPYRslx1w4Y"
                    },
                    new Movie()
                    {
                        Name = "All the Kings Men",
                        ReleaseYear = 2006,
                        Genre = "Fiction",
                        Stars = 1,
                        Runtime = 141,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/All_the_kings_men.jpg/220px-All_the_kings_men.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=Ruq0GPvloVc"
                    },
                    new Movie()
                    {
                        Name = "Lost in Translation",
                        ReleaseYear = 2003,
                        Genre = "Comedy",
                        Stars = 1,
                        Runtime = 102,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/4/4c/Lost_in_Translation_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=W6iVPCRflQM"
                    },
                    new Movie()
                    {
                        Name = "BattleField Earth",
                        ReleaseYear = 2000,
                        Genre = "Science Fiction",
                        Stars = 1,
                        Runtime = 118,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/21/Battlefield_earth_poster.jpg/220px-Battlefield_earth_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=yjB_5QAN7a4"
                    },
                    new Movie()
                    {
                        Name = "The Wickerman",
                        ReleaseYear = 2000,
                        Genre = "Horror",
                        Stars = 1,
                        Runtime = 102,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/11/The_Wicker_Man_%281973_film%29_UK_poster.jpg/220px-The_Wicker_Man_%281973_film%29_UK_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=tlvqLOo6apM"
                    },
                    new Movie()
                    {
                        Name = "The Silent House",
                        ReleaseYear = 2010,
                        Genre = "Horror",
                        Stars = 2,
                        Runtime = 86,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/93/Silent_house_poster.jpg/220px-Silent_house_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=LXyM881ye4A"
                    },
                    new Movie()
                    {
                        Name = "The Devils Double",
                        ReleaseYear = 2011,
                        Genre = "Thriller",
                        Stars = 2,
                        Runtime = 109,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/The_Devil%27s_Double.jpg/220px-The_Devil%27s_Double.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=4WASipYKE4k"
                    },
                    new Movie()
                    {
                        Name = "Limitless",
                        ReleaseYear = 2011,
                        Genre = "Mystery",
                        Stars = 2,
                        Runtime = 105,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/17/Limitless_Poster.jpg/220px-Limitless_Poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=6d1Uc68wt3c"
                    },
                    new Movie()
                    {
                        Name = "Scream 4",
                        ReleaseYear = 2011,
                        Genre = "Horror",
                        Stars = 2,
                        Runtime = 111,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d8/Scream4Poster.jpg/220px-Scream4Poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=JKRtyVLWV-E"
                    },
                    new Movie()
                    {
                        Name = "High Life",
                        ReleaseYear = 2009,
                        Genre = "Comedy",
                        Stars = 2,
                        Runtime = 80,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ad/High_Life_poster_small.jpg/220px-High_Life_poster_small.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=qE-zAIepLKE"
                    },
                    new Movie()
                    {
                        Name = "The Book of Eli",
                        ReleaseYear = 2010,
                        Genre = "Action",
                        Stars = 3,
                        Runtime = 118,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e3/Book_of_eli_poster.jpg/220px-Book_of_eli_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=kAMUv22y1og"
                    },
                    new Movie()
                    {
                        Name = "Monsters",
                        ReleaseYear = 2010,
                        Genre = "Thriller",
                        Stars = 3,
                        Runtime = 94,
                        CoverUrl = "https://vignette.wikia.nocookie.net/to-hollywood-and-beyond/images/f/f7/Monsters_2010.jpg/revision/latest/scale-to-width-down/250?cb=20140519202447",
                        TrailerUrl = "https://www.youtube.com/watch?v=nUuUT9ncCQw"
                    },
                    new Movie()
                    {
                        Name = "Borderland",
                        ReleaseYear = 2007,
                        Genre = "Crime",
                        Stars = 3,
                        Runtime = 105,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Borderland_ver2.jpg/220px-Borderland_ver2.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=ivjwqI8t6Zk"
                    },
                    new Movie()
                    {
                        Name = "X-Men: First Class",
                        ReleaseYear = 2011,
                        Genre = "Action",
                        Stars = 3,
                        Runtime = 131,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/X-MenFirstClassMoviePoster.jpg/220px-X-MenFirstClassMoviePoster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=kyQKi5-k0UU"
                    },
                    new Movie()
                    {
                        Name = "Moneyball",
                        ReleaseYear = 2011,
                        Genre = "Drama",
                        Stars = 3,
                        Runtime = 133,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2e/Moneyball_Poster.jpg/220px-Moneyball_Poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=-4QPVo0UIzc"
                    },
                    new Movie()
                    {
                        Name = "For a Few Dollars More",
                        ReleaseYear = 1965,
                        Genre = "Crime",
                        Stars = 4,
                        Runtime = 132,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/For_a_Few_Dollars_More-ita-poster.jpg/220px-For_a_Few_Dollars_More-ita-poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=DDRNEwFOttw"
                    },
                    new Movie()
                    {
                        Name = "American History X",
                        ReleaseYear = 1998,
                        Genre = "Drama",
                        Stars = 4,
                        Runtime = 119,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/39/American_History_X_poster.png/220px-American_History_X_poster.png",
                        TrailerUrl = "https://www.youtube.com/watch?v=XfQYHqsiN5g"
                    },
                    new Movie()
                    {
                        Name = "Butch Cassidy and the Sundance Kid",
                        ReleaseYear = 1969,
                        Genre = "Western",
                        Stars = 4,
                        Runtime = 113,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Butch_sundance_poster.jpg/220px-Butch_sundance_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=YdJW2UxvSFQ"
                    },
                    new Movie()
                    {
                        Name = "Crocodile Dundee",
                        ReleaseYear = 1986,
                        Genre = "Adventure",
                        Stars = 4,
                        Runtime = 104,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a6/Crocodile_Dundee_original_Australian_New_Zealand_poster.jpg/220px-Crocodile_Dundee_original_Australian_New_Zealand_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=rijQ5oBFlO0"
                    },
                    new Movie()
                    {
                        Name = "Die Hard",
                        ReleaseYear = 1988,
                        Genre = "Action",
                        Stars = 4,
                        Runtime = 132,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7e/Die_hard.jpg/220px-Die_hard.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=2TQ-pOvI6Xo"
                    },
                    new Movie()
                    {
                        Name = "Django",
                        ReleaseYear = 2013,
                        Genre = "Western",
                        Stars = 5,
                        Runtime = 165,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/8/8b/Django_Unchained_Poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=_iH0UBYDI4g"
                    },
                    new Movie()
                    {
                        Name = "Saving Private Ryan",
                        ReleaseYear = 1998,
                        Genre = "War",
                        Stars = 5,
                        Runtime = 170,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ac/Saving_Private_Ryan_poster.jpg/220px-Saving_Private_Ryan_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=RYID71hYHzg"
                    },
                    new Movie()
                    {
                        Name = "Unforgiven",
                        ReleaseYear = 1992,
                        Genre = "Western",
                        Stars = 5,
                        Runtime = 131,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4e/Unforgiven_2.jpg/220px-Unforgiven_2.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=ftTX4FoBWlE"
                    },
                    new Movie()
                    {
                        Name = "Slumdog Millionaire",
                        ReleaseYear = 2009,
                        Genre = "Drama",
                        Stars = 5,
                        Runtime = 120,
                        CoverUrl = "https://vignette.wikia.nocookie.net/warner-bros-entertainment/images/9/92/Slumdog_Millionaire_poster.png/revision/latest?cb=20180807150752",
                        TrailerUrl = "https://www.youtube.com/watch?v=AIzbwV7on6Q"
                    },
                    new Movie()
                    {
                        Name = "Interstellar",
                        ReleaseYear = 2014,
                        Genre = "Science Fiction",
                        Stars = 5,
                        Runtime = 172,
                        CoverUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg",
                        TrailerUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E"
                    }
                });
                context.SaveChanges();
            }
        }
    }
}