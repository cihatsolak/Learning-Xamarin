using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace UdemyCourse.ViewModels
{
    public class HesapMakinesiViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string processCharacter;
        private int total;

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        public ICommand Number
        {
            get
            {
                return new Command((parameter) =>
                {
                    var number = parameter as string;

                    if (!string.IsNullOrEmpty(number))
                        Total = int.Parse(number);
                });
            }
        }

        public ICommand Process
        {
            get
            {
                return new Command((parameter) =>
                {
                    var character = parameter as string;

                    if (!string.IsNullOrEmpty(character))
                        processCharacter = character;
                });
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
