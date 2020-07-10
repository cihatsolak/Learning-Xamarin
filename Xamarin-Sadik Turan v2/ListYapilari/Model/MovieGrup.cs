using System.Collections.Generic;

namespace Course.ListYapilari.Model
{
    public class MovieGrup : List<Movie>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }

        public MovieGrup(string title, string shortname)
        {
            Title = title;
            ShortName = shortname;
        }
    }
}
