using Xamarin.Forms;
using XamarinCollectionView.Models;

namespace XamarinCollectionView.CollectionViews.DataSelector
{
    public class MovieDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MovieDataTemplate { get; set; }
        public DataTemplate PopularMovieDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var movie = item as MovieModel;

            if (movie.Rating > 4.2) //Eğer rating 4.2 den büyükse populerMovieTemplate'i kullan.
                return PopularMovieDataTemplate;

            return MovieDataTemplate;
        }
    }
}
