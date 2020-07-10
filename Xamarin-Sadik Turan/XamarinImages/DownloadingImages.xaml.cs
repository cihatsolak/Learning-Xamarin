using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DownloadingImages : ContentPage
    {
        public DownloadingImages()
        {
            InitializeComponent();
            
            /*
             * Url üzerinden aldığımız image'ler default olarak 24 saat cache'e alınır.
             * Eğer biz cache'a almasın ben uygulamayı her açtığımda yeniden server'dan yenide çeksin diyorsak
             * image cache özelliğini false 'a çekeceğiz.
             * 
             *  CachingEnabled = false //uygulama her açıldığında bu tekrar tekrar resmi yüklicek.
             *  CachingEnabled = true //uygulama her açıldığında tekrar yükleme yapmaz. sadece 1 kez yükler ve cache'e alır.
             */

            //Cache 'li kullanım
            Image cacheImage = new Image { Source = "https://picsum.photos/200" };

            //Süreli Cache'li kullanım.
            var validityCacheImage = new UriImageSource
            {
                Uri = new Uri("https://picsum.photos/200"),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(5,0,0) //5 saat boyunca resmi cache'de tut sonrasonda tekrar çek.
            };

            //Cache'siz kullanım.
            var notCacheImage = new UriImageSource
            {
                Uri = new Uri("https://picsum.photos/200"),
                CachingEnabled = false //uygulama her açıldığında bu tekrar tekrar resmi yüklicek.
            };



            ImageUrl.Source = notCacheImage;
        }
    }
}