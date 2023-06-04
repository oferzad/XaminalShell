using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class DogsPageViewModel : ViewModel
    {
        public ObservableCollection<Animal> Dogs { get; set; }

        private DataSource _dataSource;
        private Animal selectedDog;
        public Animal SelectedDog { get => selectedDog; set { selectedDog = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public DogsPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Dogs = new ObservableCollection<Animal>(_dataSource.GetDogs());

            SelectCommand = new Command(async (x) =>

                // The full route is shown below.
                await Shell.Current.GoToAsync($"//animals/domestic/dogs/dogdetails?name={SelectedDog.Name}"));
            
            
        }



    }
}
