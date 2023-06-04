using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using Xaminals.Data;
using Xaminals.Models;


namespace Xaminals.ViewModels
{
    [QueryProperty(nameof(Name), "name")]
    public class CatDetailPageViewModel : ViewModel
    {
        private readonly DataSource _source;
        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public Animal Cat { get; private set; }

        public CatDetailPageViewModel(DataSource source)
        {
            _source = source;
        }
        void LoadAnimal(string name)
        {
            try
            {
                Cat = _source.GetCats().FirstOrDefault(a => a.Name == name);
                OnPropertyChanged(nameof(Cat));
                
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }



    }
}
