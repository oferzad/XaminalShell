using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class BearsPage : ContentPage
    {
        public BearsPage(BearsPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;    
        }

       
    }
}
