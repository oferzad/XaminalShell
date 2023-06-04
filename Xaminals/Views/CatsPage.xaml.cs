using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class CatsPage : ContentPage
    {
        public CatsPage(CatsPageViewModel vm)
        {
            InitializeComponent();
            BindingContext=vm;
        }

       
    }
}
