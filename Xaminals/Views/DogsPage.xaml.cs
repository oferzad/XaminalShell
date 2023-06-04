using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class DogsPage : ContentPage
    {
        public DogsPage(DogsPageViewModel vm)
        {
            InitializeComponent();
            BindingContext=vm;  
        }

      
    }
}
