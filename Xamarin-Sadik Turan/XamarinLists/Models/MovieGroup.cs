using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLists.Models
{
    public class MovieGroup : List<Movie>
    {
        public string GroupName { get; set; }
        public string GroupShortName { get; set; }

        public MovieGroup(string title, string shortName)
        {
            GroupName = title;
            GroupShortName = shortName;
        }
    }
}
