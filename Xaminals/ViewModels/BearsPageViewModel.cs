using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class BearsPageViewModel : ViewModel
    {
        public ObservableCollection<Animal> Bears { get; set; }

        private DataSource _dataSource;
        
        private Animal selectedBear;
        public Animal SelectedBear { get => selectedBear; set { selectedBear=value;OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public BearsPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Bears = new ObservableCollection<Animal>(_dataSource.GetBears());
            SelectCommand = new Command(async (x) =>
            {
                var navigationParameter = new Dictionary<string, object>
            {
                { "Bear", SelectedBear }
            };
                await Shell.Current.GoToAsync($"beardetails", navigationParameter);
            });
        }


    }
}
