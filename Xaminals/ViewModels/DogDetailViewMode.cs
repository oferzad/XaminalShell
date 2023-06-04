using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
     [QueryProperty(nameof(Name), "name")]
    public class DogDetailPageViewModel : ViewModel
    {
       
        public string Name {
            set
            {
                LoadAnimal(value);
                
            }
        }

        
        public Animal Dog { get; private set; }

       
        void LoadAnimal(string name)
        {
            try
            {
              //  Dog = .FirstOrDefault(a => a.Name == name);
                //
                
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }


    }
}
