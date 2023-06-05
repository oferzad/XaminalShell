using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class CatsPageViewModel : ViewModel
    {
        public ObservableCollection<Animal> Cats { get; set; }

        private DataSource _dataSource;
       
        private Animal selectedCat;
        public Animal SelectedCat { get => selectedCat; set { selectedCat = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public CatsPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Cats = new ObservableCollection<Animal>(_dataSource.GetCats());

            SelectCommand = new Command(async () => {

                // The following route works because route names are unique in this application.
                await Shell.Current.GoToAsync($"catdetails?name={SelectedCat.Name}");  }); 
                 
                // The full route is shown below.
                // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
            
        }




    }
}
