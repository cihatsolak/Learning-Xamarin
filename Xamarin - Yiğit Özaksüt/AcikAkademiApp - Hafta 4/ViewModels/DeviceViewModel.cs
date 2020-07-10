using AcikAkadamiHaftaDort.DepencyServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace AcikAkadamiHaftaDort.ViewModels
{
    public class DeviceViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string deviceName;

        public string DeviceName
        {
            get { return deviceName; }
            set
            {
                deviceName = value;
                OnPropertyChanged(nameof(DeviceName));
            }
        }

        public DeviceViewModel()
        {
            DeviceName = DependencyService.Get<IDeviceHelper>().GetDeviceName();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
