using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Course.Kontroller.Model
{
    public class LabelViewModel
    {
        [Obsolete]
        public ICommand GotoWebSite => new Command<string>(GotoWebSiteMethod);
     
        [Obsolete]
        void GotoWebSiteMethod(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}
