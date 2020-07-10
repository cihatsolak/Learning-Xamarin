using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDataBinding.Models;

namespace XamarinDataBinding.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        void BindData()
        {
            IsRefreshing = true;
            //Service-Call-Start
            Customers.Add(new Customer() { Id = 1, Name = "Cihat Solak", Job = "Software Develeoper" });
            Customers.Add(new Customer() { Id = 2, Name = "Mesut Solak", Job = "It Expert" });
            Customers.Add(new Customer() { Id = 3, Name = "Ferhat Bakan", Job = "Human Resource" });
            //Service-Call-End
            IsRefreshing = false;
        }

        private ICommand deleteCommand, updateCommand, refreshCommand;
        private ObservableCollection<Customer> _customers;
        private bool _isRefreshing;
        public event PropertyChangedEventHandler PropertyChanged;

        public CustomerViewModel()
        {
            deleteCommand = new Command(Handle_Delete);
            updateCommand = new Command(Handle_Update);
            refreshCommand = new Command(OnRefresh);
            BindData();
        }

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get
            {
                if (_customers == null)
                    _customers = new ObservableCollection<Customer>();

                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return updateCommand;
            }
            set
            {
                if (updateCommand == null)
                    return;

                updateCommand = value;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
            set
            {
                if (deleteCommand == null)
                    return;

                deleteCommand = value;
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return refreshCommand;
            }
            set
            {
                if (refreshCommand == null)
                    return;

                refreshCommand = value;
            }
        }

        void Handle_Delete(object param)
        {
            Customer selectedCustomer = (Customer)param;

            if (selectedCustomer != null)
                _customers.Remove(selectedCustomer);
        }

        void Handle_Update(object param)
        {
            Customer selectedCustomer = (Customer)param;
            if (selectedCustomer != null)
                selectedCustomer.Name += $"Güncellendi: {selectedCustomer.Name}";
        }

        void OnRefresh()
        {
            BindData();
        }

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
