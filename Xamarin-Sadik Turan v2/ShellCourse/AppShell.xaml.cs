using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.ShellCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}