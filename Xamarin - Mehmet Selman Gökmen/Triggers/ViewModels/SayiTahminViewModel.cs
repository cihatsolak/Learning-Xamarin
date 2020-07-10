using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Windows.Input;
using Xamarin.Forms;

namespace UdemyCourse.ViewModels
{
    public class SayiTahminViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _goal = 0;

        public SayiTahminViewModel()
        {
            BindData();
        }

        void BindData()
        {
            Random random = new Random();
            _goal = random.Next(0, 30);
        }

        public System.Drawing.Color BackGroundColor
        {
            get
            {
                if (Guess == _goal)
                    return System.Drawing.Color.Green;

                if (Guess > _goal)
                    return System.Drawing.Color.Red;

                return System.Drawing.Color.Blue;
            }
        }

        public bool Finished
        {
            get
            {
                if (Guess == _goal)
                    return false;

                return true;
            }
        }

        public bool ResetGameButtonVisible
        {
            get
            {
                if (Guess != _goal)
                    return false;

                return true;
            }
        }

        public string Information
        {
            get
            {
                if (Guess == 0)
                    return string.Empty;

                if (Guess == _goal)
                    return "Tebrikler! Kazandınız";

                if (Guess > _goal)
                    return "Çok oldu azalt.";

                return "Çık! Çık!";
            }
        }


        private int guess;

        public int Guess
        {
            get { return guess; }
            set
            {
                guess = value;
                OnPropertyChanged(nameof(BackGroundColor));
                OnPropertyChanged(nameof(Information));
                OnPropertyChanged(nameof(Guess));
                OnPropertyChanged(nameof(Finished));
                OnPropertyChanged(nameof(ResetGameButtonVisible));
            }
        }

        public ICommand ResetGame
        {
            get
            {
                return new Command(() =>
                {
                    Guess = 0;
                    BindData();
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
