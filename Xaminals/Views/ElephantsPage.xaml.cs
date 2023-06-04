using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class ElephantsPage : ContentPage
    {
        public ElephantsPage(ElephantsPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;    
        }

      
    }
}
