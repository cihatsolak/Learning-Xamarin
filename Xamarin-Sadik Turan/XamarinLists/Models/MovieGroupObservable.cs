using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinLists.Models
{
    public class MovieGroupObservable : ObservableCollection<Movie>
    {
        public string GroupName { get; set; }
        public string GroupShortName { get; set; }

        public MovieGroupObservable(string title, string shortName)
        {
            GroupName = title;
            GroupShortName = shortName;
        }
    }
}
