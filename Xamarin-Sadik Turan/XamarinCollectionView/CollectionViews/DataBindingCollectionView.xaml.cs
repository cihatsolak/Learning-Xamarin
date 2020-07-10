using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCollectionView.Models;

namespace XamarinCollectionView.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingCollectionView : ContentPage
    {
        public DataBindingCollectionView()
        {
            InitializeComponent();

            movielist.ItemsSource = FakeDatabase();
        }

        List<MovieModel> FakeDatabase()
        {
            List<MovieModel> movies = new List<MovieModel>();

            movies.Add(new MovieModel
            {
                Id = 1,
                Name = "Hababam Sınıfı",
                Description = "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer",
                Director = "Ertem Eğilmez",
                ImageUrl = "http://tr.web.img3.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/186607.jpg",
                Rating = 5.2
            });

            movies.Add(new MovieModel
            {
                Id = 2,
                Name = "Forrest Gump",
                Description = "Forrest Gump, düşük I.Q. sahibi genç bir adamdır. Jenny ile tanıştığında ona aşık olur. Gump aralarında Elvis Presley, Kennedy, Nixon’ın da olduğu",
                Director = "Robert Zemeckis",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/10568.jpg",
                Rating = 3.6
            });

            movies.Add(new MovieModel
            {
                Id = 3,
                Name = "Geleceğe Dönüş",
                Description = "Geleceğe Dönüş'te, deli dolu bilimadamı Dr. Brown zamanda yolculuğu mümkün kılan bir araba geliştirir. Bu makineyi ilk kullanan genç Marty ufak bir",
                Director = "Robert Zemeckis",
                ImageUrl = "http://tr.web.img3.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/448.jpg",
                Rating = 8.2
            });

            movies.Add(new MovieModel
            {
                Id = 4,
                Name = "Hababam Sınıfı Uyanıyor",
                Description = "Haylazlığına tam gaz devam eden Hababam Sınıfı, çok sevilen serinin bu filminde de pek farklı davranmıyor. Sınıflarına gelen yeni öğrenci Ahmet",
                Director = "Ertem Eğilmez",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/medias/nmedia/18/80/47/86/19548076.jpg",
                Rating = 6.8
            });

            movies.Add(new MovieModel
            {
                Id = 5,
                Name = "Sevginin Gücü",
                Description = "Sevginin Gücü, masum bir kız ve bir katilin hikayesini anlatıyor. Onların birbirlerinden başka kaybedecek hiçbir şeyleri yok. Erkek duygusuzca",
                Director = "Luc Besson",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/medias/nmedia/18/80/20/26/19544797.jpg",
                Rating = 9.5
            });

            return movies;
        }
    }
}