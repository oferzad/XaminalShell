using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class MonkeyDetailPageViewModel : ViewModel, IQueryAttributable
    {
        public Animal Monkey { get; private set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Monkey = query["Monkey"] as Animal;
            OnPropertyChanged(nameof(Monkey));
        }

      
    }
}
