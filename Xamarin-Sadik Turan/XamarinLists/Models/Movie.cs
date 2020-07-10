using System;
using Xamarin.Forms;

namespace XamarinLists.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public ImageSource ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
