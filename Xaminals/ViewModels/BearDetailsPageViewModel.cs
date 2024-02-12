using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xaminals.Services;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    [QueryProperty(nameof(Bear), "Bear")]
    public class BearDetailsPageViewModel : ViewModel
    {
        private Animal bear;
        
      
        public Animal Bear { get { return bear; } set { bear = value; OnPropertyChanged();  } }
       
    }
}
