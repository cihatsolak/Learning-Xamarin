using System.Collections.Generic;

namespace Course.ListYapilari.Model
{
    public class MovieGroupViewModel
    {
        public List<MovieGrup> movies;
        public MovieGroupViewModel()
        {
            movies = new List<MovieGrup>();

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });
        }
    }
}
