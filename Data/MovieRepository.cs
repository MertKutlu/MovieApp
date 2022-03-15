using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{

    public static class MovieRepository
    {
        private static List<Movie_> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie_>()
            {
                new Movie_()
                 {
                    Id =1 ,
                    Name = "Avangers",
                    Description="<p>Earth's Mightiest Heroes stand as the planet's first line of defense against the most powerful threats in the universe. The Avengers began as a group of extraordinary individuals who were assembled to defeat Loki and his Chitauri army in New York City.</p>",
                    ShortDescription="Avangers Series 1 Movie",
                    ImageUrl="Avangers.jpg",
                    CategoryId=4
                    },


                new Movie_()
                {
                    Id =2 ,
                    Name = "Braveheart",
                    Description="<p>Braveheart is a 1995 American epic historical drama film directed and co-produced by Mel Gibson, who portrays Sir William Wallace, a late-13th-century Scottish warrior. The film depicts the life of Wallace leading the Scots in the First War of Scottish Independence against King Edward I of England.</p>",
                    ShortDescription="Braveheart Movie",
                    ImageUrl="braveheart.jpg",
                    CategoryId=5
                    },
                new Movie_()
                {
                     Id =3 ,
                     Name = "Fast and Furious 5",
                     Description="<p>The Fast and the Furious takes you inside the world of street racing. Dominic Toretto is a gang leader who is accused of hijacking trucks and stealing over a million dollars worth of electronic equipment.</p>",
                     ShortDescription="Fast and Furious Series 5",
                     ImageUrl="fastandfurious.jpg",
                     CategoryId=3
                     },

                new Movie_()

                {
                     Id =4 ,
                     Name = "Lord of the Rings",
                     Description="<p>The story concerns peoples such as Hobbits, Elves, Men, Dwarves, Wizards, and Orcs (called goblins in The Hobbit), and centers on the Ring of Power made by the Dark Lord Sauron. Starting from quiet beginnings in the Shire, the story ranges across Middle-earth and follows the courses of the War of the Ring.</p>",
                     ShortDescription="Lord of the Rings Series 1",
                     ImageUrl="lotr.jpg",
                     CategoryId=5
                    },

                new Movie_()

                {
                     Id =5 ,
                     Name = "Spier-Man",
                     Description="<p>Spider-Man has spider-like abilities including superhuman strength and the ability to cling to most surfaces. He is also extremely agile and has amazing reflexes. Spider-Man also has a “spider sense,” that warns him of impending danger.</p>",
                     ShortDescription="Spier-Man No way to Home",
                     ImageUrl="Spiderman.jpg",
                     CategoryId=3
                    },


            };

        }

        public static List<Movie_> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie_ entity)
        {
            _movies.Add(entity);
        }

        public static Movie_ GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}