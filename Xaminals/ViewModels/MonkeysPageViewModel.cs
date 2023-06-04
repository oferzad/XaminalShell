using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class MonkeysPageViewModel : ViewModel
    {
        public ObservableCollection<Animal> Monkeys { get; set; }

        private DataSource _dataSource;
        private Animal selectedMonkey;
        public Animal SelectedMonkey { get => selectedMonkey; set { selectedMonkey = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public MonkeysPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Monkeys = new ObservableCollection<Animal>(_dataSource.GetMonkeys());
            SelectCommand = new Command(async (x) =>
            {
                var navigationParameter = new Dictionary<string, object>
            {
                { "Monkey", SelectedMonkey }
            };
                await Shell.Current.GoToAsync($"monkeydetails", navigationParameter);
            });
        }



    }
}
