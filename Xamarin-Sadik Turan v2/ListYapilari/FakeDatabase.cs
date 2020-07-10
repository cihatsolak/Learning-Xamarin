using System.Collections.Generic;

namespace Course.ListYapilari
{
    public class FakeDatabase
    {
        public List<Movie> Movies { get; set; }

        public FakeDatabase()
        {
            Movies = new List<Movie>
            {
                new Movie{ Id = 1, Name="The Walking Dead", ImageUrl="https://image.tmdb.org/t/p/w600_and_h900_bestv2/5l10EjdgPxu8Gbl5Ww6SWkVQH6T.jpg", Director="Frank Darabont", Rating=4.9},
                new Movie{ Id =2, Name="Bloodshot", ImageUrl="https://image.tmdb.org/t/p/w600_and_h900_bestv2/8WUVHemHFH2ZIP6NWkwlHWsyrEL.jpg",Director="Jeff Wadlow", Rating=6.9 },
                new Movie{ Id =3, Name="Scoob!", ImageUrl="https://image.tmdb.org/t/p/w600_and_h900_bestv2/zG2l9Svw4PTldWJAzC171Y3d6G8.jpg",Director="Tony Cervone", Rating=8.9 },
                new Movie{ Id =4, Name="The Wrong Missy", ImageUrl="https://image.tmdb.org/t/p/w600_and_h900_bestv2/A2YlIrzypvhS3vTFMcDkG3xLvac.jpg",Director="Tyler Spindel", Rating=4.9 },
                new Movie{ Id =5, Name="Bad Boys for Life", ImageUrl="https://image.tmdb.org/t/p/w600_and_h900_bestv2/y95lQLnuNKdPAzw9F9Ab8kJ80c3.jpg",Director="Adil El Arbi", Rating=2.5 }
            };
        }
    }
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Cihat";
        public string ImageUrl { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
    }
}
