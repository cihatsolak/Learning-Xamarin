using Course.ListYapilari;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.CollectionViewKullanimi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCollectionView : ContentPage
    {
        public string[] Movies { get; set; }
        public SimpleCollectionView()
        {
            InitializeComponent();
            movieList.ItemsSource = new FakeDatabase().Movies;
        }
    }
}