using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDataAccess.FileSystems
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileSystem : ContentPage
    {
        //Uygulamanın data klasörünün yolunu veriyor. Biz bu yol ile txt dosyası oluşturacağız.
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "note.txt");
        public FileSystem()
        {
            InitializeComponent();

            //Dosya daha önce oluşturulmuşsa.
            if (File.Exists(_fileName))
            {
                //dosya içeriğini oku ve editortext'e yaz.
                editor.Text = File.ReadAllText(_fileName);
            }
        }

        private void Handle_Save(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);
        }

        private void Handle_Delete(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }
    }
}