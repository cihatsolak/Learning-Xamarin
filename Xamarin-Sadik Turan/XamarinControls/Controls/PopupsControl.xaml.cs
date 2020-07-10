using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupsControl : ContentPage
    {
        public PopupsControl()
        {
            InitializeComponent();
        }

        async void displayAlert(object sender, EventArgs e)
        {
            /*
             * Display alert method'u asenkron bir methodtur.
             * Bizim burada alert box uygulamayı bloklaması lazım, yani kullanıcının cancel butonuna basmadan
             * bir sonraki işe geçmemesi gerekli. Bu şekilde bir çalışma içib asenkron yapı kurmalıyız.
             */
            await DisplayAlert("title", "message", "cancel buton text");
        }

        async void getResponse(object sender, EventArgs e)
        {
            /*
             * Kullanıcı alert'e evet mi? hayır mı dedi?
             */
            bool answer = await DisplayAlert("title", "message", "Evet", "Hayır");
            selectedResult.Text = answer ? "Evet" : "Hayır";
        }

        async void getString(object sender, EventArgs e)
        {
            //Örneğin Kullanıcıya paylaştırma butonu seçtireceğiz. Sallıyorum blog'daki post'u whatsapp'da paylaşacak gibi.
            var answer = await DisplayActionSheet("Nerede Paylaşacaksın?", "İptal", "Sil", "Email", "Twitter", "Facebook", "Whatsapp");
            selectedShare.Text = answer;
        }
    }
}