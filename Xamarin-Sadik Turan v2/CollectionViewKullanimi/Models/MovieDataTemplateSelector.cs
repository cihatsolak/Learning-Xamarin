using Course.ListYapilari;
using Xamarin.Forms;

namespace Course.CollectionViewKullanimi.Models
{
    public class MovieDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MovieDataTemplate { get; set; }
        public DataTemplate PopularDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var movie = item as Movie;
            return movie.Rating > 4.5 ? PopularDataTemplate : MovieDataTemplate;
        }
    }
}